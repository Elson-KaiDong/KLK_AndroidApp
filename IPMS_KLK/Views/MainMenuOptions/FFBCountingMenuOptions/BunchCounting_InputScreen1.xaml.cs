using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace IPMS_KLK.Views.MainMenuOptions.FFBCountingMenuOptions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BunchCounting_InputScreen1 : ContentPage
    {    
        public BunchCounting_InputScreen1()
        {
            InitializeComponent();
            BindingContext = new ViewModels.FFBCountingContentsViewModels.BunchCountingViewModel();            
        }        
    }
}