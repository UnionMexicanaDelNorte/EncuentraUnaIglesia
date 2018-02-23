using System;
using System.Windows.Input;

namespace maptest.ViewModels
{
    public class ActionCommand<T> : ICommand
    {
        Action<T> action;
        public event EventHandler CanExecuteChanged;

        public ActionCommand(Action<T> _action)
        {
            this.action = _action;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => action((T)parameter);
    }
}
