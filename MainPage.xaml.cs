using Microsoft.Maui.Controls;
using System;

namespace TuApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCrearCVClicked(object sender, EventArgs e)
        {
            // Recoge los datos del formulario
            string nombre = nombreEntry.Text;
            string telefono = celularEntry.Text;
            string correo = correoEntry.Text;
            string direccion = direccionEntry.Text;
            string experiencia = experienciaEditor.Text;
            string formacion = formacionEditor.Text;
            string idiomas = idiomasEntry.Text;
            string aptitudes = aptitudesEntry.Text;

            // Crea una instancia de CVPage
            var cvPage = new CVPage(nombre, telefono, correo, direccion, experiencia, formacion, idiomas, aptitudes);
            await Navigation.PushAsync(cvPage);
        }

    }
}
