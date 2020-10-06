using Bootique.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bootique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OptionPage : ContentPage
    {
        public OptionPage()
        {
            InitializeComponent();
            BindingContext = new OptionPageViewModel(Navigation);
        }
    }
}