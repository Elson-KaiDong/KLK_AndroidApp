
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


            
            latexFC_next_btn.Scale = 0;
            latexFC_next_btn.ScaleTo(1, 1000, Easing.SpringOut);
        }
    }
}