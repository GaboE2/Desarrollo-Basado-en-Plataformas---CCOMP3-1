using Microsoft.Maui.Controls;

namespace TuApp
{
    public partial class CVPage : ContentPage
    {
        public CVPage(string nombre, string telefono, string correo, string direccion, string experiencia, string formacion, string idiomas, string aptitudes)
        {
            InitializeComponent();

            // Asigna los datos a los controles de la interfaz de usuario
            nombreLabel.Text = nombre;
            puestoLabel.Text = "Puesto deseado"; 
            telefonoLabel.Text = "📞 Teléfono: " + telefono;
            correoLabel.Text = "📧 Correo: " + correo;
            direccionLabel.Text = "📍 Dirección: " + direccion;
            idiomasLabel.Text = "Idiomas: " + idiomas;
            aptitudesLabel.Text = "Aptitudes y Habilidades: " + aptitudes;
        }
    }
}
