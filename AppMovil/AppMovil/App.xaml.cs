using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppMovil.Vistas;

namespace AppMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new viewMenu());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
