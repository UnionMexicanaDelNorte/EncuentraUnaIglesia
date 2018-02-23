using System;
using maptest.Model;

namespace maptest.ViewModels
{
    public class CatalogoViewModel : NotificationEnabledObject
    {
        ServiceIglesia service;
        public CatalogoViewModel()
        {
            service = new ServiceIglesia();
        }
        private ActionCommand<String> _SearchCommand;
        public ActionCommand<String> SearchCommand
        {
            get
            {
                if (_SearchCommand == null)
                {
                    _SearchCommand = new ActionCommand<string>((param) =>
                    {
                        service.GetIglesias("cd", "laredo");
                    });
                }
                return _SearchCommand;
            }
            set
            {
                _SearchCommand = value;
                OnPropertyChanged();
            }
        }
        private string _TextFilter;
        public string TextFilter
        {
            get { return _TextFilter; }
            set
            {
                _TextFilter = value;
                OnPropertyChanged();
            }
        }
    }
}
