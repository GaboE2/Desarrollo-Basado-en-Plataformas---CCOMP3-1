using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ValorantShop.DataAcess;


namespace ValorantShop.ViewsModels
{
    public partial class DireccionViewModel : ObservableObject
    {
        private readonly ValorantShopDbContext _context;

        [ObservableProperty]
        public string nombreDireccion;
        [ObservableProperty]
        public string nombreCompleto;
        [ObservableProperty]
        public string calle;
        [ObservableProperty]
        public string telefono;
        [ObservableProperty]
        public string estado;
        [ObservableProperty]
        public string ciudad;
        [RelayCommand]
        async Task GuardarEvent()
        {

            if (string.IsNullOrEmpty(NombreDireccion) ||
               string.IsNullOrEmpty(NombreCompleto) ||
               string.IsNullOrEmpty(Calle) ||
               string.IsNullOrEmpty(Telefono) ||
               string.IsNullOrEmpty(Estado) ||
               string.IsNullOrEmpty(Ciudad)
               )
            {
                await Shell.Current.DisplayAlert("Mensaje", "Debe ingresar todos los campos", "Aceptar");
                return;
            }
            _context.Direcciones.Add(new ValorantShop.Modelos.Direccion { 
                NombreDireccion = NombreDireccion,
                NombreCompleto = NombreCompleto,
                Calle = Calle,
                Telefono = Telefono,
                Estado = Estado,
                Ciudad  = Ciudad
            });
           
           await  _context.SaveChangesAsync();
           await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        public async Task GetBackEvent()
        {
            await Shell.Current.GoToAsync("..");
        }
        public DireccionViewModel(ValorantShopDbContext context)
        {
            _context = context;
        }
    }
}
