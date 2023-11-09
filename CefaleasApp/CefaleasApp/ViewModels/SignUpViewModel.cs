using Acr.UserDialogs;
using Pitasoft.Commands;
using Pitasoft.Result;
using Pitasoft.Result.Extensions;
using Pitasoft.Shell.Xamarin.ViewModels;
using Pitasoft.Validations;
using Pitasoft.Validations.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows.Input;
using CefaleasApp.Entities;
using CefaleasApp.Entities.Interfaces;
using CefaleasApp.Models;
using CefaleasApp.Services.Interfaces;

namespace CefaleasApp.ViewModels
{
    public class SignUpViewModel : PageValidatableBase, IUsuario
    {
        Random rnd = new Random();
        //    private readonly IXamarin1SettingsService _settingService;

        public Usuario Usuario { get; private set; }
        private readonly IUsuarioRestService _usuarioService;
        [Validate(Type = ValidateType.Skip)]
        public ICommand BackCommand { get; }
        public ICommand RegistrarmeCommand { get; }
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
        private int _colegiado;
        [Required(ErrorMessage = "Tiene que introducir un correo")]
        public int NColegiado
        {
            get => _colegiado;
            set => SetProperty(ref _colegiado, value);
        }
        private int _nVerificacion;
        // [Required(ErrorMessage = "Tiene que intrdocir un número de verificación")]
        public int NVerificacion
        {
            get => _nVerificacion;
            set => SetProperty(ref _nVerificacion, value);
        }
        // [Required(ErrorMessage = "Tiene que intrdocir un número de médico")]
        private char? _verificado;
        public char? Verificado
        {
            get => _verificado;
            set => SetProperty(ref _verificado, null);
        }
        public string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
        public SignUpViewModel(IUsuarioRestService usuarioService/*,IXamarin1SettingsService settingsService*/) : base()
        {
            // _settingService = settingsService;
            _usuarioService = usuarioService;
            RegistrarmeCommand = new DelegateCommand(() => DoTask(RegistrarmeCommandExecute()));
            BackCommand = new DelegateCommand(BackCommandExecute);
            _ = new ObjectValidator(this);
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
                case nameof(NColegiado):
                    if (NColegiado < 99999999)
                    {
                        SetError("El número de médico tiene que tener 9 dígitos", nameof(NColegiado));
                    }
                    break;
            }
            base.OnValidatedProperty(args);
        }
        private void BackCommandExecute() => NavigationService.NavigateToAsync<LoginViewModel>();
        private async Task RegistrarmeCommandExecute()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            if (Validate())
            {
                Usuario usuario = new Usuario
                {
                    Correo = this.Correo,
                    Password = this.Password,
                    Nombre = this.Nombre,
                    NColegiado = this.NColegiado,
                    NVerificacion = rnd.Next(1000, 10000),
                    Verificado = this.Verificado
                };
                ResultEntity<Usuario> result = await _usuarioService.AddUsuarioAsync(usuario);
                if (result.IsSuccess())
                {
                    UserDialogs.Instance.HideLoading();
                    await UserDialogs.Instance.ConfirmAsync("Te has registrado existosamente","Aceptar");                        
                    await NavigationService.NavigateToAsync<LoginViewModel>();
                }
                else
                {
                    Message = "Error de conexión de red, inténtelo más tarde.";
                    UserDialogs.Instance.HideLoading();
                }
            }
            else
            {
                UserDialogs.Instance.HideLoading();
                Message = "Datos incorrectos.";
            }

        }
    }
}
