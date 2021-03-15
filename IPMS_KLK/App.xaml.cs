using IPMS_KLK.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
