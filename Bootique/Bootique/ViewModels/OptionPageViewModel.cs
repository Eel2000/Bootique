using Bootique.Views;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bootique.ViewModels
{
    public class OptionPageViewModel
    {
        public INavigation _navigation { get; set; }

        public ICommand BackCommand { get; }
        public ICommand ValiderCommand { get; }

        public OptionPageViewModel(INavigation navigation)
        {
            _navigation = navigation;

            BackCommand = new Command(async () => await BackTo());
            ValiderCommand = new Command(async () => await Valider());
        }

        public async Task BackTo()
        {
            await _navigation.PopModalAsync();
        }

        public async Task Valider()
        {
            await PopupNavigation.PushAsync(new PopupSendPage(),true);
            await Task.Delay(5000);
            await PopupNavigation.PopAsync(true);

            await _navigation.PushModalAsync(new AbonnementPage());
        }
    }
}
