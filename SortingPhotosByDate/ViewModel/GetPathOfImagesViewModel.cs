using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingPhotosByDate.Model;
using SortingPhotosByDate.Commands;
using System.Windows.Forms;
using System.Windows;
using System.Reflection;
using System.Windows.Input;

namespace SortingPhotosByDate.ViewModel
{
    class GetPathOfImagesViewModel
    {
        public ICommand LocationOfImages => new DelegateCommand(GetLocation);
        public ICommand NewLocationOfImages => new DelegateCommand(Newlocation);
        public void GetLocation(ImagePathModel imagePathModel)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePathModel.PathOfImages = dialog.SelectedPath.ToString();
                }
            }
        }

        public void Newlocation(ImagePathModel imagePathModel)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePathModel.NewPath = dialog.SelectedPath.ToString();
                }
            }
        }

    }
}
