using FinalProjectAndroid.Mobile.MVVM.ViewModels;

namespace FinalProjectAndroid.Mobile.MVVM.Views;

public partial class CountriesView : ContentPage
{
	public CountriesView()
	{
		InitializeComponent();
		BindingContext = new CountriesViewModel(this.Navigation);
	}
}