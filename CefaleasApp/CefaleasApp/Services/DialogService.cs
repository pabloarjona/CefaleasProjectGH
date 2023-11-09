using Acr.UserDialogs;
using Pitasoft.Shell.Xamarin.Services;
using System.Threading.Tasks;

namespace CefaleasApp.Services
{
    public class DialogService : IDialogService
    {
        public Task ShowAlertAsync(string message, string title, string buttonLabel) => UserDialogs.Instance.AlertAsync(message, title, buttonLabel);
    }
}
