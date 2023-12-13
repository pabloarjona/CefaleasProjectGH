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
using Xamarin.Forms;

namespace CefaleasApp.ViewModels
{
    public class PacienteDetailViewModel : PageValidatableBase, IPaciente
    {
        private readonly CefaleasRestService _restService;
        private bool addMode = true;
        private int IdUsuario { get; set; }
        private int IdPaciente { get; set; }
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

        private string _edadString;
        [Required(ErrorMessage = "Tiene que especificar la edad del paciente")]
        public string EdadString
        {
            get => _edadString;
            set => SetProperty(ref _edadString, value);
        }
        public short Edad { get; set; }

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
        public PacienteDetailViewModel(CefaleasRestService restService) : base()
        {
            _restService = restService;
            AddPacienteCommand = new DelegateCommand(() => DoTask(SavePacienteCommandExecute()))
                .ObservesProperty(() => FechaConsulta)
                .ObservesProperty(() => Edad)
                .ObservesProperty(() => Sexo)
                .ObservesProperty(() => Iniciales); 
            _ = new ObjectValidator(this);
        }

        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is int idUsuario)
            {
                Title = "Añadir paciente";
                this.IdUsuario = idUsuario;
                this.Iniciales = string.Empty;
                this.FechaConsulta = DateTime.Today;
                this.EdadString = string.Empty;
                this.Sexo = 'F';
                addMode = true;
            }
            else if(navigationData is Paciente paciente)
            {
                Title = paciente.Iniciales;
                this.IdPaciente = paciente.IdPaciente;
                this.IdUsuario = paciente.IdUsuario;
                this.Iniciales = paciente.Iniciales;
                this.FechaConsulta = paciente.FechaConsulta;
                this.Sexo = paciente.Sexo;
                this.EdadString = paciente.Edad.ToString();
                addMode = false;
            }
            return base.InitializeAsync(navigationData);
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
                case nameof(EdadString):
                    short result;
                   if(!short.TryParse(EdadString, out result))
                    {
                        SetError("Tiene que insertar un valor numérico", nameof(EdadString));
                    }
                    else
                    {
                        Edad = result;
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
                default:
                    break;
            }
            base.OnValidatedProperty(args);
        }
        private async Task UpdateCommandExecute()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            if (Validate())
            {
                Paciente pacienteNew = new Paciente
                {
                    Iniciales= this.Iniciales,
                    Edad= this.Edad,
                    Sexo= this.Sexo,
                    FechaConsulta= this.FechaConsulta,
                    IdPaciente = this.IdPaciente,
                    IdUsuario = this.IdUsuario
                };
                ResultEntity<Paciente> result = await _restService.UpdatePacienteAsync(pacienteNew);
                if (result.IsSuccess())
                {
                    UserDialogs.Instance.HideLoading();
                    await UserDialogs.Instance.ConfirmAsync("El paciente se ha modificado correctamente", "Paciente modificado", "Aceptar");
                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    Message = "Hay algún fallo de red inténtelo más tarde";
                }
            }
        }
        private async Task SavePacienteCommandExecute()
        {
            if (!addMode)
            {
                DoTask(UpdateCommandExecute());
            }
            else
            {
                if (this.IsBusy)
                    return;
                this.IsBusy = true;
                UserDialogs.Instance.ShowLoading("Cargando...");
                if (Validate())
                {
                    Paciente pacient = new Paciente(){IdUsuario = this.IdUsuario,Iniciales = this.Iniciales,FechaConsulta = this.FechaConsulta,Edad = this.Edad,Sexo = this.Sexo,};
                    ResultEntity<Paciente> result = await _restService.AddPacienteAsync(pacient);
                    if (result.IsSuccess())
                    {
                        UserDialogs.Instance.HideLoading();
                        this.IsBusy = false;
                        bool confirmado = await UserDialogs.Instance.ConfirmAsync("El paciente se ha añadido correctamente, ¿quieres ir a su formulario?", "¡Añadido!", "Aceptar", "Cancelar");
                        if (confirmado)
                        {
                            await NavigationService.NavigateToAsync<FormularioViewModel>(result.Entity);
                        }
                    }
                    else
                    {
                        UserDialogs.Instance.HideLoading();
                        Message = "Hay algún fallo de red inténtelo más tarde.";
                        this.IsBusy = false;
                    }
                }
                UserDialogs.Instance.HideLoading();
                Message = "Hay algún fallo de red inténtelo más tarde.";
                this.IsBusy = false;
            }
        }     
    }
}
