using FHUBound.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FHUBound.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CookieClickerPage : ContentPage
    {
        CookieViewModel viewModel;

        public CookieClickerPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CookieViewModel(stacheButton, AnimationView, CookieAnimation);
        }

        private void stacheButton_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}