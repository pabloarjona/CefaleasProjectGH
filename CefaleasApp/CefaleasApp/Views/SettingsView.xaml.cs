using Pitasoft.Shell;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CefaleasApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsView : ContentPage, IView
    {
        public SettingsView()
        {
            InitializeComponent();
        }
        public IViewModel ViewModel { get; set; }
    }
}