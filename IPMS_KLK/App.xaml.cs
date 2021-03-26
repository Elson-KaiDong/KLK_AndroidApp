using IPMS_KLK.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("BebasNeue-Regular.otf",Alias = "Bebas")]
[assembly: ExportFont("coolvetica.ttf", Alias = "Cool")]
[assembly: ExportFont("SFUIDisplay-Black.otf", Alias = "sfBlack")]
[assembly: ExportFont("SFUIDisplay-Bold.otf", Alias = "sfBold")]
[assembly: ExportFont("SFUIDisplay-Regular.otf", Alias = "sfRegular")]
[assembly: ExportFont("SFUIDisplay-Thin.otf", Alias = "sfThin")]
[assembly: ExportFont("SFUIDisplay-Light.otf", Alias = "sfLight")]
[assembly: ExportFont("KeepCalm-Medium.ttf", Alias = "keepcalm")]

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
