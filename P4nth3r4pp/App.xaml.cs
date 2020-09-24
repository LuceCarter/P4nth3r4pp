using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using P4nth3r4pp.Views;

namespace P4nth3r4pp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
