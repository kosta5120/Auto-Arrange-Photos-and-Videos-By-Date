using System;
using System.Windows.Input;
using SortingPhotosByDate.Model;


namespace SortingPhotosByDate.Commands
{
    public class DelegateCommand : ICommand
    {
        public Action<ImagePathModel> CommandAction { get; set; }
        
        public Func<bool> CanExecuteFunc { get; set; }
        public DelegateCommand(Action<ImagePathModel> action)
        {
            CommandAction = action;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            CommandAction(parameter as ImagePathModel);
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteFunc == null || CanExecuteFunc();
        }
    }
}
