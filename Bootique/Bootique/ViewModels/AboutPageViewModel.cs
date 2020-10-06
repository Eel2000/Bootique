using Bootique.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bootique.ViewModels
{
    public class AboutPageViewModel
    {
        public INavigation _navigation { get; set; }

        public ICommand AbonnemantCommand { get; }

        public AboutPageViewModel(INavigation navigation)
        {
            _navigation = navigation;

            AbonnemantCommand = new Command(async () => await Go());
        }

        public async Task Go()
        {
            await _navigation.PushModalAsync(new AbonnementPage());
        }
    }
}
