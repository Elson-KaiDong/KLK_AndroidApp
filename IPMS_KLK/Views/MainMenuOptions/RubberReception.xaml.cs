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
    public partial class RubberReception : ContentPage
    {
        public RubberReception()
        {
            uint speed = 600;
            InitializeComponent();
            BindingContext = new ViewModels.RubberReceptionViewModel();

            #region ***Latex FC Animation***
            latex_fc_btn.Opacity = 0;
            latex_fc_btn.TranslationX = -300;
            latex_fc_frame.Opacity = 0;
            latex_fc_frame.TranslationX = -300;
            latex_fc_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            latex_fc_btn.FadeTo(1, speed);
            latex_fc_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            latex_fc_frame.FadeTo(1, speed);
            #endregion

            #region ***Latex Weighing Animation***
            latex_weighing_btn.Opacity = 0;
            latex_weighing_btn.TranslationX = -300;
            latex_weighing_frame.Opacity = 0;
            latex_weighing_frame.TranslationX = -300;
            latex_weighing_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            latex_weighing_btn.FadeTo(1, speed);
            latex_weighing_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            latex_weighing_frame.FadeTo(1, speed);
            #endregion

            #region ***FC Weighing Animation***
            fc_weighing_btn.Opacity = 0;
            fc_weighing_btn.TranslationX = 300;
            fc_weighing_frame.Opacity = 0;
            fc_weighing_frame.TranslationX = 300;
            fc_weighing_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            fc_weighing_btn.FadeTo(1, speed);
            fc_weighing_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            fc_weighing_frame.FadeTo(1, speed);
            #endregion

            #region ***Bucket/Cage Wt Animation***
            bucket_btn.Opacity = 0;
            bucket_btn.TranslationX = 300;
            bucket_frame.Opacity = 0;
            bucket_frame.TranslationX = 300;
            bucket_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            bucket_btn.FadeTo(1, speed);
            bucket_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            bucket_frame.FadeTo(1, speed);
            #endregion

            #region ***Print Total Wt Animation***
            printTotal_btn.Opacity = 0;
            printTotal_btn.TranslationX = 300;
            printTotal_frame.Opacity = 0;
            printTotal_frame.TranslationX = 300;
            printTotal_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            printTotal_btn.FadeTo(1, speed);
            printTotal_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            printTotal_frame.FadeTo(1, speed);
            #endregion

            #region ***Show Total Emp Animation***
            mandore_btn.Opacity = 0;
            mandore_btn.TranslationX = 300;
            mandore_frame.Opacity = 0;
            mandore_frame.TranslationX = 300;
            mandore_btn.TranslateTo(0, 0, speed, Easing.CubicInOut);
            mandore_btn.FadeTo(1, speed);
            mandore_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            mandore_frame.FadeTo(1, speed);
            #endregion
        }
    }
}