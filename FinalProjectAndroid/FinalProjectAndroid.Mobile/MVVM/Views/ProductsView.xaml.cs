using FinalProjectAndroid.Mobile.MVVM.ViewModels;

namespace FinalProjectAndroid.Mobile.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel(this.Navigation);
	}
}