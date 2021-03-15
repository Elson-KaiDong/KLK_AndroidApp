using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views.MainMenuOptions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceiptReprint : ContentPage
    {
        public ReceiptReprint()
        {
            InitializeComponent();
        }

        private async void ReceiptReprint_to_ReceiptReprint(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ReceiptReprintMenuOptions.ReceiptReprint_InputScreen());
        }
        private async void ReceiptReprint_to_ReceiptCancel(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ReceiptReprintMenuOptions.ReceiptCancel_InputScreen());
        }


    }

   
}