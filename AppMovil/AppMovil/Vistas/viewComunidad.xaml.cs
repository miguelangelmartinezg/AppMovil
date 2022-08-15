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
    public partial class viewComunidad : ContentPage
    {
        public viewComunidad()
        {
            InitializeComponent();
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}