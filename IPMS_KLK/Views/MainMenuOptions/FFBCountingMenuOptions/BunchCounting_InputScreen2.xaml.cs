using IPMS_KLK.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPMS_KLK.Views.MainMenuOptions.FFBCountingMenuOptions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views.MainMenuOptions.FFBCountingMenuOptions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BunchCounting_InputScreen2 : ContentPage
    {
        string db_Path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),"ipmsklk_db");

        string Field_no { get; set; }
        string Task_no{ get; set; }
        string Cutter_id { get; set; }
        string Carrier_id { get; set; }
        string Harvesting_type{ get; set; }

        public BunchCounting_InputScreen2(string field_no,string task_no, string cutter_id,string carrier_id,string harvesting_type)
        {
            InitializeComponent();
            Field_no = field_no;
            Task_no = task_no;
            Cutter_id = cutter_id;
            Carrier_id = carrier_id;
            Harvesting_type = harvesting_type;
            BunchCounting_pg2_PrintBtn.Clicked += BunchCounting_pg2_PrintBtn_Clicked;
        }
        public BunchCounting_InputScreen2()
        {
            InitializeComponent();
        }

        private async void BunchCounting_pg2_PrintBtn_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(db_Path);
            db.CreateTable<BunchCountModel>();

            var maxPK = db.Table<BunchCountModel>().OrderByDescending(c => c.TRANS_NO).FirstOrDefault();

            BunchCountModel bunchCountModel = new BunchCountModel()
            {
                TRANS_NO = (maxPK == null ? 1 : maxPK.TRANS_NO + 1),
                FIELD_NO = Field_no,
                TASK_NO = Task_no,
                CUTTER_ID=Cutter_id,
                CARRIER_ID = Carrier_id,
                NO_RIPE = Convert.ToInt32(bunchCounting_pg2_Ripe_Entry.Text),
                NO_UNRIPE = Convert.ToInt32(bunchCounting_pg2_Unripe_Entry.Text),
                NO_BLACKBUNCH = Convert.ToInt32(bunchCounting_pg2_BlackBunch_Entry.Text),
                NO_ROTTENBUNCH = Convert.ToInt32(bunchCounting_pg2_RottenBunch_Entry.Text),
                NO_LONGSTALK = Convert.ToInt32(bunchCounting_pg2_LongStalk_Entry.Text),
                NO_PESTDAMAGE = Convert.ToInt32(bunchCounting_pg2_PestDamage_Entry.Text),
                TRASH_STATUS = Convert.ToInt32(bunchCounting_pg2_TrashStatus_Entry.Text),       
            };

            db.Insert(bunchCountModel);
            await DisplayAlert(null, "Bunch Counting Completed", "OK");
            
        }

        

    }
}