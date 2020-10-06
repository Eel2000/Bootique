using Bootique.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bootique.ViewModels
{
    class MainPageViewModel 
    {
        public INavigation _navigation { get; set; }

        public ICommand AboutPageCommand { get; }
        public ICommand OptionPageCommand { get; }
        public ICommand AlertCommand { get; }

        public MainPageViewModel(INavigation navigation)
        {
            _navigation = navigation;

            AboutPageCommand = new Command(async () => await NavigateToAboutPage());
            OptionPageCommand = new Command(async () => await GoToOptionPage());
            AlertCommand = new Command(async () => await SendAlert());
        }


        public async Task NavigateToAboutPage()
        {
            await _navigation.PushModalAsync(new AboutPage());
        }

        public async Task GoToOptionPage()
        {
            await _navigation.PushModalAsync(new OptionPage());
        }

        public async Task SendAlert()
        {
            await PopupNavigation.PushAsync(new PopUpPage(), true);
            await Task.Delay(3000);
            await PopupNavigation.PopAsync(true);
        }
    }
}
