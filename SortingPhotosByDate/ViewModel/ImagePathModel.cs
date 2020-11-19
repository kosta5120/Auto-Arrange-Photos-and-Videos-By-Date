using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingPhotosByDate.Model;

namespace SortingPhotosByDate.Model
{
    public class ImagePathModel : ObservableObject
    {
        private string _newPath = "Choose where to save the sorted Photos / Videos";
        private string _pathOfImages = "Choose your directory of Photos / Videos";
        private ObservableCollection<string> _newLocation;
        private int progBarLength = 100;
        private int progBarValue = 0;
        private bool isEnabled = true;

        public string NewPath
        {
            get { return _newPath; }
            set
            {
                if (value != null)
                    _newPath = value;
                OnPropertyChanged("NewPath");
            }
        }

        public string PathOfImages
        {
            get { return _pathOfImages; }
            set
            {
                if (value != null)
                    _pathOfImages = value;
                OnPropertyChanged("PathOfImages");
            }
        }

        public ObservableCollection<string> NewLocation
        {
            get { return _newLocation; }
            set
            {
                if (value != null)
                    _newLocation = value;
                OnPropertyChanged("NewLocation");
            }
        }

        public int ProgBarLength
        {
            get { return progBarLength; }
            set
            {
                progBarLength = value;
                OnPropertyChanged("ProgBarLength");
            }
        }
       
        public int ProgBarValue
        {
            get { return progBarValue; }
            set
            {
                progBarValue = value;
                OnPropertyChanged("ProgBarValue");
            }
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }

    }
}
