using IPMS_KLK.Models;

namespace IPMS_KLK.ViewModels
{
    public class BunchCountRecordViewModel : BaseViewModel
    {
        public int transNo { get; set; }

        public BunchCountRecordViewModel()
        {
        }

        public BunchCountRecordViewModel(BunchCountRecord bunchCountRecord)
        {
            transNo = bunchCountRecord.TRANS_NO;
            fieldNo = bunchCountRecord.FIELD_NO;
            taskNo = bunchCountRecord.TASK_NO;
            cutterId = bunchCountRecord.CUTTER_ID;
            carrierId = bunchCountRecord.CARRIER_ID;
            harvestingType = bunchCountRecord.HARVESTING_TYPE;
            ripeNo = bunchCountRecord.NO_RIPE;
            unripeNo = bunchCountRecord.NO_UNRIPE;
            blackBunch = bunchCountRecord.NO_BLACKBUNCH;
            rottenBunch = bunchCountRecord.NO_ROTTENBUNCH;
            pestDamage = bunchCountRecord.NO_PESTDAMAGE;
            trashStatus = bunchCountRecord.TRASH_STATUS;
        }

        private string fieldNo;
        public string FIELD_NO
        {
            get
            {
                return fieldNo;
            }

            set
            {
                SetValue(ref fieldNo, value);
                OnPropertyChanged(nameof(FIELD_NO));
            }
        }

        private string taskNo;
        public string TASK_NO
        {
            get
            {
                return taskNo;
            }

            set
            {
                SetValue(ref taskNo, value);
                OnPropertyChanged(nameof(TASK_NO));
            }
        }

        private string cutterId;
        public string CUTTER_ID
        {
            get
            {
                return cutterId;
            }

            set
            {
                SetValue(ref cutterId, value);
                OnPropertyChanged(nameof(CUTTER_ID));
            }

        }

        private string carrierId;
        public string CARRIER_ID
        {
            get
            {
                return carrierId;
            }

            set
            {
                SetValue(ref carrierId, value);
                OnPropertyChanged(nameof(CARRIER_ID));
            }

        }

        private string harvestingType;
        public string HARVESTING_TYPE
        {
            get
            {
                return harvestingType;
            }

            set
            {
                SetValue(ref harvestingType, value);
                OnPropertyChanged(nameof(HARVESTING_TYPE));
            }
        }

        private int ripeNo;
        public int NO_RIPE
        {
            get
            {
                return ripeNo;
            }

            set
            {
                SetValue(ref ripeNo, value);
                OnPropertyChanged(nameof(NO_RIPE));
            }
        }

        private int unripeNo;
        public int NO_UNRIPE
        {
            get
            {
                return unripeNo;
            }

            set
            {
                SetValue(ref unripeNo, value);
                OnPropertyChanged(nameof(NO_UNRIPE));
            }
        }

        private int blackBunch;
        public int NO_BLACKBUNCH
        {
            get
            {
                return blackBunch;
            }

            set
            {
                SetValue(ref blackBunch, value);
                OnPropertyChanged(nameof(NO_BLACKBUNCH));
            }
        }

        private int rottenBunch;
        public int NO_ROTTENBUNCH
        {
            get
            {
                return rottenBunch;
            }

            set
            {
                SetValue(ref rottenBunch, value);
                OnPropertyChanged(nameof(NO_ROTTENBUNCH));
            }
        }

        private int longStalk;
        public int NO_LONGSTALK
        {
            get
            {
                return longStalk;
            }

            set
            {
                SetValue(ref longStalk, value);
                OnPropertyChanged(nameof(NO_LONGSTALK));
            }
        }

        private int pestDamage;
        public int NO_PESTDAMAGE
        {
            get
            {
                return pestDamage;
            }

            set
            {
                SetValue(ref pestDamage, value);
                OnPropertyChanged(nameof(NO_PESTDAMAGE));
            }
        }

        private int trashStatus;
        public int TRASH_STATUS
        {
            get
            {
                return trashStatus;
            }

            set
            {
                SetValue(ref trashStatus, value);
                OnPropertyChanged(nameof(TRASH_STATUS));
            }
        }



    }
}


