 
using Hybrid.Views.Layout; 
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Design.Views.Shared
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _Layout : ContentPage
    {
        public _Layout()
        { 
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false); 
        }
         
    }
}