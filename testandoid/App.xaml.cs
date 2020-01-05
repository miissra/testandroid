using System;
using testandoid.Control.Common;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testandoid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new navbar();
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
