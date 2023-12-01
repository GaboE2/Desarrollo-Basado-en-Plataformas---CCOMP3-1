using ValorantShop.ViewsModels;

namespace ValorantShop.Views;

public partial class DetalleProducto : ContentPage
{
	public DetalleProducto(DetalleProductoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}