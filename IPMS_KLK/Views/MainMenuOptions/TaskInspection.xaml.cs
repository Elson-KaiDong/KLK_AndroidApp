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
    public partial class TaskInspection : ContentPage
    {
        public TaskInspection()
        {
            InitializeComponent();
            Title = "Task Inspection";
            //btn_TaskInspection_Reset.Clicked += Btn_TaskInspection_Reset_Clicked;            
            pv_workerID.TranslationX = -300;
            pv_FieldNo.TranslationX = -300;
            pv_TaskNo.TranslationX = 300;
            pv_Direction.TranslationX = 300;
            pv_workerID.TranslateTo(0, 0, 1000, Easing.CubicOut);
            pv_FieldNo.TranslateTo(0, 0, 1500, Easing.CubicOut);
            pv_TaskNo.TranslateTo(0, 0, 1000, Easing.CubicOut);
            pv_Direction.TranslateTo(0, 0, 1500, Easing.CubicOut);

        }

        private void Btn_TaskInspection_Reset_Clicked(object sender, EventArgs e)
        {
            //TaskInspection_WorkerID_Entry.Text = "";
            //.Text = "";
            //TaskInspection_TaskNo_Entry.Text = "";         
            
        }
    }
}