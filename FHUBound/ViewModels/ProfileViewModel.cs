using System;
using System.Collections.Generic;
using System.Text;
using FHUBound.Models;
using System.ComponentModel;

namespace FHUBound.ViewModels
{
    class ProfileViewModel: INotifyPropertyChanged
    {
        public User User { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public ProfileViewModel()
        {
            User = App.CurrentUser;
        }
    }
}
