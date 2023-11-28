using FinalProjectAndroid.Mobile.MVVM.ViewModels;

namespace FinalProjectAndroid.Mobile.MVVM.Views;

public partial class CountryView : ContentPage
{
	public CountryView()
	{
		InitializeComponent();
		BindingContext = new CountryViewModel();
	}
}