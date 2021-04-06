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
    public partial class FFBCounting : ContentPage
    {
        public FFBCounting()
        {
            uint speed = 600;
            InitializeComponent();
            BindingContext = new ViewModels.FFBCountingContentsViewModels.FFBCountingViewModel();

            #region ***Bunch Counting Animation***
            bunchCounting_btn.Opacity = 0;
            bunchCounting_btn.TranslationX = -300;
            bunchCounting_frame.Opacity = 0;
            bunchCounting_frame.TranslationX = -300;
            bunchCounting_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            bunchCounting_btn.FadeTo(1, speed);
            bunchCounting_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            bunchCounting_frame.FadeTo(1, speed);
            #endregion

            #region ***Loose Fruit Weighing Animation***
            looseFruit_btn.Opacity = 0;
            looseFruit_btn.TranslationX = -300;
            looseFruit_frame.Opacity = 0;
            looseFruit_frame.TranslationX = -300;
            looseFruit_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            looseFruit_btn.FadeTo(1, speed);
            looseFruit_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            looseFruit_frame.FadeTo(1, speed);
            #endregion

            #region ***FFB Verification Animation***
            ffbVerification_btn.Opacity = 0;
            ffbVerification_btn.TranslationX = 300;
            ffbVerification_frame.Opacity = 0;
            ffbVerification_frame.TranslationX = 300;
            ffbVerification_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            ffbVerification_btn.FadeTo(1, speed);
            ffbVerification_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            ffbVerification_frame.FadeTo(1, speed);
            #endregion

            #region ***Amend Verification Animation***
            amendVerified_btn.Opacity = 0;
            amendVerified_btn.TranslationX = 300;
            amendVerified_frame.Opacity = 0;
            amendVerified_frame.TranslationX = 300;
            amendVerified_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            amendVerified_btn.FadeTo(1, speed);
            amendVerified_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            amendVerified_frame.FadeTo(1, speed);
            #endregion

            #region ***Mandore Attendance Animation***
            mandoreAttendance_btn.Opacity = 0;
            mandoreAttendance_btn.TranslationX = 300;
            mandoreAttendance_frame.Opacity = 0;
            mandoreAttendance_frame.TranslationX = 300;
            mandoreAttendance_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            mandoreAttendance_btn.FadeTo(1, speed);
            mandoreAttendance_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            mandoreAttendance_frame.FadeTo(1, speed);
            #endregion

           
        }

    }
}