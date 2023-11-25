using FinalProjectAndroid.Mobile.MVVM.Views;

namespace FinalProjectAndroid.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TabbedView());
        }
    }
}