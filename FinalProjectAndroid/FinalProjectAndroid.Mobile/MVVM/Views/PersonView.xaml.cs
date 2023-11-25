using FinalProjectAndroid.Mobile.MVVM.ViewModels;

namespace FinalProjectAndroid.Mobile.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}