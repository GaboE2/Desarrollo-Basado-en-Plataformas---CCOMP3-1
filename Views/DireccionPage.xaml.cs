using ValorantShop.ViewsModels;

namespace ValorantShop.Views;

public partial class DireccionPage : ContentPage
{
	public DireccionPage(DireccionViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}