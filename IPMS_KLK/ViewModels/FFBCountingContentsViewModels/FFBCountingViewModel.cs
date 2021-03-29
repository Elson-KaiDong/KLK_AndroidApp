using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IPMS_KLK.ViewModels.FFBCountingContentsViewModels
{
    public class FFBCountingViewModel
    {
        public ICommand FFBCounting_to_BunchCountingCommand { get; }
        public ICommand FFBCounting_to_LooseFruitWeighingCommand { get; }
        public ICommand FFBCounting_to_FFBVerificationCommand { get; }
        public ICommand FFBCounting_to_AmendVerifiedFFBCommand { get; }
        public ICommand FFBCounting_to_MandoreAttendanceCommand { get; }
      
        public FFBCountingViewModel()
        {
            FFBCounting_to_BunchCountingCommand = new Command(async () => await FFBCounting_to_BunchCounting());
            FFBCounting_to_LooseFruitWeighingCommand = new Command(async () => await FFBCounting_to_LooseFruitWeighing());
            FFBCounting_to_FFBVerificationCommand = new Command(async () => await FFBCounting_to_FFBVerification());
            FFBCounting_to_AmendVerifiedFFBCommand = new Command(async () => await FFBCounting_to_AmendVerifiedFFB());
            FFBCounting_to_MandoreAttendanceCommand = new Command(async () => await FFBCounting_to_MandoreAttendance());
           
        }

        private async Task FFBCounting_to_BunchCounting()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.FFBCountingMenuOptions.BunchCounting_InputScreen1());
        }

        private async Task FFBCounting_to_LooseFruitWeighing()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.FFBCountingMenuOptions.LooseFruitWeighing_InputScreen1());
        }

        private async Task FFBCounting_to_FFBVerification()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.FFBCountingMenuOptions.FFBVerification_InputScreen1());
        }

        private async Task FFBCounting_to_AmendVerifiedFFB()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.FFBCountingMenuOptions.AmendVerificationFFB_InputScreen1());
        }

        private async Task FFBCounting_to_MandoreAttendance()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.FFBCountingMenuOptions.MandoreAttendance_InputScreen1());
        }

       
    }
}
