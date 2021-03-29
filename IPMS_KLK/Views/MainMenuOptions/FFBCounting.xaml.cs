using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views.MainMenuOptions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FFBCounting : ContentPage
    {
        public FFBCounting()
        {
            InitializeComponent();
            BindingContext = new ViewModels.FFBCountingContentsViewModels.FFBCountingViewModel();
        }

    }
}