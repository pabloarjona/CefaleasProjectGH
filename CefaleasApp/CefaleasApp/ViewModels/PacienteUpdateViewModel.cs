using Acr.UserDialogs;
using Pitasoft.Commands;
using Pitasoft.Result;
using Pitasoft.Result.Extensions;
using Pitasoft.Shell;
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
    public class PacienteUpdateViewModel : PageValidatableBase, IPaciente
    {
        public Paciente Paciente { get; private set; }

        private readonly CefaleasRestService _restService;
        [Validate(Type = ValidateType.Skip)]

        public ICommand CancelCommand { get; }
        public ICommand SaveCommand { get; }
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
        public PacienteUpdateViewModel(CefaleasRestService restService) : base()
        {
            _restService = restService;
            SaveCommand = new DelegateCommand(() => DoTask(SaveCommandExecute()));
            CancelCommand = new DelegateCommand(() => DoAction(CancelCommandExecute));
            _ = new ObjectValidator(this);

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
                    if (Sexo == '\0')
                    {
                        SetError("Este campo es obligatorio.", nameof(Sexo));
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
                            if (!c.Equals('.') && !Char.IsLetter(c))
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
        
        private void CancelCommandExecute()=> CopyPaciente(Paciente, this);
              
        //Al iniciarse esta interfaz se ejecutara este método para que el usuario puede ver los atributos del paciente
        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Paciente paciente)
            { 
                Title = paciente.Iniciales;
                CopyPaciente((this.Paciente = paciente), this);
            }
            return base.InitializeAsync(navigationData);
        }
        private IPaciente CopyPaciente(IPaciente origen, IPaciente destino)
        {
            destino.Iniciales = origen.Iniciales;
            destino.FechaConsulta = origen.FechaConsulta;
            destino.Edad = origen.Edad;
            destino.Sexo = origen.Sexo;
            return destino;
        }
        private async Task SaveCommandExecute()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            if (Validate())
            {
                Paciente pacienteNew = CopyPaciente(this, new Paciente
                {
                    IdPaciente = this.Paciente.IdPaciente,
                    IdUsuario = this.Paciente.IdUsuario
                }) as Paciente;
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
    }
}
