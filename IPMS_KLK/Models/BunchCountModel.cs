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
            return "TRANS_NO: " + TRANS_NO +
                    "\nFIELD NO: " + FIELD_NO +
                    "\nTASK NO: " + TASK_NO +
                    "\nCUTTER ID: " + CUTTER_ID +
                    "\nCARRIER ID: " + CARRIER_ID +
                    "\nHARVESTING TYPE: " + HARVESTING_TYPE +
                    "\nRIPE: " + NO_RIPE +
                    "\nUNRIPE: " + NO_UNRIPE +
                    "\nBLACK BUNCH: " + NO_BLACKBUNCH +
                    "\nROTTEN BUNCH: " + NO_ROTTENBUNCH +
                    "\nLONG STALK: " + NO_LONGSTALK +
                    "\nPEST DAMAGE: " + NO_PESTDAMAGE +
                    "\nTRASH STATUS: " + TRASH_STATUS 
                    +Environment.NewLine;
        }

        
    }

}
