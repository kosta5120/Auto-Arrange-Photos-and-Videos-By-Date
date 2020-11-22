using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SortingPhotosByDate.ViewModel
{
    public class ApplyAllFiles
    {
        public List<string> ApplyFiles(string folder, List<string> paths)
        {
            foreach (string file in Directory.GetFiles(folder))
            {
                try
                {
                    if(Regex.IsMatch(file.ToLower(), @"jpg|jpeg|png|gif|tiff|bmp|mp4|svg|mov$") && !Regex.IsMatch(file, @"\d{4}-\d{2}"))
                        paths.Add(file);
                }
                catch {}
            }
            foreach (string subDir in Directory.GetDirectories(folder))
            {
                try
                {
                    ApplyFiles(subDir, paths);
                }
                catch {}
            }

            return paths;
        }
    }
}
