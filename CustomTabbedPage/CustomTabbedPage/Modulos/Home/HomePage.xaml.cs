
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomTabbedPage.Modulos.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePageViewModel VM { get; set; }
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = VM = new HomePageViewModel();
        }
    }
}