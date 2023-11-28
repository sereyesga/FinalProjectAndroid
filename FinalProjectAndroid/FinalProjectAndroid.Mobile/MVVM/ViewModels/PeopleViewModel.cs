using FinalProjectAndroid.Mobile.MVVM.Models;
using FinalProjectAndroid.Mobile.MVVM.Views;
using System.Windows.Input;

namespace FinalProjectAndroid.Mobile.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        private INavigation _navigation;
        public PeopleViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        public ICommand NewPersonCommand => new Command(async () => await ExecuteNewPersonCommand());

        private async Task ExecuteNewPersonCommand()
        {
            //TitlePage titlePage = new TitlePage()
            //{
            //    Title = "Nueva persona"
            //};

            //await _navigation.PushAsync(new PersonView
            //{
            //    BindingContext = titlePage
            //});
            await _navigation.PushAsync(new PersonView());
        }
    }
}
