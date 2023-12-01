using ValorantShop.ViewsModels;

namespace ValorantShop.Views;

public partial class CompraExitosaPage : ContentPage
{
	public CompraExitosaPage(CompraExitosaViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}