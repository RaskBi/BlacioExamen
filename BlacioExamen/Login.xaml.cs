using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlacioExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(txtUsuario.Text);
            string contrasena = Convert.ToString(txtContraseña.Text);

            if (usuario == "estudiante2021" && contrasena == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(usuario));
            }
            else
                await DisplayAlert("IInicio de sesion", "Usuario o Contraseña invalida", "OK");
        }
    }
}
