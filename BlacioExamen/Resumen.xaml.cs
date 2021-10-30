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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, double total, string usuarioC)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblPagoT.Text = Convert.ToString(total);
            lblUsuarioC.Text = Convert.ToString(usuarioC);
        }
    }
}