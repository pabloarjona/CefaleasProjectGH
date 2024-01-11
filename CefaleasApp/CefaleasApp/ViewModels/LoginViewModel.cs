using Acr.UserDialogs;
using Pitasoft.Commands;
using Pitasoft.Result;
using Pitasoft.Result.Extensions;
using Pitasoft.Shell.Xamarin.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using CefaleasApp.Entities;
using CefaleasApp.Models;
using CefaleasApp.Services.Interfaces;
using CefaleasApp.Services;
using Xamarin.Forms;
using System.Threading;
using System.Diagnostics;
using Pitasoft.Shell.Xamarin.Services;

namespace CefaleasApp.ViewModels
{
    public class LoginViewModel : PageBase
    {

        private readonly CefaleasRestService _restService;
        private readonly INavigationService _navigationService;
        private readonly IXamarin1SettingsService _settingsService;
        private string _correo;
        public string Correo
        {
            get => _correo;
            set => SetProperty(ref _correo, value);
        }
        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        public string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
        public ICommand LoginCommand { get; }
        public ICommand RegistrarmeCommand { get; }

        public LoginViewModel(CefaleasRestService restService, INavigationService navigationService, IXamarin1SettingsService settingsService) : base()
        {
            _restService = restService;
            _navigationService = navigationService;
            _settingsService = settingsService;
            if (_restService.DEVELOPMENT_ENVIROMENT.Equals(EnvironmentDevelopment.LOCAL))
                LoginCommand = new DelegateCommand(() => LoginCommandExecuteLocal());
            else 
                LoginCommand = new DelegateCommand(() => DoTask(LoginCommandExecute()));
            RegistrarmeCommand = new DelegateCommand(RegistrarmeCommandExecute);
            Message = "";
        }

        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is LogoutParameter logoutParameter)
            {
                if (logoutParameter.Logout)
                {
                    _settingsService.AuthAccessToken = string.Empty;
                }
            }
            return base.InitializeAsync(navigationData);
        }

        public async Task LoginCommandExecute()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            ResultEntities<Usuario> result = await this._restService.GetUsuariosAsync();
            _settingsService.AuthAccessToken = "access_token";
            if (result.IsSuccess() && result.Entities != null)
            {
                bool login = false;
                foreach (var item in result.Entities)
                {
                    if (item.Correo == Correo && item.Password== Password)
                    { 
                        UserDialogs.Instance.HideLoading();
                        _settingsService.Usuario = item;
                        login = true;
                        Message = string.Empty;
                        await _navigationService.NavigateToAsync<MainViewModel>(item, true);
                        break;
                    }
                }
                if (!login)
                {
                    UserDialogs.Instance.HideLoading();
                    Message = "Usuario o contraseña incorrectos.";
                }
            }
            else
            {
                UserDialogs.Instance.HideLoading();
                await UserDialogs.Instance.ConfirmAsync("Error de conexión de red", "Error", "Aceptar");
            }
        }

        public void RegistrarmeCommandExecute()
        {
            Message = string.Empty;
            //_settingService.AuthAccessToken = "TOKEN";
            NavigationService.NavigateToAsync<SignUpViewModel>();
        }
        //LOCAL 
        public void LoginCommandExecuteLocal()
        {
            Message = string.Empty;
            //_settingService.AuthAccessToken = "TOKEN";
            Usuario usuario = new Usuario {
                Correo = "prueba@gmail.com",
                Password = "prueba",
                IdUsuario = 1,
                NColegiado = 1,
                NVerificacion = 1,
                Nombre = "admin"
            };
            _settingsService.Usuario = usuario;
            NavigationService.NavigateToAsync<MainViewModel>(usuario, true);
        }
    }
}
