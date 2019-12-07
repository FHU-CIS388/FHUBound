using System;
using System.Collections.Generic;
using System.Text;
using FHUBound.ViewModels;
using System.ComponentModel;

namespace FHUBound.Models
{
    public class User: BaseViewModel, INotifyPropertyChanged
    {
        
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public string Address { get; set; }


        

        
        public string Fullname
        {
            get
            {
                return string.Format("{0} {1}", Firstname, Lastname);
            }
            
        }

        
        private int totalPoints = 0;
        public int TotalPoints {
            get { return totalPoints; }
            set { SetProperty(ref totalPoints, value); }
        }

        

        public User()
        {

        }
    }
}
