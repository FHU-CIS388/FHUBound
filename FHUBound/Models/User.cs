using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    public class User
    {
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TotalPoints { get; set; }

        public int Points { get; set; }

        public int Level { get; set; }

        public void CalculateLevel ()
        {

            if (App.CurrentUser.TotalPoints >= 100 && App.CurrentUser.TotalPoints <200)
            {
                App.CurrentUser.Level = 1;
            }
            else if (App.CurrentUser.TotalPoints >= 200 && App.CurrentUser.TotalPoints < 300)
            {
                App.CurrentUser.Level = 2;
            }
            else if (App.CurrentUser.TotalPoints >= 300 && App.CurrentUser.TotalPoints < 400)
            {
                App.CurrentUser.Level = 3;
            }
            else if (App.CurrentUser.TotalPoints >= 400)
            {
                App.CurrentUser.Level = 4;
            }
        }


        public User()
        {
        }
    }
}
