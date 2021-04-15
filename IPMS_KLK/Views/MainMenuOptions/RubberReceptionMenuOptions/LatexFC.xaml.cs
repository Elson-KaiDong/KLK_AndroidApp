
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPMS_KLK.Views.MainMenuOptions.RubberReceptionMenuOptions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LatexFC : ContentPage 
    {
        public LatexFC()
        {
            InitializeComponent();            
            BindingContext = new ViewModels.RubberReceptionContentsViewModels.LatexFC_ViewModel();


            titleLabel.TranslationX = 300;
            titleLabel.TranslateTo(0, 0, 750, Easing.SpringOut);
        }
    }
}