using IPMS_KLK.Models;
using SQLite;
using System.Collections.Generic;
using System.IO;

namespace IPMS_KLK.ViewModels.FFBCountingContentsViewModels
{
    public class AmendVerificationViewModel : BaseViewModel
    {
        public List<BunchCountModel> bunchCountList { get; set; }



        public AmendVerificationViewModel()
        {
            string db_Path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ipmsklk_db");
            var db = new SQLiteConnection(db_Path);

            
            bunchCountList = db.Table<BunchCountModel>().OrderBy(x => x.TRANS_NO).ToList();
                
           
            
                
            
        }

        
    }
}
