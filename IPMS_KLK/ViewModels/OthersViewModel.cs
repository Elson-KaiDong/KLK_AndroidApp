using Xamarin.Forms;
using IPMS_KLK.Views.MainMenuOptions.OthersChangesMenuOptions;
using System.Threading.Tasks;

namespace IPMS_KLK.ViewModels
{
    public class OthersViewModel : BaseViewModel
    {
        public Command NO_ScanLentLaborButtonCommand { get; }

        public OthersViewModel()
        {
            NO_ScanLentLaborButtonCommand = new Command(async ()=> await NO_ScanLentLaborButton_Clicked());
        }

        private async Task NO_ScanLentLaborButton_Clicked()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new OthersChangesScreen2(), false);
        }

    }

}
