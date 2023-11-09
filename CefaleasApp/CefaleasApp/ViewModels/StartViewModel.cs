using Pitasoft.Commands;
using Pitasoft.Shell.Xamarin;
using Pitasoft.Shell.Xamarin.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using CefaleasApp.Entities;
using CefaleasApp.Entities.Interfaces;

namespace CefaleasApp.ViewModels
{
    public class StartViewModel : PageBase
    {
        public StartViewModel() : base()
        {
            Title = "Inicio";
            OpenWebCommand = new DelegateCommand(OpenWebCommandExecute);
        }
        public ICommand OpenWebCommand { get; }
        private void OpenWebCommandExecute() => DoTask(OpenWebAsync());
        private async Task OpenWebAsync()
        {
            await Browser.OpenAsync("https://ichd-3.org/wp-content/uploads/2019/07/ICHD-III-Espa%C3%B1ol-2019.pdf");
        }
    }
}