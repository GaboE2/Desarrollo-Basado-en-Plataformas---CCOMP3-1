using ValorantShop.ViewsModels;

namespace ValorantShop.Views;

public partial class PerfilPage : ContentPage
{
	public PerfilPage(PerfilViewModel viewModel)
    {
        InitializeComponent();
		BindingContext =viewModel;
	}
}