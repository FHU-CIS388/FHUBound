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
    public partial class StreaksPage : ContentPage
    {
        public StreaksPage()
        {
            InitializeComponent();
        }
        async void CloseStreaksPage(object sender, EventArgs e)
        {
            Console.WriteLine("CLOSE STREAKS");
            await Navigation.PopModalAsync(true);
        }
    }
}