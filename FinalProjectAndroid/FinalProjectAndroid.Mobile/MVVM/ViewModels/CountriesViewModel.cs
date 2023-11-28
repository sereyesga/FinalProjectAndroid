using FinalProjectAndroid.Mobile.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalProjectAndroid.Mobile.MVVM.ViewModels
{
    public class CountriesViewModel
    {
        private INavigation _navigation;
        public CountriesViewModel(INavigation navigation) 
        {
            _navigation = navigation;
        }

        public ICommand NewCountryCommand => new Command(async () => await ExecuteNewCountryCommand());

        private async Task ExecuteNewCountryCommand()
        {
            await _navigation.PushAsync(new CountryView());
        }
    }
}
