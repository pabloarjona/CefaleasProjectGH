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

namespace CefaleasApp.ViewModels
{
    public class LoginViewModel : PageBase
    {
        private readonly IUsuarioRestService _usuarioService;
        private readonly IXamarin1SettingsService _settingService;
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

        public LoginViewModel(IUsuarioRestService usuarioService, IXamarin1SettingsService settingsService) : base()
        {
            _usuarioService = usuarioService;
            _settingService = settingsService;
            LoginCommand = new DelegateCommand(() => DoTask(LoginCommandExecute()));
            RegistrarmeCommand = new DelegateCommand(RegistrarmeCommandExecute);
        }
        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is LogoutParameter logoutParameter)
            {
                if (logoutParameter.Logout)
                {
                    _settingService.AuthAccessToken = string.Empty;
                }
            }
            return base.InitializeAsync(navigationData);
        }
        public async Task LoginCommandExecute()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            ResultEntities<Usuario> result = await this._usuarioService.GetUsuariosAsync();
            _settingService.AuthAccessToken = "access_token";
            if (result.IsSuccess())
            {
                foreach (var item in result.Entities)
                {
                    if (item.Correo == Correo && item.Password== Password)
                    {
                        _usuarioService.usuario = item;
                        UserDialogs.Instance.HideLoading();
                        await NavigationService.NavigateToAsync<MainViewModel>(item);
                    }

                }
                UserDialogs.Instance.HideLoading();
                Message = "Usuario o contraseña incorrectos.";
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
    }
}
