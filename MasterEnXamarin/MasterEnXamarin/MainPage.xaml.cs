using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterEnXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnVerMas_Clicked(object sender, EventArgs e)
        {
            string valor = lblTexto.Text;
            //1.- Ocultar botón.
            btnVerMas.IsVisible = false;

            //2.- Mostrar texto.
            lblTexto.LineBreakMode = LineBreakMode.WordWrap;
            //Application.Current.MainPage.DisplayAlert("Oops...", "Algo salió mal", "Ok");
            //DisplayAlert("Oops...", valor, "Ok");
        }
    }
}
