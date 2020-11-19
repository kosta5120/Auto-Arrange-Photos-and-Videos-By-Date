
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingPhotosByDate.Model;
using SortingPhotosByDate.ViewModel;



namespace UnitTestProjectForSP
{
    [TestClass]
    public class UnitTest1
    {
        private ImagePathModel imagPathModel = new ImagePathModel();
        private ArrangPhotosViewModel sp = new ArrangPhotosViewModel();


        [TestMethod]
        public void TestRunSorting()
        {
            imagPathModel.PathOfImages = @"Choose your directory of Photos / Videos";
            imagPathModel.NewPath = @"Choose where to save the sorted Photos / Videos";

            sp.Sorting(imagPathModel);
        }
    }
}
