using Acr.UserDialogs;
using Pitasoft.Commands;
using Pitasoft.Result;
using Pitasoft.Result.Extensions;
using Pitasoft.Shell;
using Pitasoft.Shell.Xamarin.Services;
using Pitasoft.Validations;
using Pitasoft.Validations.Attributes;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows.Input;
using CefaleasApp.Entities;
using CefaleasApp.Entities.Interfaces;
using CefaleasApp.Models;
using CefaleasApp.Services.Interfaces;

namespace CefaleasApp.ViewModels
{
    public class UsuarioViewModel : PageValidatableBase, IUsuario
    {
        private readonly IDialogService _dialogService;
        private readonly IXamarin1SettingsService _settingsService;
        private readonly INavigationService _navigationService;
        public const string OtroUsuario = "OtroUsuario";
        public ObservableCollection<Usuario> Employees { get; } = new ObservableCollection<Usuario>();
        public Usuario Usuario { get; set; }
        private readonly IUsuarioRestService _usuarioService;
        [Validate(Type = ValidateType.Skip)]

        private string _nombre;
        [Required(ErrorMessage = "Tiene que introducir su nombre")]
        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }
        private string _password;
        [Required(ErrorMessage = "Tiene que introducir un contraseña")]
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        private string _password2;
        [Required(ErrorMessage = "Tiene que volver a introducir la contraseña")]
        public string Password2
        {
            get => _password2;
            set => SetProperty(ref _password2, value);
        }
        private string _correo;
        [Required(ErrorMessage = "Tiene que introducir un correo")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Tiene que especificar un correo con formato correcto.")]
        public string Correo
        {
            get => _correo;
            set => SetProperty(ref _correo, value);
        }
        private int _nColegiado;
        [Required(ErrorMessage = "Tiene que intrdocir un número de médico")]
        public int NColegiado
        {
            get => _nColegiado;
            set => SetProperty(ref _nColegiado, value);
        }
        private int _nVerificacion;
        public int NVerificacion
        {
            get => _nVerificacion;
            set => SetProperty(ref _nVerificacion, value);
        }

        private char? _verificado;
        public char? Verificado
        {
            get => _verificado;
            set => SetProperty(ref _verificado, value);
        }
        public string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
        public ICommand UpdateCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }
        public UsuarioViewModel(IUsuarioRestService usuarioService, IXamarin1SettingsService settingsService, IDialogService dialogService, INavigationService navigationService) : base()
        {
            _navigationService = navigationService;
            _settingsService = settingsService;
            _usuarioService = usuarioService;
            _dialogService = dialogService;
            _ = new ObjectValidator(this);
            //UpdateCommand = new DelegateCommand(() => DoTask(UpdateCommandExecute()));
            SaveCommand = new DelegateCommand(() => DoTask(SaveCommandExecute()));
            DeleteCommand = new DelegateCommand(() => DoTask(DeleteCommandExecute()));
        }
        public override Task InitializeAsync(object navigationData)
        {
            CopyUsuario((this.Usuario = Usuario), this);
            this.Password2 = this.Password;
            return base.InitializeAsync(navigationData);
        }

        private async Task DeleteCommandExecute()
        {
            bool result = await UserDialogs.Instance.ConfirmAsync("¿Estas seguro que quieres eliminar tu cuenta?", "Eliminar cuenta", "Sí", "No");

            if (result)
            {
                Result result1 = await _usuarioService.DeleteUsuarioAsync(this.Usuario.IdUsuario);
                if (result1.IsSuccess())
                {
                    await _dialogService.ShowAlertAsync("Se ha eliminado correctamente", "Eliminación correcta", "Aceptar");
                    await _navigationService.NavigateToAsync<LoginViewModel>(new LogoutParameter { Logout = true });
                    // _settingsService.
                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    await _dialogService.ShowAlertAsync("Error de conexión de red, inténtelo más tarde.", "Error", "Aceptar");
                }
            }
            else
            {
                return;
            }
        }
        private async Task SaveCommandExecute()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            if (Validate())
            {
                Usuario user = CopyUsuario(this, new Usuario
                {
                    Verificado = this.Usuario.Verificado,
                    IdUsuario = this.Usuario.IdUsuario,
                }) as Usuario;
                ResultEntity<Usuario> result = await _usuarioService.UpdateUsuarioAsync(user);
                if (result.IsSuccess())
                {
                    UserDialogs.Instance.HideLoading();
                    await _dialogService.ShowAlertAsync("Se ha modificado correctamente", "Modificación correcta", "Aceptar");
                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    await _dialogService.ShowAlertAsync("Error de conexión de red, inténtelo más tarde.", "Error", "Aceptar");
                }
            }
        }

        protected override void OnValidatedProperty(ValidatedPropertyEventArgs args)
        {
            switch (args.PropertyName)
            {
                case nameof(Password2):
                    if (Password != Password2)
                    {
                        SetError("Las contraseñas deben ser iguales", nameof(Password2));
                    }
                    break;
            }
            base.OnValidatedProperty(args);
        }
        private IUsuario CopyUsuario(IUsuario origen, IUsuario destino)
        {
            destino.Nombre = origen.Nombre;
            destino.Password = origen.Password;
            destino.Correo = origen.Correo;
            destino.NColegiado = origen.NColegiado;
            destino.NVerificacion = origen.NVerificacion;
            destino.Verificado = origen.Verificado;
            return destino;
        }


    }
}
