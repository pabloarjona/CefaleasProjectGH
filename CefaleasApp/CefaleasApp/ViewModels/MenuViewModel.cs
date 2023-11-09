using Pitasoft.Commands;
using Pitasoft.Shell.Services;
using Pitasoft.Shell.Xamarin.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using CefaleasApp.Entities;
using CefaleasApp.Models;

namespace CefaleasApp.ViewModels
{
    public class MenuViewModel : MenuViewModelBase
    {
        public ICommand LogoutCommand { get; }
        public MenuViewModel(IMenuService menuService) : base(menuService)
        {
            LogoutCommand = new DelegateCommand(() => DoTask(LogoutAsync()));
        }
        private Task LogoutAsync() => NavigationService.NavigateToAsync<LoginViewModel>(new LogoutParameter { Logout = true });

    }
}