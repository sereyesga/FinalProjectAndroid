using FinalProjectAndroid.Mobile.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalProjectAndroid.Mobile.MVVM.ViewModels
{
    public class ProductsViewModel
    {
        private INavigation _navigation;
        public ProductsViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        public ICommand NewPropductCommand => new Command(async () => await ExecuteNewPropductCommand());

        private async Task ExecuteNewPropductCommand()
        {
            await _navigation.PushAsync(new ProductView());
        }
    }
}
