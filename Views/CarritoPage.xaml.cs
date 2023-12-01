using ValorantShop.DataAcess;
using ValorantShop.ViewsModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace ValorantShop.Views;

public partial class CarritoPage : ContentPage
{
	private CarritoViewModel _viewModel;
	private readonly ValorantShopDbContext _context;
	public CarritoPage(CarritoViewModel viewModel, ValorantShopDbContext contex)
	{
		InitializeComponent();
        _context = contex;
		BindingContext = viewModel;
		_viewModel = viewModel;
	}

    protected override async void OnAppearing()
    {
		await _viewModel.ObtenerProductos();
        _viewModel.MostarTotal();
    }




}