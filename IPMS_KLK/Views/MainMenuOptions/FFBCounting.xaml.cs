using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views.MainMenuOptions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FFBCounting : ContentPage
    {
        public FFBCounting()
        {
            InitializeComponent();
        }

        private async void FFBCounting_to_BunchCounting(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BunchCountRecordPage()));
        }
        private async void FFBCounting_to_LooseFruitWeighing(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FFBCountingMenuOptions.LooseFruitWeighing_InputScreen1());
        }
        private async void FFBCounting_to_FFBVerification(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FFBCountingMenuOptions.FFBVerification_InputScreen1());
        }
        private async void FFBCounting_to_AmendVerifiedFFB(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FFBCountingMenuOptions.AmendVerificationFFB_InputScreen1());
        }
        private async void FFBCounting_to_MandoreAttendance(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FFBCountingMenuOptions.MandoreAttendance_InputScreen1());
        }

        private async void FFBCounting_to_Record(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BunchCountRecordPage()));
        }
    }
}