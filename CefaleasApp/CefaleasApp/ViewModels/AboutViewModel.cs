using Pitasoft.Commands;
using Pitasoft.Shell.Xamarin.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;

namespace CefaleasApp.ViewModels
{
    public class AboutViewModel : PageBase
    {
        public AboutViewModel() : base()
        {
            Title = "Acerca de nosotros";
            OpenWebCommand = new DelegateCommand(OpenWebCommandExecute);
        }
            
        public ICommand OpenWebCommand { get; }
        private void OpenWebCommandExecute() => DoTask(OpenWebAsync());
        private async Task OpenWebAsync()
        {
            await Browser.OpenAsync("https://pitasoft.com/");
        }
    }
}