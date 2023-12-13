using Acr.UserDialogs;
using Pitasoft.Commands;
using Pitasoft.Result;
using Pitasoft.Result.Extensions;
using Pitasoft.Shell;
using Pitasoft.Shell.Xamarin.Services;
using System.Threading.Tasks;
using System.Windows.Input;
using CefaleasApp.Entities;
using CefaleasApp.Entities.Interfaces;
using CefaleasApp.Models;
using CefaleasApp.Services.Interfaces;
using CefaleasApp.Services;

namespace CefaleasApp.ViewModels
{
    public class FormularioViewModel : PageBase, ICuestionario
    {
        bool newForm = true;
        bool validar = false;
        private int? _idEnfermedadVerificada;
        public Paciente _paciente { get; set; }
        private readonly CefaleasRestService _cefaleasRestService;
        private readonly IDialogService _dialogService;
        private readonly INavigationService _navigationService;
        private readonly ICriteriosCefalea _criteriosCefalea;
        #region
        private string _episodios;
        public string Episodios
        {
            get => _episodios;
            set => SetProperty(ref _episodios, value);
        }
        public string _duracion;
        public string Duracion
        {
            get => _duracion;
            set => SetProperty(ref _duracion, value);
        }
        public string _duracion_episodio;
        public string Duracion_episodio
        {
            get => _duracion_episodio;
            set => SetProperty(ref _duracion_episodio, value);
        }
        public string _localizacion;
        public string Localizacion
        {
            get => _localizacion;
            set => SetProperty(ref _localizacion, value);
        }
        public string _dolor;
        public string Dolor
        {
            get => _dolor;
            set => SetProperty(ref _dolor, value);
        }
        public string _intensidad;
        public string Intensidad
        {
            get => _intensidad;
            set => SetProperty(ref _intensidad, value);
        }
        public string _actividad_fisica;
        public string Actividad_fisica
        {
            get => _actividad_fisica;
            set => SetProperty(ref _actividad_fisica, value);
        }
        public string _nauseas;
        public string Nauseas
        {
            get => _nauseas;
            set => SetProperty(ref _nauseas, value);
        }
        public string _vomitos;
        public string Vomitos
        {
            get => _vomitos;
            set => SetProperty(ref _vomitos, value);
        }
        public string _fotofobia;
        public string Fotofobia
        {
            get => _fotofobia;
            set => SetProperty(ref _fotofobia, value);
        }
        public string _fonofobia;
        public string Fonofobia
        {
            get => _fonofobia;
            set => SetProperty(ref _fonofobia, value);
        }
        public string _aura;
        public string Aura
        {
            get => _aura;
            set => SetProperty(ref _aura, value);
        }
        public string _ipsilaterales;
        public string Ipsilaterales
        {
            get => _ipsilaterales;
            set => SetProperty(ref _ipsilaterales, value);
        }
        public string _inquietud;
        public string Inquietud
        {
            get => _inquietud;
            set => SetProperty(ref _inquietud, value);
        }
        public string _trayectoria_lineal;
        public string Trayectoria_lineal
        {
            get => _trayectoria_lineal;
            set => SetProperty(ref _trayectoria_lineal, value);
        }
        public string _incio_brusco;
        public string Inicio_brusco
        {
            get => _incio_brusco;
            set => SetProperty(ref _incio_brusco, value);
        }
        public string _indometacina;
        public string Indometacina
        {
            get => _indometacina;
            set => SetProperty(ref _indometacina, value);
        }
        public string _triptan_ergotico;
        public string Triptan_ergotico
        {
            get => _triptan_ergotico;
            set => SetProperty(ref _triptan_ergotico, value);
        }
        public string _tos;
        public string Tos
        {
            get => _tos;
            set => SetProperty(ref _tos, value);
        }
        public string _esfuerzo_brusco;
        public string Esfuerzo_brusco
        {
            get => _esfuerzo_brusco;
            set => SetProperty(ref _esfuerzo_brusco, value);
        }
        public string _valsalva;
        public string Valsalva
        {
            get => _valsalva;
            set => SetProperty(ref _valsalva, value);
        }
        public string _actividad_sexual;
        public string Actividad_sexual
        {
            get => _actividad_sexual;
            set => SetProperty(ref _actividad_sexual, value);
        }
        public string _sueño;
        public string Sueño
        {
            get => _sueño;
            set => SetProperty(ref _sueño, value);
        }
        public string _inicio_inconfundible;
        public string Inicio_inconfundible
        {
            get => _inicio_inconfundible;
            set => SetProperty(ref _inicio_inconfundible, value);
        }
        public bool Verificado { get; set; }
        #endregion
        public ICommand SaveCommand { get; }
        public ICommand RefreshCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand VerDiagnostico { get; }
        public FormularioViewModel(ICriteriosCefalea criteriosCefalea, CefaleasRestService cefaleasRestSerice, IDialogService dialogService, INavigationService navigationService) : base()
        {
            RefreshCommand = new DelegateCommand(() => DoTask(RefreshCommandAsync()));
            DeleteCommand = new DelegateCommand(() => DoTask(DeleteCommandAsync()));
            VerDiagnostico = new DelegateCommand(() => DoTask(VerDiagnosticoAsync()));
            SaveCommand = new DelegateCommand(() => DoTask(SaveCommandAsync()));
            _cefaleasRestService = cefaleasRestSerice;
            _dialogService = dialogService;
            _navigationService = navigationService;
            _criteriosCefalea = criteriosCefalea;
        }
        private async Task VerDiagnosticoAsync()=> await SaveCommandAsync();
        private async Task DeleteCommandAsync()
        {
            bool confirmado = await UserDialogs.Instance.ConfirmAsync("Seguro que quiere eliminar este cuestionario, se perderán todos los datos de él.", "Eliminar cuestionario", "Aceptar", "Cancelar");
            if (confirmado)
            {
                UserDialogs.Instance.ShowLoading("Cargando...");
                Result result = await _cefaleasRestService.DeleteCuestionarioAsync(_paciente.IdPaciente);
                if (result.IsOk())
                {
                    DoTask(RefreshCommandAsync());
                    UserDialogs.Instance.HideLoading();
                    await _dialogService.ShowAlertAsync("Cuestionario eliminado correctamente", "¡Eliminado!", "Aceptar");
                    await _navigationService.NavigateToAsync<PacienteViewModel>();
                    Cuestionario cuestionarionew = new Cuestionario();
                    CopyCuestionario(cuestionarionew, this);
                }
                else
                    UserDialogs.Instance.HideLoading();
            }

        }
        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Paciente paciente)
            {
                Title = "Formulario de: " + paciente.Iniciales;
                _paciente = paciente;
                if (_paciente.Cuestionario != null)
                {
                    this.newForm = false;
                    DoTask(RefreshCommandAsync());
                }
            }
            return base.InitializeAsync(navigationData);
        }
        public async Task RefreshCommandAsync()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            ResultEntity<Cuestionario> result = await _cefaleasRestService.GetCuestionariosAsync(_paciente.IdPaciente);
            if (result.IsSuccess())
            {
                this._idEnfermedadVerificada = result.Entity.IdEnfermedadVerificada;
                DoAction(() =>
                {
                    CopyCuestionario(result.Entity, this);
                });
                UserDialogs.Instance.HideLoading();
            }
            else
            {
                await _dialogService.ShowAlertAsync("No se ha mostrado el formulario por un error de conexión de red", "Error", "Aceptar");

            }
            UserDialogs.Instance.HideLoading();
        }
        private async Task SaveCommandAsync()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            Cuestionario cuestionario = CopyCuestionario(this, new Cuestionario
            {
                IdPaciente = _paciente.IdPaciente
            }) as Cuestionario;
            if (this.validar)
            {
                if (this.newForm)
                {
                    cuestionario.IdEnfermedad = _criteriosCefalea.ComprobarCefalea(cuestionario);
                    ResultEntity<Cuestionario> result = await _cefaleasRestService.AddCuestionarioAsync(cuestionario);
                    if (result.IsSuccess())
                    {
                        this.newForm = false;
                        UserDialogs.Instance.HideLoading();
                        bool confirmado = await UserDialogs.Instance.ConfirmAsync("El formulario se ha añadido correctamente, ¿quieres ver los resultados del formulario?", "¡Añadido!", "Aceptar", "Cancelar");
                        if (confirmado)
                        {
                            await _navigationService.NavigateToAsync<DiagnosticoViewModel>(_paciente);
                        }
                    }
                    else
                    {
                        UserDialogs.Instance.HideLoading();
                        await _dialogService.ShowAlertAsync("No se ha podido añadir el formulario por un error de conexión de red", "Error", "Aceptar");
                    }
                }
                else
                {
                    cuestionario.IdEnfermedadVerificada = this._idEnfermedadVerificada;
                    cuestionario.IdEnfermedad = _criteriosCefalea.ComprobarCefalea(cuestionario);
                    ResultEntity<Cuestionario> result2 = await _cefaleasRestService.UpdateCuestionarioAsync(cuestionario);
                    if (result2.IsSuccess())
                    {

                        UserDialogs.Instance.HideLoading();
                        bool confirmado = await UserDialogs.Instance.ConfirmAsync("El formulario se ha modificado correctamente, ¿quieres ver los resultados del formulario?", "¡Modificado!", "Aceptar", "Cancelar");
                        if (confirmado)
                            await _navigationService.NavigateToAsync<DiagnosticoViewModel>(_paciente);
                    }
                    else
                    {
                        UserDialogs.Instance.HideLoading();
                        await _dialogService.ShowAlertAsync("No se ha podido añadir el formulario por un error de conexión red", "Error", "Aceptar");
                    }
                }
            }
            else
            {
                await _dialogService.ShowAlertAsync("Todas las preguntas entre la 1 y la 4.5 son obligatorias.", "Error", "Aceptar");
            }
        }

        private ICuestionario CopyCuestionario(ICuestionario origen, ICuestionario destino)
        {
            short cont = 0;
            destino.Episodios = origen.Episodios;
            if (destino.Episodios != null) cont++;
            destino.Duracion = origen.Duracion;
            if (destino.Duracion != null) cont++;
            destino.Duracion_episodio = origen.Duracion_episodio;
            if (destino.Duracion_episodio != null) cont++;
            destino.Localizacion = origen.Localizacion;
            if (destino.Localizacion != null) cont++;
            destino.Dolor = origen.Dolor;
            if (destino.Dolor != null) cont++;
            destino.Intensidad = origen.Intensidad;
            if (destino.Intensidad != null) cont++;
            destino.Actividad_fisica = origen.Actividad_fisica;
            if (destino.Actividad_fisica != null) cont++;
            destino.Nauseas = origen.Nauseas;
            if (destino.Nauseas != null) cont++;
            destino.Vomitos = origen.Vomitos;
            if (destino.Vomitos != null) cont++;
            destino.Fotofobia = origen.Fotofobia;
            if (destino.Fotofobia != null) cont++;
            destino.Fonofobia = origen.Fonofobia;
            if (destino.Fonofobia != null) cont++;
            destino.Aura = origen.Aura;
            if (destino.Aura != null) cont++;
            destino.Ipsilaterales = origen.Ipsilaterales;
            if(destino.Ipsilaterales != null) cont++;
            destino.Inquietud = origen.Inquietud;
            if(destino.Inquietud != null) cont++; 
            destino.Trayectoria_lineal = origen.Trayectoria_lineal;
            if(destino.Trayectoria_lineal != null) cont++;
            destino.Inicio_brusco = origen.Inicio_brusco;
            destino.Indometacina = origen.Indometacina;
            destino.Triptan_ergotico = origen.Triptan_ergotico;
            destino.Tos = origen.Tos;
            destino.Esfuerzo_brusco = origen.Esfuerzo_brusco;
            destino.Valsalva = origen.Valsalva;
            destino.Actividad_sexual = origen.Actividad_sexual;
            destino.Sueño = origen.Sueño;
            destino.Inicio_inconfundible = origen.Inicio_inconfundible;
            destino.Verificado = origen.Verificado;
            if (cont == 15)
                validar = true;
            else
                validar = false;
            return destino;
        }

    }
}
