using System;
namespace maptest.ViewModels
{
    public class CatalogoViewModel : NotificationEnabledObject
    {
        public CatalogoViewModel()
        {
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
                        var pa = TextFilter;
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
