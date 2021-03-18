using IPMS_KLK.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IPMS_KLK.ViewModels
{
    public class BunchCountRecordPageViewModel : BaseViewModel
    {
        private BunchCountRecordViewModel _selectedBunchCountRecord;
        private IBunchCountRecordStore _bunchCountRecordStore;
        private IPageService _pageService;

        private bool _isDataLoaded;

        public BunchCountRecordViewModel SelectedBunchCountRecord
        {
            get { return _selectedBunchCountRecord; }
            set { SetValue(ref _selectedBunchCountRecord, value); }
        }

        public ObservableCollection<BunchCountRecordViewModel> BunchCountRecord { get; private set; } = new ObservableCollection<BunchCountRecordViewModel>();

        public ICommand LoadDataCommand { get; private set; }
        public ICommand AddBunchCountRecordCommand { get; private set; }
        public ICommand SelectBunchCountRecordCommand { get; private set; }
        public ICommand DeleteBunchCountRecordCommand { get; private set; }
        
        public BunchCountRecordPageViewModel(IBunchCountRecordStore bunchCountRecordStore,IPageService pageService)
        {
            _bunchCountRecordStore = bunchCountRecordStore;
            _pageService = pageService;

            LoadDataCommand = new Command(async () => await LoadData());
            AddBunchCountRecordCommand = new Command(async () => await AddBunchCountRecord());
            SelectBunchCountRecordCommand = new Command<BunchCountRecordViewModel>(async c => await SelectBunchCountRecord(c));
            DeleteBunchCountRecordCommand = new Command<BunchCountRecordViewModel>(async c => await DeleteBunchCountRecord(c));
        }

        private async Task LoadData()
        {
            if (_isDataLoaded)
                return;

            _isDataLoaded = true;
            var bunchCountModels = await _bunchCountRecordStore.GetBunchCountRecordAsync();
            foreach (var bunchCountModel in bunchCountModels)
                BunchCountRecord.Add(new BunchCountRecordViewModel(bunchCountModel));
        }

        private async Task AddBunchCountRecord()
        {
            await _pageService.PushAsync(new BunchCountDetailPage());
        }

        private async Task SelectBunchCountRecord(BunchCountRecordViewModel bunchCountRecord)
        {
            if (bunchCountRecord == null)
                return;

            SelectedBunchCountRecord = null;
            await _pageService.PushAsync(new BunchCountDetailPage());

        }

        private async Task DeleteBunchCountRecord(BunchCountRecordViewModel bunchCountRecordViewModel)
        {
            if (await _pageService.DisplayAlert("Warning",$"Are you sure you want to delete{bunchCountRecordViewModel}?","Yes","No"))
            {
                BunchCountRecord.Remove(bunchCountRecordViewModel);

                var _bunchCountRecord = await _bunchCountRecordStore.GetBunchCountRecord(bunchCountRecordViewModel.transNo);
                await _bunchCountRecordStore.DeleteBunchCountRecord(_bunchCountRecord);
            }

            
        }

            
    }
}
