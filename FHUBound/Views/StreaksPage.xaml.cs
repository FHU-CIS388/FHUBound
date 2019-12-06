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
    public partial class StreaksPage : ContentPage
    {
        StreaksViewModel viewModel;
        public StreaksPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new StreaksViewModel();
            viewModel.Navigation = Navigation;
        }     
    }
}