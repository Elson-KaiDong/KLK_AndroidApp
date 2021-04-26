using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IPMS_KLK.ViewModels
{
    public class GeneralWorkerViewModel
    {
        public ICommand GeneralWorker_to_GuidedByJobCommand { get; }
        public ICommand GeneralWorker_to_GuidedByVehicleCommand { get; }
        public ICommand GeneralWorker_to_AddNewJobCommand { get; }
        public ICommand GeneralWorker_to_AddNewVechicleCommand { get; }
        public ICommand GeneralWorker_to_PrintReceiptCommand { get; }
        public ICommand GeneralWorker_to_ShowTotalEmpCommand { get; }

        public GeneralWorkerViewModel()
        {
            GeneralWorker_to_GuidedByJobCommand = new Command(async () => await GeneralWorker_to_GuidedByJob());
            GeneralWorker_to_GuidedByVehicleCommand = new Command(async () => await GeneralWorker_to_GuidedByVehicle());
            GeneralWorker_to_AddNewJobCommand = new Command(async () => await GeneralWorker_to_AddNewJob());
            GeneralWorker_to_AddNewVechicleCommand = new Command(async () => await GeneralWorker_to_AddNewVechicle());
            GeneralWorker_to_PrintReceiptCommand = new Command(async () => await GeneralWorker_to_PrintReceipt());
            GeneralWorker_to_ShowTotalEmpCommand = new Command(async () => await GeneralWorker_to_ShowTotalEmp());
        }

        private async Task GeneralWorker_to_GuidedByJob()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.GeneralWorkerMenuOptions.GuidedByJob(),false);
        }

        private async Task GeneralWorker_to_GuidedByVehicle()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.GeneralWorkerMenuOptions.GuidedByVehicle(),false);
        }

        private async Task GeneralWorker_to_AddNewJob()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.GeneralWorkerMenuOptions.AddNewJob(),false);
        }

        private async Task GeneralWorker_to_AddNewVechicle()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.GeneralWorkerMenuOptions.AddNewVehicle(),false);
        }

        private async Task GeneralWorker_to_PrintReceipt()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.GeneralWorkerMenuOptions.PrintReceipt(),false);
        }

        private async Task GeneralWorker_to_ShowTotalEmp()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.GeneralWorkerMenuOptions.ShowTotalEmp());
        }


    }   
}
