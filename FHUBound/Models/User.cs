using FHUBound.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    public class User : BaseViewModel
    {
        private string userName;
        public string Username
        {
            get { return userName; }
            set { SetProperty(ref userName, value); }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value); }
        }

        private string lastName;
        public string LastName
        {
            get { return LastName; }
            set { SetProperty(ref lastName, value); }
        }


        private int totalPoints;
        public int TotalPoints
        {
            get { return totalPoints; }
            set { SetProperty(ref totalPoints, value); }
        }



        private int points;
        public int Points
        {
            get { return points; }
            set { SetProperty(ref points, value); }
        }

        private int level;
        public int Level
        {
            get { return level; }
            set { SetProperty(ref level, value); }
        }


        public void CalculateLevel ()
        {
            int[] levels = new int[7] { 100, 200, 300, 400, 500, 600, 700 };

            if (App.CurrentUser.points == 0 || App.CurrentUser.points < 100)
            {
                App.CurrentUser.level = 0;
            }
            else
            {
                App.CurrentUser.Level = App.CurrentUser.points / 100;
            }
           
        }


        public User()
        {
        }
    }
}
