using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPMS_KLK.Persistence;
using IPMS_KLK.ViewModels;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BunchCountRecordPage : ContentPage
    {
        public BunchCountRecordPage()
        {
            var bunchCountRecordStore = new SQLiteBunchCountRecordStore(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            ViewModel = new BunchCountRecordPageViewModel(bunchCountRecordStore, pageService);
            InitializeComponent();
        }

        public BunchCountRecordPageViewModel ViewModel
        {
            get
            { return BindingContext as BunchCountRecordPageViewModel; }

            set
            { BindingContext = value; }
        }

        protected override void OnAppearing()
        {
            ViewModel.LoadDataCommand.Execute(null);
            base.OnAppearing();
        }

        void OnBunchCountRecordSelected (object sender,SelectedItemChangedEventArgs e)
        {
            ViewModel.SelectBunchCountRecordCommand.Execute(e.SelectedItem);
        }
    }
}