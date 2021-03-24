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
        //private ListView AmendVerified_ListView;
        //private CollectionView AmendVerified_ListView;
        
        //string db_Path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ipmsklk_db");

        public AmendVerificationFFB_InputScreen1()
        {
            BindingContext = new ViewModels.FFBCountingContentsViewModels.AmendVerificationViewModel();
            /*this.Title = "Amend Verified";
            var db = new SQLiteConnection(db_Path);

            StackLayout stackLayout = new StackLayout
            {
                Padding = new Thickness(20, 20, 20, 20),
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.StartAndExpand
            };


            //AmendVerified_ListView = new ListView();

            AmendVerified_ListView = new CollectionView
            {
                SelectionMode = SelectionMode.Single
               
            };
            
            try
            {
                var listviewItemSource = db.Table<BunchCountModel>().OrderBy(x => x.TRANS_NO).ToList();
                AmendVerified_ListView.ItemsSource = db.Query<BunchCountModel>("SELECT * FROM[BunchCountModel]");
            }

            catch
            {
                DisplayAlert("", "There is no bunch count record in this device", "OK");
            }
            
            
            // AmendVerified_ListView.ItemsSource = listviewItemSource; 
            stackLayout.Children.Add(AmendVerified_ListView);
            
            Content = stackLayout;*/
        }        
    }
}