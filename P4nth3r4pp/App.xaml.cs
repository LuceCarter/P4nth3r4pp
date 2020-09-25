using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using P4nth3r4pp.Views;

[assembly: ExportFont("WorkSans.ttf") ]
namespace P4nth3r4pp
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Shapes_Experimental" });
            InitializeComponent();

            MainPage = new HomePage();
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
