using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovil.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewMenu : ContentPage
    {
        public viewMenu()
        {
            InitializeComponent();
        }

        private void btnDeportes_Clicked(object sender, EventArgs e)
        {
           
        }

        private void btnHobbie_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new viewHobbie());
        }

        private void btnComunidad_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new viewComunidad());
        }

        private void btnAgenda_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new viewAgenda());
        }
    }
}