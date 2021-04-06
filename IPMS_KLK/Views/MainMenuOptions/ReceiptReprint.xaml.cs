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
            uint speed = 600;
            InitializeComponent();

            #region ***Receipt Reprint Animation***
            reprint_btn.Opacity = 0;
            reprint_btn.TranslationX = -300;
            reprint_frame.Opacity = 0;
            reprint_frame.TranslationX = -300;
            reprint_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            reprint_btn.FadeTo(1, speed);
            reprint_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            reprint_frame.FadeTo(1, speed);
            #endregion

            #region ***Receipt Cancel Animation***
            cancel_btn.Opacity = 0;
            cancel_btn.TranslationX = 300;
            cancel_frame.Opacity = 0;
            cancel_frame.TranslationX = 300;
            cancel_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            cancel_btn.FadeTo(1, speed);
            cancel_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            cancel_frame.FadeTo(1, speed);
            #endregion
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