using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomTabbedPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Modulos.Home.HomePage();
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
