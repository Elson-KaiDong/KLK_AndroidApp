using SQLite;


namespace IPMS_KLK.Models
{
    public class BunchCountRecord
    {
        [PrimaryKey, AutoIncrement]
        public int TRANS_NO { get; set; }
        public string FIELD_NO { get; set; }
        public string TASK_NO { get; set; }
        public string CUTTER_ID { get; set; }
        public string CARRIER_ID { get; set; }
        public string HARVESTING_TYPE { get; set; }
        public int NO_RIPE { get; set; }
        public int NO_UNRIPE { get; set; }
        public int NO_BLACKBUNCH { get; set; }
        public int NO_ROTTENBUNCH { get; set; }
        public int NO_LONGSTALK { get; set; }
        public int NO_PESTDAMAGE { get; set; }
        public int TRASH_STATUS { get; set; }
    }
}
