using Pitasoft.Shell.Xamarin.Services;
using System.Threading.Tasks;
using CefaleasApp.Services.Interfaces;
using CefaleasApp.ViewModels;

namespace CefaleasApp.Services
{
    public class NavigationService : NavigationServiceBase
    {
        private readonly IXamarin1SettingsService _settingsService;
        public NavigationService(IXamarin1SettingsService settingsService) => _settingsService = settingsService;

        public override Task InitializeAsync()
        {
            return /*string.IsNullOrEmpty(_settingsService.AuthAccessToken) ?*/ NavigateToAsync<LoginViewModel>() /*: NavigateToAsync<MainViewModel>()*/;
        }
    }
}
