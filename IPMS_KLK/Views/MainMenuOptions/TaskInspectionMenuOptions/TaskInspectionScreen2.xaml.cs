using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views.MainMenuOptions.TaskInspectionMenuOptions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskInspectionScreen2 : ContentPage
    {
        public TaskInspectionScreen2()
        {
            InitializeComponent();
            uint speed = 750;

            unharvested_frame.TranslationX = 300;
            unharvested_frame.Opacity = 0;
            unharvested_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            unharvested_frame.FadeTo(1, speed);

            harvested_frame.TranslationX = 600;
            harvested_frame.Opacity = 0;
            harvested_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            harvested_frame.FadeTo(1, speed);

            harvested_defective_frame.TranslationX = 900;
            harvested_defective_frame.Opacity = 0;
            harvested_defective_frame.TranslateTo(0, 0, speed, Easing.CubicInOut);
            harvested_defective_frame.FadeTo(1, speed);
        }

        private async void Harvested_Clicked(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new TaskInspectionHarvestedPalm(), false);
        }

        private async void Unharvested_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TaskInspectionUnharvestedPalm(), false);
        }

        private async void HarvestedDefective_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TaskInspectionHarvestedDefectivePalm(), false);
        }
    }
}