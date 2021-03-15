using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPMS_KLK.Models
{
    public class BunchCountModel
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

        public override string ToString()
        {
            return "Transaction No:" + this.TRANS_NO +
                    "\r\nField No:" + FIELD_NO +
                    "\r\nTask No:" + TASK_NO +
                    "\r\nCutter ID:" + CUTTER_ID +
                    "\r\nCarrier ID" + CARRIER_ID +
                    "Contract/Checkroll" + HARVESTING_TYPE;
        }
    }

}
