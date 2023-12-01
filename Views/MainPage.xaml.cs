using ValorantShop.DataAcess;
using ValorantShop.ViewsModels;

namespace ValorantShop.Views;

public partial class MainPage : ContentPage
{
	int count = 0;
	private readonly ValorantShopDbContext _context;
	public MainPage(ValorantShopDbContext context, MainPageViewModel viewModel)
	{
		_context = context;
		InitializeComponent();
		BindingContext = viewModel;

		//_context.Categorias.Add(new Modelos.Categoria { Descripcion = "test" });
		//_context.SaveChanges();

	}

	
}

