using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private async void MainMenu_to_GeneralWorker(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuOptions.GeneralWorker());
        }
        private async void MainMenu_to_RubberReception(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuOptions.RubberReception());
        }
        private async void MainMenu_to_FFBCounting(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuOptions.FFBCounting());
        }
        private async void MainMenu_to_TaskInspection(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuOptions.TaskInspection());
        }
        private async void MainMenu_to_ReceiptReprint(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuOptions.ReceiptReprint());
        }
        private async void MainMenu_to_OthersChanges(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuOptions.OthersChanges());
        }


    }
}