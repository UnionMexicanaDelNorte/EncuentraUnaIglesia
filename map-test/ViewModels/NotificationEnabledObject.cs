using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace maptest.ViewModels
{
    public class NotificationEnabledObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
