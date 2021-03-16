using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace IPMS_KLK.Views.MainMenuOptions.FFBCountingMenuOptions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BunchCounting_InputScreen1 : ContentPage
    {
        ZXingScannerPage scanFieldNo_Page;       
        
        public BunchCounting_InputScreen1()
        {
            InitializeComponent();
            
            btn_ScanFieldNo.Clicked += Btn_ScanFieldNo_Clicked;
            btn_ScanTaskNo.Clicked += Btn_ScanTaskNo_Clicked;
            btn_ScanCutterID.Clicked += Btn_ScanCutterID_Clicked;
            btn_ScanCarrierID.Clicked += Btn_ScanCarrierID_Clicked;
            btn_BunchCounting_pg1_Contract.Clicked += Btn_BunchCounting_pg1_Contract_Clicked;
            btn_BunchCounting_pg1_Checkroll.Clicked += Btn_BunchCounting_pg1_Checkroll_Clicked;           
        }

        private async void Btn_ScanTaskNo_Clicked(object sender, EventArgs e)
        {
            scanFieldNo_Page = new ZXingScannerPage();
            scanFieldNo_Page.OnScanResult += (result) =>
            {
                scanFieldNo_Page.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopModalAsync();
                    bunchCounting_pg1_FieldNo_Entry.Text = result.Text;
                });
            };
            await Navigation.PushModalAsync(scanFieldNo_Page);
        }

        private async void Btn_BunchCounting_pg1_Checkroll_Clicked(object sender, EventArgs e)
        {           
            string type = "Checkroll";

            string fn = bunchCounting_pg1_FieldNo_Entry.Text;
            string tn = bunchCounting_pg1_TaskNo_Entry.Text;
            string cut= bunchCounting_pg1_CutterID_Entry.Text;
            string car= bunchCounting_pg1_CarrierID_Entry.Text;                         
            
                if (fn==null)
                {
                    await DisplayAlert("", "Field No is required", "OK");
                }
                else if (fn!=null && tn==null)
                {
                    await DisplayAlert("", "Task No is required", "OK");
                }
                else if(fn!=null && tn!=null && cut==null)
                {
                    await DisplayAlert("", "Cutter ID is required", "OK");
                }
                else if (fn != null && tn != null && cut != null && car==null)
                {
                    await DisplayAlert("", "Carrier ID is required", "OK");
                }
                else if(fn != null && tn != null && cut != null && car != null && type!=null)
                {
                    try
                    {
                    BunchCounting_InputScreen2 bunchCounting_InputScreen2 = new BunchCounting_InputScreen2(fn,tn,cut,car,type);
                    
                    await Navigation.PushModalAsync(bunchCounting_InputScreen2);
                   
                   }
                catch (Exception ex)
                    {
                    await DisplayAlert(null, ex.Message + type, "OK");
                    
                    }
                }           
            
        }

        private async void Btn_BunchCounting_pg1_Contract_Clicked(object sender, EventArgs e)
        {
            string type = "Checkroll";

            string fn = bunchCounting_pg1_FieldNo_Entry.Text;
            string tn = bunchCounting_pg1_TaskNo_Entry.Text;
            string cut = bunchCounting_pg1_CutterID_Entry.Text;
            string car = bunchCounting_pg1_CarrierID_Entry.Text;

            if (fn == null)
            {
                await DisplayAlert("", "Field No is required", "OK");
            }
            else if (fn != null && tn == null)
            {
                await DisplayAlert("", "Task No is required", "OK");
            }
            else if (fn != null && tn != null && cut == null)
            {
                await DisplayAlert("", "Cutter ID is required", "OK");
            }
            else if (fn != null && tn != null && cut != null && car == null)
            {
                await DisplayAlert("", "Carrier ID is required", "OK");
            }
            else if (fn != null && tn != null && cut != null && car != null && type != null)
            {
                try
                {
                    BunchCounting_InputScreen2 bunchCounting_InputScreen2 = new BunchCounting_InputScreen2(fn, tn, cut, car, type);

                    await Navigation.PushModalAsync(bunchCounting_InputScreen2);

                }
                catch (Exception ex)
                {
                    await DisplayAlert(null, ex.Message + type, "OK");

                }
            }
        }

        

        private async void Btn_ScanFieldNo_Clicked(object sender, EventArgs e)
        {
            scanFieldNo_Page = new ZXingScannerPage();
            scanFieldNo_Page.OnScanResult += (result) =>
            {
                scanFieldNo_Page.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopModalAsync();
                    bunchCounting_pg1_FieldNo_Entry.Text = result.Text;
                });
            };
            await Navigation.PushModalAsync(scanFieldNo_Page);
        }

        private async void Btn_ScanCutterID_Clicked(object sender, EventArgs e)
        {
            scanFieldNo_Page = new ZXingScannerPage();
            scanFieldNo_Page.OnScanResult += (result) =>
            {
                scanFieldNo_Page.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopModalAsync();
                    bunchCounting_pg1_CutterID_Entry.Text = result.Text;
                });
            };
            await Navigation.PushModalAsync(scanFieldNo_Page);
        }

        private async void Btn_ScanCarrierID_Clicked(object sender, EventArgs e)
        {
            scanFieldNo_Page = new ZXingScannerPage();
            scanFieldNo_Page.OnScanResult += (result) =>
            {
                scanFieldNo_Page.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopModalAsync();
                    bunchCounting_pg1_CarrierID_Entry.Text = result.Text;
                });
            };
            await Navigation.PushModalAsync(scanFieldNo_Page);
        }

            
               
    }
}