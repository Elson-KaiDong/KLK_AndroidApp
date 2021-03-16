using IPMS_KLK.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using IPMS_KLK.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views.MainMenuOptions.FFBCountingMenuOptions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AmendVerificationFFB_InputScreen1 : ContentPage
    {
        
        
        

        private ListView AmendVerified_ListView;
        string db_Path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ipmsklk_db");

        public AmendVerificationFFB_InputScreen1()
        {
            
            this.Title = "Amend Verified";
            var db = new SQLiteConnection(db_Path);

            StackLayout stackLayout = new StackLayout();
            AmendVerified_ListView = new ListView();
            
            var listviewItemSource= db.Table<BunchCountModel>().OrderBy(x => x.TRANS_NO).ToArray();
            AmendVerified_ListView.ItemsSource = listviewItemSource;
            
            //tc_TRANS_NO.Text = "";
            

            stackLayout.Children.Add(AmendVerified_ListView);
            
            Content = stackLayout;
        }        
    }
}