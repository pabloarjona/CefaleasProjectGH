using Pitasoft.Shell;
using System.ComponentModel;
using Xamarin.Forms;

namespace CefaleasApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainView : MasterDetailPage, IView 
    {
        public IViewModel ViewModel { get; set; }
        public MainView()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
            //FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;
            
            
        }
    }
}