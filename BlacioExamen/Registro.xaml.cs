using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlacioExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuarioC.Text = usuario;
            usuarioC = usuario;
        }
        string usuarioC;
        string nombre = null;
        double total=0;

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double pagoI = Convert.ToDouble(txtMontoI.Text);
            double costo = 1800;
            double porcentaje;
            double diferencia;
            double mensualSin;
            double mensualCon;
            

            if (pagoI > 0 || pagoI < 1800)
            {
                diferencia = costo - pagoI;
                porcentaje = costo * 0.05;
                mensualSin = diferencia / 3;
                mensualCon = mensualSin + porcentaje;
                total = mensualCon * 3;
                txtPagoM.Text = Convert.ToString(Math.Round(mensualCon));
            }
            else
                DisplayAlert("Advertencia", "El Monto inicial debe ser menor que 1800, minimo 1", "Ok");

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            nombre = Convert.ToString(txtNombre.Text);
            await DisplayAlert("Guardado", "Elemento guardado con exito", "OK");

            await Navigation.PushAsync(new Resumen(nombre, total, usuarioC));
        }
    }
}