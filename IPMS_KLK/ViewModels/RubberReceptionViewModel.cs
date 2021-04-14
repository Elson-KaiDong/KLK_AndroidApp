using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IPMS_KLK.ViewModels
{
    public class RubberReceptionViewModel
    {
        public ICommand RubberReception_to_LatexFCCommand { get; }
        public ICommand RubberReception_to_LatexWeighingCommand { get; }
        public ICommand RubberReception_to_FCWeighingCommand { get; }
        public ICommand RubberReception_to_PrintTotalWtCommand { get; }
        public ICommand RubberReception_to_BucketCageWtCommand { get; }
        public ICommand RubberReception_to_RubberReception_MandoreAttendanceCommand { get; }
        public RubberReceptionViewModel()
        {
            RubberReception_to_LatexFCCommand = new Command(async () => await RubberReception_to_LatexFC());
            RubberReception_to_LatexWeighingCommand = new Command(async () => await RubberReception_to_LatexWeighing());
            RubberReception_to_FCWeighingCommand = new Command(async () => await RubberReception_to_FCWeighing());
            RubberReception_to_PrintTotalWtCommand = new Command(async () => await RubberReception_to_PrintTotalWt());
            RubberReception_to_BucketCageWtCommand = new Command(async () => await RubberReception_to_BucketCageWt());
            RubberReception_to_RubberReception_MandoreAttendanceCommand = new Command(async () => await RubberReception_to_RubberReception_MandoreAttendance());
        }

        private async Task RubberReception_to_LatexFC()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.RubberReceptionMenuOptions.LatexFC(),false);
        }

        private async Task RubberReception_to_LatexWeighing()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.RubberReceptionMenuOptions.LatexWeighing(), false);
        }

        private async Task RubberReception_to_FCWeighing()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.RubberReceptionMenuOptions.FCWeighing(), false);
        }

        private async Task RubberReception_to_PrintTotalWt()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.RubberReceptionMenuOptions.PrintTotalWt(), false);
        }

        private async Task RubberReception_to_BucketCageWt()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.RubberReceptionMenuOptions.BucketCageWt(), false);
        }

        private async Task RubberReception_to_RubberReception_MandoreAttendance()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.RubberReceptionMenuOptions.RubberReception_MandoreAttendance(), false);
        }
    }
}
