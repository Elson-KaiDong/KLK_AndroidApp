using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace IPMS_KLK.ViewModels.FFBCountingContentsViewModels
{
    public class BunchCountingViewModel : BaseViewModel
    {
        ZXingScannerPage scanPage;

        string _fieldNo;
        string _taskNo;
        string _cutterID;
        string _carrierID;
        string _harvestingType;

        public Command ContractButtonCommand {get;}
        public Command CheckrollButtonCommand { get; }
        public Command ScanFieldNo_Command { get; }
        public Command ScanTaskNo_Command { get; }
        public Command ScanCutterID_Command { get; }
        public Command ScanCarrierID_Command { get; }

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

        public string CutterID
        {
            get { return _cutterID; }

            set
            {
                if (_cutterID != value)
                    _cutterID = value;
                OnPropertyChanged(nameof(CutterID));
            }
        }

        public string CarrierID
        {
            get { return _carrierID; }

            set
            {
                if (_carrierID != value)
                    _carrierID = value;
                OnPropertyChanged(nameof(CarrierID));
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

        public BunchCountingViewModel()
        {
            ContractButtonCommand = new Command(async()=>await ContractButton_Clicked());
            CheckrollButtonCommand = new Command(async ()=>await CheckrollButton_Clicked());
            ScanFieldNo_Command = new Command(btn_ScanFieldNo_Clicked);
            ScanTaskNo_Command = new Command(btn_ScanTaskNo_Clicked);
            ScanCutterID_Command = new Command(btn_ScanCutterID_Clicked);
            ScanCarrierID_Command = new Command(btn_ScanCarrierID_Clicked);

        }//Constructor

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
            else if (!string.IsNullOrEmpty(_fieldNo) && (!string.IsNullOrEmpty(_taskNo)) && (string.IsNullOrEmpty(_cutterID)))
                await Application.Current.MainPage.DisplayAlert("", "Please scan or input Cutter ID", "OK");
            else if (!string.IsNullOrEmpty(_fieldNo) && (!string.IsNullOrEmpty(_taskNo)) && (!string.IsNullOrEmpty(_cutterID)) && (string.IsNullOrEmpty(_carrierID)))
                await Application.Current.MainPage.DisplayAlert("", "Please scan or input Carrier ID", "OK");
            else
                await Application.Current.MainPage.Navigation.PushModalAsync
                    (new Views.MainMenuOptions.FFBCountingMenuOptions.BunchCounting_InputScreen2
                    (_fieldNo,_taskNo,_cutterID,_carrierID,harvestingType));

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

        private async void btn_ScanCutterID_Clicked()
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    CutterID = result.Text;
                });
            };
            await Application.Current.MainPage.Navigation.PushModalAsync(scanPage);
        }

        private async void btn_ScanCarrierID_Clicked()
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    CarrierID = result.Text;
                });
            };
            await Application.Current.MainPage.Navigation.PushModalAsync(scanPage);
        }
    }
}
