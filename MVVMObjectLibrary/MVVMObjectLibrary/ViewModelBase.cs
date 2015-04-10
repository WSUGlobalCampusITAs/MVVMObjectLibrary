using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MVVMObjectLibrary
{
    /// <summary>
    /// Base class for all project View Models
    /// Provides interface elements for INotify, and IDisposable
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        protected ICommand _settingsCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SettingsCommand { get { return _settingsCommand; } }

        protected ViewModelBase()
        {
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose()
        { }
    }
}
