using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System.Text;
using ZXing.Net.Mobile.Forms;
using System;

namespace IPMS_KLK.ViewModels.RubberReceptionContentsViewModels
{
    public class LatexFC_ViewModel :BaseViewModel
    {
        ZXingScannerPage scanFieldNo_Page;
        string _workerID;
        string _fieldNo;
        string _taskNo;

        public Command NextButtonCommand { get; }
        public Command ScanWorkerIDCommand { get; }
        public Command ScanFieldNoCommand { get; }
        public Command ScanTaskNoCommand { get; }

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

        private LatexFC_TappingType _selectedTappingType { get; set; }
        public LatexFC_TappingType SelectedTappingType
        {
            get => _selectedTappingType;
            set
            {
                if (_selectedTappingType != value)                
                {
                    _selectedTappingType = value;
                    OnPropertyChanged();
                    OnPropertyChanged("IsMethodPickerEnabled");                   
                }
            }
        }

        private bool _isMethodPickerEnabled { get; set; }
        public bool IsMethodPickerEnabled
        {
            get { return _isMethodPickerEnabled; }

            set
            {
                if(_isMethodPickerEnabled!=value)
                {
                    if (_selectedTappingType == tappingTypeList[3])
                        _isMethodPickerEnabled = true;
                    else
                        _isMethodPickerEnabled = false;

                }
            }
        }

        
        public List<LatexFC_TappingType> tappingTypeList { get; set; }
        public List<LatexFC_Method> methodList { get; set; }
         

        public LatexFC_ViewModel() //Constructor
        {
            tappingTypeList = GetTappingTypes().OrderBy(t => t.TappingType).ToList();
            methodList = GetMethod().OrderBy(t => t.TappingMethod).ToList();
            NextButtonCommand = new Command(OnNextClicked, NextButtonAllowed);
            ScanWorkerIDCommand = new Command(scanWorkerID_btn_Clicked);
            ScanFieldNoCommand = new Command(scanFieldNo_btn_Clicked);
            ScanTaskNoCommand = new Command(scanTaskNo_btn_Clicked);
        }

        public bool NextButtonAllowed(object obj) => !string.IsNullOrEmpty(_workerID)
            && !string.IsNullOrEmpty(_fieldNo) && !string.IsNullOrEmpty(_taskNo);

        private async void OnNextClicked(object obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Views.MainMenuOptions.RubberReceptionMenuOptions.LatexFC2());
        }


        #region **List Of Tapping Types and Methods
        public List<LatexFC_TappingType> GetTappingTypes()
        {
            var _tappingType = new List<LatexFC_TappingType>()
            {
                new LatexFC_TappingType(){TypeKey=1, TappingType="Normal"},
                new LatexFC_TappingType(){TypeKey=2, TappingType="Evening Collection"},
                new LatexFC_TappingType(){TypeKey=3, TappingType="Late Tapping"},
                new LatexFC_TappingType(){TypeKey=4, TappingType="Recovery"},
                new LatexFC_TappingType(){TypeKey=5, TappingType="Washout"},
            };
            return _tappingType;
        } 

        public List<LatexFC_Method> GetMethod()
        {
            var _method = new List<LatexFC_Method>()
            {
                new LatexFC_Method(){MethodKey=1, TappingMethod="Normal + 2nd Task"},
                new LatexFC_Method(){MethodKey=2, TappingMethod="2nd Task Only"},                
            };
            return _method;
        }
        
    }

    public class LatexFC_TappingType
    {
        public int TypeKey { get; set; }
        public string TappingType { get; set; }
    }//Define tapping type

    public class LatexFC_Method
    {
        public int MethodKey { get; set; }
        public string TappingMethod { get; set; }
    }
    #endregion
}
