using Pitasoft.Shell;
using Pitasoft.Shell.Xamarin;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CefaleasApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartView : ShellPage
    {
        public StartView()
        {
            InitializeComponent();
        }
        //public IViewModel ViewModel { get; set; }
    }
}