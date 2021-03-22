using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IPMS_KLK.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName ="")
        {
            var changed = PropertyChanged;
            if (changed == null) 
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        protected void SetValue<T> (ref T backingField, T value,[CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
                return;

            backingField = value;

            OnPropertyChanged(propertyName);
        }

        protected bool SetProperty<T>(ref T backingstore, T value,[CallerMemberName] string propertyName = "",Action onChanged =null
            )
        {
            if (EqualityComparer<T>.Default.Equals(backingstore, value))
                return false;

            backingstore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
