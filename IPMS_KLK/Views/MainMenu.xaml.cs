using IPMS_KLK.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
            BindingContext = new MainMenuViewModel();

            #region ***General Worker Animation***
            general_worker_btn.Opacity = 0;
            general_worker_btn.TranslationX = 300;
            general_worker_frame.Opacity = 0;
            general_worker_frame.TranslationX = 300;
            general_worker_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            general_worker_btn.FadeTo(1, 1000);
            general_worker_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            general_worker_frame.FadeTo(1, 1000);
            #endregion

            #region ***Rubber Reception Animation***
            rubber_reception_btn.Opacity = 0;
            rubber_reception_btn.TranslationX = -300;
            rubber_reception_frame.Opacity = 0;
            rubber_reception_frame.TranslationX = -300;
            rubber_reception_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            rubber_reception_btn.FadeTo(1, 1000);
            rubber_reception_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            rubber_reception_frame.FadeTo(1, 1000);
            #endregion

            #region ***FFb Counting Animation***
            ffb_btn.Opacity = 0;
            ffb_btn.TranslationX = -300;
            ffb_frame.Opacity = 0;
            ffb_frame.TranslationX = -300;
            ffb_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            ffb_btn.FadeTo(1, 1000);
            ffb_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            ffb_frame.FadeTo(1, 1000);
            #endregion

            #region ***Task Inspection Animation***
            task_inspection_btn.Opacity = 0;
            task_inspection_btn.TranslationX = 300;
            task_inspection_frame.Opacity = 0;
            task_inspection_frame.TranslationX = 300;
            task_inspection_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            task_inspection_btn.FadeTo(1, 1000);
            task_inspection_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            task_inspection_frame.FadeTo(1, 1000);
            #endregion

            #region ***Receipt Reprint Animation***
            receipt_reprint_btn.Opacity = 0;
            receipt_reprint_btn.TranslationX = 300;
            receipt_reprint_frame.Opacity = 0;
            receipt_reprint_frame.TranslationX = 300;
            receipt_reprint_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            receipt_reprint_btn.FadeTo(1, 1000);
            receipt_reprint_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            receipt_reprint_frame.FadeTo(1, 1000);
            #endregion


            #region ***Others/Changes Animation***
            others_btn.Opacity = 0;
            others_btn.TranslationX = 300;
            others_frame.Opacity = 0;
            others_frame.TranslationX = 300;
            others_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            others_btn.FadeTo(1, 1000);
            others_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            others_frame.FadeTo(1, 1000);
            #endregion



        }
    }
}