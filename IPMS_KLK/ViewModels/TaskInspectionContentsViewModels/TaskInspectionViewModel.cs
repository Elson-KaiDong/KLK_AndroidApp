using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace IPMS_KLK.ViewModels.TaskInspectionContentsViewModels
{
    public class TaskInspectionViewModel : BaseViewModel
    {
        ZXingScannerPage scanFieldNo_Page;
        string _workerID;
        string _fieldNo;
        string _taskNo;

        public Command NextButtonCommand { get; }
        public Command ScanWorkerIDCommand { get; }
        public Command ScanFieldNoCommand { get; }
        public Command ScanTaskNoCommand { get; }

        public Command ResetCommand { get; }

        public string WorkerID
        {
            get { return _workerID; }
            set
            {
                SetProperty(ref _workerID, value);
                NextButtonCommand.ChangeCanExecute();
            }
        }

        public string FieldNo
        {
            get { return _fieldNo; }
            set
            {
                SetProperty(ref _fieldNo, value);
                NextButtonCommand.ChangeCanExecute();
            }
        }

        public string TaskNo
        {
            get { return _taskNo; }
            set
            {
                SetProperty(ref _taskNo, value);
                NextButtonCommand.ChangeCanExecute();

            }
        }        

        public TaskInspectionViewModel()
        {
            NextButtonCommand = new Command(OnNextClicked);
            ScanWorkerIDCommand = new Command(scanWorkerID_btn_Clicked);
            ScanFieldNoCommand = new Command(scanFieldNo_btn_Clicked);
            ScanTaskNoCommand = new Command(scanTaskNo_btn_Clicked);
            ResetCommand = new Command(reset_btn_Clicked);
        }//Constructor        

        private void reset_btn_Clicked(object obj)
        {
            WorkerID="";
            FieldNo = "";
            TaskNo = "";
        }

        private async void OnNextClicked(object obj)
        {
            if (string.IsNullOrEmpty(_workerID))
            {
                await Application.Current.MainPage.DisplayAlert("", "Please scan or input Worker ID", "OK");
            }

            else if (!string.IsNullOrEmpty(_workerID) && string.IsNullOrEmpty(_fieldNo))
            {
                await Application.Current.MainPage.DisplayAlert("", "Please scan or input Field No", "OK");
            }

            else if (!string.IsNullOrEmpty(_workerID) && !string.IsNullOrEmpty(_fieldNo) && string.IsNullOrEmpty(_taskNo))
            {
                await Application.Current.MainPage.DisplayAlert("", "Please scan or input Task No", "OK");
            }
            else
                await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.TaskInspectionMenuOptions.TaskInspectionScreen2(), false);
        }

        private async void scanWorkerID_btn_Clicked(object sender)
        {
            scanFieldNo_Page = new ZXingScannerPage();
            scanFieldNo_Page.OnScanResult += (result) =>
            {
                scanFieldNo_Page.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    WorkerID = result.Text;
                });
            };
            await Application.Current.MainPage.Navigation.PushModalAsync(scanFieldNo_Page);
        }

        private async void scanFieldNo_btn_Clicked(object sender)
        {
            scanFieldNo_Page = new ZXingScannerPage();
            scanFieldNo_Page.OnScanResult += (result) =>
            {
                scanFieldNo_Page.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    FieldNo = result.Text;
                });
            };
            await Application.Current.MainPage.Navigation.PushModalAsync(scanFieldNo_Page);
        }

        private async void scanTaskNo_btn_Clicked(object sender)
        {
            scanFieldNo_Page = new ZXingScannerPage();
            scanFieldNo_Page.OnScanResult += (result) =>
            {
                scanFieldNo_Page.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    TaskNo = result.Text;
                });
            };
            await Application.Current.MainPage.Navigation.PushModalAsync(scanFieldNo_Page);
        }




    }
}
