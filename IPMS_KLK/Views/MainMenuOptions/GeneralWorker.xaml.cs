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
    public partial class GeneralWorker : ContentPage
    {
        public GeneralWorker()
        {
            InitializeComponent();
            BindingContext = new ViewModels.GeneralWorkerViewModel();

            #region ***Guided By Job Animation***
            guidedByJob_btn.Opacity = 0;
            guidedByJob_btn.TranslationX = -300;
            guidedByJob_frame.Opacity = 0;
            guidedByJob_frame.TranslationX = -300;
            guidedByJob_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            guidedByJob_btn.FadeTo(1, 1000);
            guidedByJob_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            guidedByJob_frame.FadeTo(1, 1000);
            #endregion

            #region ***Guided By Vehicle Animation***
            guidedByVehicle_btn.Opacity = 0;
            guidedByVehicle_btn.TranslationX = -300;
            guidedByVehicle_frame.Opacity = 0;
            guidedByVehicle_frame.TranslationX = -300;
            guidedByVehicle_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            guidedByVehicle_btn.FadeTo(1, 1000);
            guidedByVehicle_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            guidedByVehicle_frame.FadeTo(1, 1000);
            #endregion

            #region ***Add New Job Animation***
            addNewJob_btn.Opacity = 0;
            addNewJob_btn.TranslationX = 300;
            addNewJob_frame.Opacity = 0;
            addNewJob_frame.TranslationX = 300;
            addNewJob_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            addNewJob_btn.FadeTo(1, 1000);
            addNewJob_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            addNewJob_frame.FadeTo(1, 1000);
            #endregion

            #region ***Add New Vehicle Animation***
            addNewVehicle_btn.Opacity = 0;
            addNewVehicle_btn.TranslationX = 300;
            addNewVehicle_frame.Opacity = 0;
            addNewVehicle_frame.TranslationX = 300;
            addNewVehicle_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            addNewVehicle_btn.FadeTo(1, 1000);
            addNewVehicle_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            addNewVehicle_frame.FadeTo(1, 1000);
            #endregion

            #region ***Print Receipt Animation***
            printReceipt_btn.Opacity = 0;
            printReceipt_btn.TranslationX = 300;
            printReceipt_frame.Opacity = 0;
            printReceipt_frame.TranslationX = 300;
            printReceipt_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            printReceipt_btn.FadeTo(1, 1000);
            printReceipt_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            printReceipt_frame.FadeTo(1, 1000);
            #endregion

            #region ***Show Total Emp Animation***
            showTotalEmp_btn.Opacity = 0;
            showTotalEmp_btn.TranslationX = 300;
            showTotalEmp_frame.Opacity = 0;
            showTotalEmp_frame.TranslationX = 300;
            showTotalEmp_btn.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            showTotalEmp_btn.FadeTo(1, 1000);
            showTotalEmp_frame.TranslateTo(0, 0, 1000, Easing.CubicInOut);
            showTotalEmp_frame.FadeTo(1, 1000);
            #endregion



        }
    }
}