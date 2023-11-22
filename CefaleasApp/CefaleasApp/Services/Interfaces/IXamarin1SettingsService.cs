using Pitasoft.Shell.Xamarin.Services;
using CefaleasApp.Entities;

namespace CefaleasApp.Services.Interfaces
{
    public interface IXamarin1SettingsService : ISettingsService
    {
        string AuthAccessToken { get; set; }
        Usuario Usuario{ get; set; }
    }
}
