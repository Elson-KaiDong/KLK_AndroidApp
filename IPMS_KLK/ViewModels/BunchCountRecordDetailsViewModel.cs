using IPMS_KLK.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IPMS_KLK.ViewModels
{
    public class BunchCountRecordDetailsViewModel
    {
        private readonly IBunchCountRecordStore _bunchCountRecordStore;
        private readonly IPageService _pageService;
        public BunchCountRecord bunchCountRecord { get; private set; }
        public ICommand SaveCommand { get; private set; }

        public BunchCountRecordDetailsViewModel(BunchCountRecordViewModel viewModel, IBunchCountRecordStore bunchCountRecordStore,IPageService pageService)
        {
            if (viewModel==null)            
                throw new ArgumentNullException(nameof(viewModel));
            

            _pageService = pageService;
            _bunchCountRecordStore = bunchCountRecordStore;
            SaveCommand = new Command(async () => await Save());
            bunchCountRecord = new BunchCountRecord
            {
                TRANS_NO = viewModel.transNo,
                FIELD_NO = viewModel.FIELD_NO,
                TASK_NO = viewModel.TASK_NO,
                CUTTER_ID = viewModel.CUTTER_ID,
                CARRIER_ID = viewModel.CUTTER_ID,
                HARVESTING_TYPE = viewModel.HARVESTING_TYPE,
                NO_RIPE = viewModel.NO_RIPE,
                NO_UNRIPE = viewModel.NO_UNRIPE,
                NO_BLACKBUNCH = viewModel.NO_BLACKBUNCH,
                NO_ROTTENBUNCH = viewModel.NO_ROTTENBUNCH,
                NO_LONGSTALK = viewModel.NO_LONGSTALK,
                NO_PESTDAMAGE = viewModel.NO_PESTDAMAGE,
                TRASH_STATUS = viewModel.TRASH_STATUS,
            };
        }

        async Task Save()
        {
            if (String.IsNullOrEmpty(bunchCountRecord.FIELD_NO)&&
                String.IsNullOrEmpty(bunchCountRecord.TASK_NO) &&
                String.IsNullOrEmpty(bunchCountRecord.CUTTER_ID) &&
                String.IsNullOrEmpty(bunchCountRecord.CARRIER_ID) &&
                String.IsNullOrEmpty(bunchCountRecord.HARVESTING_TYPE ))                              
                
            {
                await _pageService.DisplayAlert("Error", "Fill in all the blanks", "OK");
                return;
            }

            if(bunchCountRecord.TRANS_NO==0)
            {
                await _bunchCountRecordStore.AddBunchCountRecord(bunchCountRecord);
                MessagingCenter.Send(this, Events.BunchCountRecordAdded, bunchCountRecord);
            }

            else
            {
                await _bunchCountRecordStore.UpdateBunchCountRecord(bunchCountRecord);
                MessagingCenter.Send(this, Events.BunchCountRecordUpdated, bunchCountRecord);
            }

            await _pageService.PopAsync();
        }   
    }
}
