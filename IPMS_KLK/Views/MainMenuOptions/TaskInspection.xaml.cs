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
            btn_TaskInspection_Reset.Clicked += Btn_TaskInspection_Reset_Clicked;
            SetValue(NavigationPage.HasBackButtonProperty, true);
            NavigationPage.SetHasBackButton(this, true);
            
        }

        private void Btn_TaskInspection_Reset_Clicked(object sender, EventArgs e)
        {
            TaskInspection_WorkerID_Entry.Text = "";
            TaskInspection_FieldNo_Entry.Text = "";
            TaskInspection_TaskNo_Entry.Text = "";         
            
        }
    }
}