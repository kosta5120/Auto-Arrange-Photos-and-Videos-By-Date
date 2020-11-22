using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using SortingPhotosByDate.Commands;
using SortingPhotosByDate.Model;

namespace SortingPhotosByDate.ViewModel
{
    public class ArrangPhotosViewModel
    {
        private DateTime lastModified { get; set; }
        public ICommand ArrangCommand => new DelegateCommand(Sorting);

        public async void Sorting(ImagePathModel imagePathModel)
        {

            if (imagePathModel.NewPath.Contains("Choose") || imagePathModel.PathOfImages.Contains("Choose"))
                MessageBox.Show("Directories was not selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int i = 0;
                imagePathModel.IsEnabled = false;
                var location = imagePathModel.PathOfImages;
                var newLocation = imagePathModel.NewPath;
                var dateMonth = string.Empty;
                imagePathModel.NewLocation = new ObservableCollection<string>();


                List<string> paths = new List<string>();
                ApplyAllFiles applyAllFiles = new ApplyAllFiles();

                paths = applyAllFiles.ApplyFiles(location, paths);

                if (paths.Count == 0)
                {
                    MessageBox.Show("There is no photos or videos to arrange", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    imagePathModel.IsEnabled = true;
                }

                else
                {
                    imagePathModel.ProgBarLength = paths.Count;
                    var progress = new Progress<int>(value => imagePathModel.ProgBarValue = value);
                    await Task.Run(() =>
                    {
                        try
                        {
                            foreach (var file in paths)
                            {
                                i++;
                                var trg = string.Empty;
                                var src = file;
                                try
                                {
                                    lastModified = File.GetLastWriteTime(file);
                                    var fileName = Path.GetFileName(file);
                                    dateMonth = lastModified.ToString("yyyy-MM");
                                    Regex date = new Regex(@"(?<date>20\d[0-9]+)");
                                    var matchDate = date.Match(fileName);

                                    if (matchDate.Success)
                                    {
                                        try
                                        {
                                            var dateFromFileName = DateTime.ParseExact(matchDate.Groups["date"].Value.ToString(), "yyyyMMdd", null); /*DateTime.Parse(matchDate.Groups["date"].Value);*/

                                            if (dateFromFileName < lastModified)
                                                dateMonth = dateFromFileName.ToString("yyyy-MM");
                                        }
                                        catch { }

                                    }

                                    trg = $"{newLocation}\\{dateMonth}";
                                    Directory.CreateDirectory(trg);

                                    if (File.Exists($"{trg}\\{fileName}") && new FileInfo(file).Length != new FileInfo($"{trg}\\{fileName}").Length || File.Exists($"{trg}\\{fileName}") && new FileInfo(src).Length == new FileInfo($"{trg}\\{fileName}").Length)
                                    {

                                        trg = Path.Combine(trg,
                                                            string.Concat(Path.GetFileNameWithoutExtension(fileName) + "_",
                                                            DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                                                            Path.GetExtension(fileName)));

                                        File.Move(src, trg);
                                    }
                                    else
                                    {
                                        trg = $"{trg}\\{fileName}";
                                        File.Move(src, trg);
                                    }

                                    ((IProgress<int>)progress).Report(i);
                                    Thread.Sleep(100);
                                    App.Current.Dispatcher.Invoke((Action)delegate
                                    {
                                        imagePathModel.NewLocation.Add(trg);
                                    });
                                }
                                catch
                                {
                                    trg = $"{newLocation}\\No date";
                                    Directory.CreateDirectory(trg);
                                    File.Move(src, trg);
                                }

                            }

                            var dialorResult = MessageBox.Show("Finished to sort all files.\n\rDo you whant to open the location of sorted files?", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialorResult == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start(newLocation);
                                imagePathModel.IsEnabled = true;
                            }
                            else
                            {
                                imagePathModel.IsEnabled = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                }

            }

        }
    }
}
