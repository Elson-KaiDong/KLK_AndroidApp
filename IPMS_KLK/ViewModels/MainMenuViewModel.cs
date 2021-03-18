using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IPMS_KLK.ViewModels
{
    public class MainMenuViewModel
    {

        public ICommand MainMenu_to_GeneralWorkerCommand { get; }
        public ICommand MainMenu_to_RubberReceptionCommand { get; }
        public ICommand MainMenu_to_FFBCountingCommand { get; }
        public ICommand MainMenu_to_TaskInspectionrCommand { get; }
        public ICommand MainMenu_to_ReceiptReprintCommand { get; }

        public ICommand MainMenu_to_OthersChangesCommand { get; }
        public MainMenuViewModel()
        {
            MainMenu_to_GeneralWorkerCommand = new Command(async () =>  await MainMenu_to_GeneralWorker());
            MainMenu_to_RubberReceptionCommand = new Command(async () => await MainMenu_to_RubberReception());
            MainMenu_to_FFBCountingCommand = new Command(async () => await MainMenu_to_FFBCounting());
            MainMenu_to_TaskInspectionrCommand = new Command(async () => await MainMenu_to_TaskInspection());
            MainMenu_to_ReceiptReprintCommand = new Command(async () => await MainMenu_to_ReceiptReprint());
            MainMenu_to_OthersChangesCommand = new Command(async () => await MainMenu_to_OthersChanges());
        }       

        private async Task MainMenu_to_GeneralWorker()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.GeneralWorker());
        }

        private async Task MainMenu_to_RubberReception()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.RubberReception());
        }

        private async Task MainMenu_to_FFBCounting()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.FFBCounting());
        }

        private async Task MainMenu_to_TaskInspection()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.TaskInspection());
        }

        private async Task MainMenu_to_ReceiptReprint()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.ReceiptReprint());
        }

        private async Task MainMenu_to_OthersChanges()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.OthersChanges());
        }
    }
}
