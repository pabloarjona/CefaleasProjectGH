using Acr.UserDialogs;
using Pitasoft.Commands;
using Pitasoft.Result;
using Pitasoft.Result.Extensions;
using Pitasoft.Shell.Xamarin.ViewModels;
using Pitasoft.Validations;
using Pitasoft.Validations.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows.Input;
using CefaleasApp.Entities;
using CefaleasApp.Entities.Interfaces;
using CefaleasApp.Services.Interfaces;
using CefaleasApp.Services;

namespace CefaleasApp.ViewModels
{
    public class PacienteAddViewModel : PageValidatableBase, IPaciente
    {
        private readonly CefaleasRestService _restService;
        [Validate(Type = ValidateType.Skip)]
        Paciente Paciente = new Paciente();
        public ICommand AddPacienteCommand { get; }
        private string _iniciales;
        [Required(ErrorMessage = "Tiene que especificar las iniciales del paciente")]
        public string Iniciales
        {
            get => _iniciales;
            set => SetProperty(ref _iniciales, value);
        }
        private DateTime _fechaConsulta;
        [Required(ErrorMessage = "Tiene que especificar la fecha de consulta del paciente")]
        [DataType(DataType.Date, ErrorMessage = "Tiene que poner una fecha")]
        public DateTime FechaConsulta
        {
            get => _fechaConsulta;
            set => SetProperty(ref _fechaConsulta, value);
        }
        private short _edad;
        [RegularExpression(@"^[0-9]+$",ErrorMessage = "Tiene que especificar un número, no se aceptan letras")]
        // [DataType(DataType.Date, ErrorMessage ="Tiene que poner una edad")]
        [Required(ErrorMessage = "Tiene que especificar la edad del paciente")]
        public short Edad
        {
            get => _edad;
            set => SetProperty(ref _edad, value);
        }
        public char _sexo;
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Tiene que especificar el sexo del paciente")]
        public char Sexo
        {
            get => _sexo;
            set => SetProperty(ref _sexo, value);
        }
        public string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
        public PacienteAddViewModel(CefaleasRestService restService) : base()
        {
            _restService = restService;
            Title = "Añadir paciente";
            AddPacienteCommand = new DelegateCommand(() => DoTask(AddPacienteCommandExecute())/*,PacienteAdded*/);
            _ = new ObjectValidator(this);
            FechaConsulta = DateTime.Today;
        }
        protected override void OnValidatedProperty(ValidatedPropertyEventArgs args)
        {
            switch (args.PropertyName)
            {
                case nameof(FechaConsulta):
                    if (FechaConsulta < new DateTime(2019, 1, 1) || FechaConsulta > DateTime.Today)
                    {
                        SetError("Establezca una fecha correcta", nameof(FechaConsulta));
                    }
                    break;
                case nameof(Sexo):
                    if (Sexo== '\0')
                    {
                        SetError("Este campo es obligatorio", nameof(Sexo));
                    }
                    break;
                case nameof(Edad):
                    if(short.TryParse(Edad.ToString(), out _))
                    {
                        SetError("Tiene que insertar un valor numérico", nameof(Edad));
                    }
                    break;
                case nameof(Iniciales):
                    if (String.IsNullOrEmpty(Iniciales))
                    {
                        SetError("Este campo es obligatorio.", nameof(Iniciales));
                    }
                    else
                    {
                        char[] arr;
                        arr = Iniciales.ToCharArray();
                        int i = 0;
                        foreach (char c in arr)
                        {
                            if(!c.Equals('.') && !Char.IsLetter(c))
                            {
                               SetError("El formato es incorrecto. Ej: P.A.R.", nameof(Iniciales));
                            }
                            if (i > 0)
                            {
                                if (Char.IsLetter(arr[i]) && Char.IsLetter(arr[i - 1]))
                                {
                                    SetError("Debe haber un punto entre las letras.", nameof(Iniciales));
                                }
                            }
                            i++;
                        }
                    }
                    break;
            }
            base.OnValidatedProperty(args);
        }
        
         public override Task InitializeAsync(object navigationData)
         {
            if (navigationData is Paciente paciente)
                Paciente = paciente;
             return base.InitializeAsync(navigationData);
         }
        private async Task AddPacienteCommandExecute()
        {
            if (this.IsBusy)
                return;
            this.IsBusy = true;
            UserDialogs.Instance.ShowLoading("Cargando...");
            if (Validate())
            {
                Paciente pacient = new Paciente()
                {
                    IdUsuario = Paciente.IdUsuario,
                    Iniciales = Iniciales,
                    FechaConsulta = FechaConsulta,
                    Edad = Edad,
                    Sexo = Sexo,
                };
                ResultEntity<Paciente> result = await _restService.AddPacienteAsync(pacient);
                if (result.IsSuccess())
                {
                    UserDialogs.Instance.HideLoading();
                    this.IsBusy = false;
                    //await UserDialogs.Instance.ConfirmAsync("El paciente se ha añadido correctamente", "Paciente añadido", "Aceptar");
                    bool confirmado = await UserDialogs.Instance.ConfirmAsync("El paciente se ha añadido correctamente, ¿quieres ir a su formulario?", "¡Añadido!", "Aceptar", "Cancelar");
                    if (confirmado)
                    {
                        await NavigationService.NavigateToAsync<FormularioViewModel>(result.Entity );
                    }
                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    Message = "Hay algún fallo de red inténtelo más tarde del tipo";
                    this.IsBusy = false;
                }
            }
            UserDialogs.Instance.HideLoading();
            Message = "Hay algún fallo de red inténtelo más tarde del tipo";
            this.IsBusy = false;
        }     
    }
}
