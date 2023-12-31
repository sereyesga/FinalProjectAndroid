using FinalProjectAndroid.Mobile.MVVM.ViewModels;

namespace FinalProjectAndroid.Mobile.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		BindingContext = new PeopleViewModel(this.Navigation);
	}
}