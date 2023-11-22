using Pitasoft.Shell.Xamarin.Services;
using CefaleasApp.Entities;
using CefaleasApp.Services.Interfaces;
using System.Dynamic;

namespace CefaleasApp.Services
{
    public class Xamarin1SettingsService : SettingServiceBase, IXamarin1SettingsService
    {
        // Defición de claves.
        private const string AccessToken = "access_token";

        // Valores por defecto.
        private readonly string AccessTokenDefault = string.Empty;

        public string AuthAccessToken
        {
            get => GetValueOrDefault(AccessToken, AccessTokenDefault);
            set => AddOrUpdateValue(AccessToken, value);
        }

        private Usuario _usuario;

        public Usuario Usuario
        {
            get => _usuario;
            set => _usuario = value;
        }


    }
}
