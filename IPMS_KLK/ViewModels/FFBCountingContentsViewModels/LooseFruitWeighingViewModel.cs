using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace IPMS_KLK.ViewModels.FFBCountingContentsViewModels
{
    public class LooseFruitWeighingViewModel : BaseViewModel
    {
        ZXingScannerPage scanPage;

        string _fieldNo;
        string _taskNo;       
        string _collectorID;
        string _harvestingType;


        public Command ContractButtonCommand { get; }
        public Command CheckrollButtonCommand { get; }
        public Command ScanFieldNo_Command { get; }
        public Command ScanTaskNo_Command { get; }
        public Command ScanCollectorID_Command { get; }

        public string FieldNo
        {
            get { return _fieldNo; }

            set
            {
                if (_fieldNo != value)
                    _fieldNo = value;
                OnPropertyChanged(nameof(FieldNo));
            }
        }

        public string TaskNo
        {
            get { return _taskNo; }

            set
            {
                if (_taskNo != value)
                    _taskNo = value;
                OnPropertyChanged(nameof(TaskNo));
            }
        }


        public string CollectorID
        {
            get { return _collectorID; }

            set
            {
                if (_collectorID != value)
                    _collectorID = value;
                OnPropertyChanged(nameof(CollectorID));
            }
        }

        public string HarvestingType
        {
            get { return _harvestingType; }
            set
            {
                if (_harvestingType != value)
                    _harvestingType = value;
                OnPropertyChanged(nameof(HarvestingType));
            }
        }


        public LooseFruitWeighingViewModel()
        {
            ContractButtonCommand = new Command(async () => await ContractButton_Clicked());
            CheckrollButtonCommand = new Command(async () => await CheckrollButton_Clicked());
            ScanFieldNo_Command = new Command(btn_ScanFieldNo_Clicked);
            ScanTaskNo_Command = new Command(btn_ScanTaskNo_Clicked);            
            ScanCollectorID_Command = new Command(btn_ScanCollectorID_Clicked);

        }

        private async Task CheckrollButton_Clicked()
        {
            _harvestingType = "Checkroll";
            checkIsEmptyField(_harvestingType);
        }

        private async Task ContractButton_Clicked()
        {
            _harvestingType = "Contract";
            checkIsEmptyField(_harvestingType);
        }

        private async void checkIsEmptyField(string harvestingType)
        {
            if (string.IsNullOrEmpty(_fieldNo))
                await Application.Current.MainPage.DisplayAlert("", "Please scan or input Field No", "OK");
            else if (!string.IsNullOrEmpty(_fieldNo) && (string.IsNullOrEmpty(_taskNo)))
                await Application.Current.MainPage.DisplayAlert("", "Please scan or input Task No", "OK");
            else if (!string.IsNullOrEmpty(_fieldNo) && (!string.IsNullOrEmpty(_taskNo)) && (string.IsNullOrEmpty(_collectorID)))
                await Application.Current.MainPage.DisplayAlert("", "Please scan or input Collector ID", "OK");
            else
                await Application.Current.MainPage.Navigation.PushModalAsync
                    (new Views.MainMenuOptions.FFBCountingMenuOptions.LooseFruitWeighing_InputScreen2());

        }

        private async void btn_ScanFieldNo_Clicked()
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    FieldNo = result.Text;
                });
            };
            await Application.Current.MainPage.Navigation.PushModalAsync(scanPage);
        }

        private async void btn_ScanTaskNo_Clicked()
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    TaskNo = result.Text;
                });
            };
            await Application.Current.MainPage.Navigation.PushModalAsync(scanPage);
        }

        private async void btn_ScanCollectorID_Clicked()
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    CollectorID = result.Text;
                });
            };
            await Application.Current.MainPage.Navigation.PushModalAsync(scanPage);
        }
    }
}
