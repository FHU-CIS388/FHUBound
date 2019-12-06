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
    public partial class AddressPage : ContentPage
    {
        public AddressPage()
        {
            InitializeComponent();
        }
        public async void OnButtonClicked(object sender, EventArgs args)
        {
            var newPage = new AppShell();
            await Navigation.PushAsync(newPage);
        }
    }
}