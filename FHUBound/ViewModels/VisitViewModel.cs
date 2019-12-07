using FHUBound.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.ViewModels
{
    class VisitViewModel :BaseViewModel
    {

        VisitViewModel viewModel;

        public User User { get; set; }

        public VisitViewModel()
        {
            User = App.CurrentUser;
        }


    }
}
