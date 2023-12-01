using ValorantShop.ViewsModels;

namespace ValorantShop.Views;

public partial class TarjetaPage : ContentPage
{
	public TarjetaPage(TarjetaViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}