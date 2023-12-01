using ValorantShop.ViewsModels;

namespace ValorantShop.Views;

public partial class ProductoCategoriaPage : ContentPage
{
	public ProductoCategoriaPage(ProductoCategoriaViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}