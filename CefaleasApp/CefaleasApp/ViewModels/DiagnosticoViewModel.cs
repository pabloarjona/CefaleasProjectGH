using CefaleasApp.Entities;
using CefaleasApp.Entities.Interfaces;
using Pitasoft.Commands;
using Pitasoft.Result;
using Pitasoft.Result.Extensions;
using Pitasoft.Shell.Xamarin.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using CefaleasApp.Services.Interfaces;

namespace CefaleasApp.ViewModels
{
    public class DiagnosticoViewModel : PageBase, ICuestionario, IEnfermedad
    {
        private readonly IEnfermedadRestService _enfermedadRestService;
        private readonly ICuestionarioRestService _cuestionarioRestService;
        public Paciente _paciente { get; set; }
        public Cuestionario _cuestionario { get; set; }
        public int? _idCuestionarioVerificado;

        #region
        public bool _verificado;
        public bool Verificado
        {
            get => _verificado;
            set => SetProperty(ref _verificado, value);
        }
        public int? _selectedEnfermedadVerificada;
        public int? SelectedEnfermedadVerificada
        {
            get => _selectedEnfermedadVerificada;
            set => SetProperty(ref _selectedEnfermedadVerificada, value);
        }
        private string _nombre;
        public string Nombre_Enfermedad
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }
        public string _tratamiento;
        public string Tratamiento
        {
            get => _tratamiento;
            set => SetProperty(ref _tratamiento, value);
        }
        public string _iniciales;
        public string Iniciales
        {
            get => _iniciales;
            set => SetProperty(ref _iniciales, value);
        }
        public bool _episodiosVisible;
        public bool EpisodiosVisible
        {
            get => _episodiosVisible;
            set => SetProperty(ref _episodiosVisible, Episodios != null);
        }
        public string _episodios;
        public string Episodios
        {
            get => _episodios;
            set => SetProperty(ref _episodios, value);
        }

        public bool _duracionVisible;
        public bool DuracionVisible
        {
            get => _duracionVisible;
            set => SetProperty(ref _duracionVisible, Duracion != null);
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
        public bool _duracionEpisodioVisible;
        public bool Duracion_EpisodioVisible
        {
            get => _duracionEpisodioVisible;
            set => SetProperty(ref _duracionEpisodioVisible, Duracion_episodio != null);
        }
        public string _localizacion;
        public string Localizacion
        {
            get => _localizacion;
            set => SetProperty(ref _localizacion, value);
        }
        public bool _localizacionVisible;
        public bool LocalizacionVisible
        {
            get => Localizacion != null;
            set => SetProperty(ref _localizacionVisible, value);
        }
        public string _dolor;
        public string Dolor
        {
            get => _dolor;
            set => SetProperty(ref _dolor, value);
        }
        public bool _dolorVisible;
        public bool DolorVisible
        {
            get => _dolorVisible;
            set => SetProperty(ref _dolorVisible, Dolor != null);
        }
        public string _intensidad;
        public string Intensidad
        {
            get => _intensidad;
            set => SetProperty(ref _intensidad, value);
        }
        public bool _intensidadVisible;
        public bool IntensidadVisible
        {
            get => _intensidadVisible;
            set => SetProperty(ref _intensidadVisible, Intensidad != null);
        }
        public string _actividad_fisica;
        public string Actividad_fisica
        {
            get => _actividad_fisica;
            set => SetProperty(ref _actividad_fisica, value);
        }
        public bool _actividadVisible;
        public bool ActividadVisible
        {
            get => _actividadVisible;
            set => SetProperty(ref _actividadVisible, Actividad_fisica != null);
        }
        public string _nauseas;
        public string Nauseas
        {
            get => _nauseas;
            set => SetProperty(ref _nauseas, value);
        }
        public bool _nauseasVisible;
        public bool NauseasVisible
        {
            get => _nauseasVisible;
            set => SetProperty(ref _nauseasVisible, Nauseas != null);
        }
        public string _vomitos;
        public string Vomitos
        {
            get => _vomitos;
            set => SetProperty(ref _vomitos, value);
        }
        public bool _vomitosVisible;
        public bool VomitosVisible
        {
            get => _vomitosVisible;
            set => SetProperty(ref _vomitosVisible, Vomitos != null);
        }
        public string _fotofobia;
        public string Fotofobia
        {
            get => _fotofobia;
            set => SetProperty(ref _fotofobia, value);
        }
        public bool _fotofobiaVisible;
        public bool FotofobiaVisible
        {
            get => _fotofobiaVisible;
            set => SetProperty(ref _fotofobiaVisible, Fotofobia != null);
        }
        public string _fonofobia;
        public string Fonofobia
        {
            get => _fonofobia;
            set => SetProperty(ref _fonofobia, value);
        }

        public bool _fonofobiaVisible;
        public bool FonofobiaVisible
        {
            get => _fonofobiaVisible;
            set => SetProperty(ref _fonofobiaVisible, Fonofobia != null);
        }
        public string _aura;
        public string Aura
        {
            get => _aura;
            set => SetProperty(ref _aura, value);
        }

        public bool _auraVisible;
        public bool AuraVisible
        {
            get => _auraVisible;
            set => SetProperty(ref _auraVisible, Aura != null);
        }

        public string _ipsilaterales;
        public string Ipsilaterales
        {
            get => _ipsilaterales;
            set => SetProperty(ref _ipsilaterales, value);
        }
        public bool _ipsilateralesVisible;
        public bool IpsilateralesVisible
        {
            get => _ipsilateralesVisible;
            set => SetProperty(ref _ipsilateralesVisible, Ipsilaterales != null);
        }

        public string _inquietud;
        public string Inquietud
        {
            get => _inquietud;
            set => SetProperty(ref _inquietud, value);
        }
        public bool _inquietudVisible;
        public bool InquietudVisible
        {
            get => _inquietudVisible;
            set => SetProperty(ref _inquietudVisible, Inquietud != null);
        }
        public string _trayectoria_lineal;
        public string Trayectoria_lineal
        {
            get => _trayectoria_lineal;
            set => SetProperty(ref _trayectoria_lineal, value);
        }
        public bool _trayectoriaVisible;
        public bool Trayectoria_linealVisible
        {
            get => _trayectoriaVisible;
            set => SetProperty(ref _trayectoriaVisible, Trayectoria_lineal != null);
        }
        public string _incio_brusco;
        public string Inicio_brusco
        {
            get => _incio_brusco;
            set => SetProperty(ref _incio_brusco, value);
        }
        public bool _inicio_bruscoVisible;
        public bool Inicio_bruscoVisible
        {
            get => _inicio_bruscoVisible;
            set => SetProperty(ref _inicio_bruscoVisible, Inicio_brusco != null);
        }
        public string _indometacina;
        public string Indometacina
        {
            get => _indometacina;
            set => SetProperty(ref _indometacina, value);
        }
        public bool _indometacinaVisible;
        public bool IndometacinaVisible
        {
            get => _indometacinaVisible;
            set => SetProperty(ref _indometacinaVisible, Indometacina != null);
        }
        public string _triptan_ergotico;
        public string Triptan_ergotico
        {
            get => _triptan_ergotico;
            set => SetProperty(ref _triptan_ergotico, value);
        }
        public bool _triptan_ergoticoVisible;
        public bool Triptan_ergoticoVisible
        {
            get => _triptan_ergoticoVisible;
            set => SetProperty(ref _triptan_ergoticoVisible, Triptan_ergotico != null);
        }
        public string _tos;
        public string Tos
        {
            get => _tos;
            set => SetProperty(ref _tos, value);
        }
        public bool _tosVisible;
        public bool TosVisible
        {
            get => _tosVisible;
            set => SetProperty(ref _tosVisible, Tos != null);
        }
        public string _esfuerzo_brusco;
        public string Esfuerzo_brusco
        {
            get => _esfuerzo_brusco;
            set => SetProperty(ref _esfuerzo_brusco, value);
        }
        public bool _esfuerzo_bruscoVisible;
        public bool Esfuerzo_bruscoVisible
        {
            get => _esfuerzo_bruscoVisible;
            set => SetProperty(ref _esfuerzo_bruscoVisible, Esfuerzo_brusco != null);
        }
        public string _valsalva;
        public string Valsalva
        {
            get => _valsalva;
            set => SetProperty(ref _valsalva, value);
        }
        public bool _valsalvaVisible;
        public bool ValsalvaVisible
        {
            get => _valsalvaVisible;
            set => SetProperty(ref _valsalvaVisible, Valsalva != null);
        }
        public string _actividad_sexual;
        public string Actividad_sexual
        {
            get => _actividad_sexual;
            set => SetProperty(ref _actividad_sexual, value);
        }
        public bool _actividad_sexualVisible;
        public bool Actividad_sexualVisible
        {
            get => _actividad_sexualVisible;
            set => SetProperty(ref _actividad_sexualVisible, Actividad_sexual != null);
        }
        public string _sueño;
        public string Sueño
        {
            get => _sueño;
            set => SetProperty(ref _sueño, value);
        }
        public bool _sueñoVisible;
        public bool SueñoVisible
        {
            get => _sueñoVisible;
            set => SetProperty(ref _sueñoVisible, Sueño != null);
        }
        public string _inicio_inconfundible;
        public string Inicio_inconfundible
        {
            get => _inicio_inconfundible;
            set => SetProperty(ref _inicio_inconfundible, value);
        }
        public bool _incofundibleVisible;
        public bool Inicio_inconfundibleVisible
        {
            get => _incofundibleVisible;
            set => SetProperty(ref _incofundibleVisible, Inicio_inconfundible != null);
        }
        #endregion
        public ICommand EditCommand { get; }

        public DiagnosticoViewModel(ICuestionarioRestService cuestionarioRestService, IEnfermedadRestService enfermedadRestService) : base()
        {
            EditCommand = new DelegateCommand(() => DoTask(EditCommandAsync()));
            _cuestionarioRestService = cuestionarioRestService;
            _enfermedadRestService = enfermedadRestService;
        }
        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Paciente paciente)
            {
                _paciente = paciente;
                Title = "Diagnóstico de " + this._paciente.Iniciales;
                Iniciales = _paciente.Iniciales;
            }
            DoTask(RefreshCuestionario());
            return base.InitializeAsync(navigationData);
        }
        public async Task EditCommandAsync()
        {
            if (this.Verificado)
            {
                ResultEntity<Cuestionario> resultModel = await _cuestionarioRestService.GetCuestionariosAsync(_paciente.IdPaciente);
                if (resultModel.IsSuccess())
                {
                    this._idCuestionarioVerificado = this.SelectedEnfermedadVerificada + 1;
                    Cuestionario cuestionarioNew = CopyCuestionario(this, new Cuestionario
                    {
                        IdPaciente = _paciente.IdPaciente,
                        IdEnfermedad = _cuestionario.IdEnfermedad,
                        IdEnfermedadVerificada = this._idCuestionarioVerificado
                    }) as Cuestionario;
                    ResultEntity<Cuestionario> result = await _cuestionarioRestService.UpdateCuestionarioAsync(cuestionarioNew);
                    if (result.IsSuccess())
                    {
                        await DialogService.ShowAlertAsync("Verificado correctamente", "Verificado", "Aceptar");
                        await NavigationService.NavigateToAsync<PacienteViewModel>();
                    }
                    else
                        await DialogService.ShowAlertAsync("Error de conexión de internet", "Error", "Aceptar");
                }
                else
                    await DialogService.ShowAlertAsync("Error de conexión de internet", "Error", "Aceptar");
            }
            else
            {
                await DialogService.ShowAlertAsync("Tienes que marcar como verificado por médico", "¡Falta verificarlo!", "Aceptar");
            }
            
        }
        public async Task RefreshCuestionario()
        {
            ResultEntity<Cuestionario> result = await _cuestionarioRestService.GetCuestionariosAsync(_paciente.IdPaciente);
            if (result.IsSuccess())
            {
                _cuestionario = result.Entity;
                CopyCuestionario(result.Entity, this);
                this.SelectedEnfermedadVerificada = this._cuestionario.IdEnfermedadVerificada-1;
                ResultEntity<Enfermedad> result2 = await _enfermedadRestService.GetEnfermedadAsync(this._cuestionario.IdEnfermedad);
                Nombre_Enfermedad = result2.Entity.Nombre_Enfermedad;
                Tratamiento = result2.Entity.Tratamiento;
            }
            else
                await DialogService.ShowAlertAsync("Error de conexión de internet", "Error", "Aceptar");
        }

        private ICuestionario CopyCuestionario(ICuestionario origen, ICuestionario destino)
        {
            destino.Episodios = origen.Episodios;
            if (destino.Episodios != null)
                this.EpisodiosVisible = true;
            destino.Duracion = origen.Duracion;
            if (destino.Duracion != null)
                this.DuracionVisible = true;
            destino.Duracion_episodio = origen.Duracion_episodio;
            if (destino.Duracion_episodio != null)
                this.Duracion_EpisodioVisible = true;
            destino.Localizacion = origen.Localizacion;
            if (destino.Localizacion != null)
                this.LocalizacionVisible = true;
            destino.Dolor = origen.Dolor;
            if (destino.Dolor != null)
                this.DolorVisible = true;
            destino.Intensidad = origen.Intensidad;
            if (destino.Intensidad != null)
                this.IntensidadVisible = true;
            destino.Actividad_fisica = origen.Actividad_fisica;
            if (destino.Actividad_fisica != null)
                this.ActividadVisible = true;
            destino.Nauseas = origen.Nauseas;
            if (destino.Nauseas != null)
                this.NauseasVisible = true;
            destino.Vomitos = origen.Vomitos;
            if (destino.Vomitos != null)
                this.VomitosVisible = true;
            destino.Fotofobia = origen.Fotofobia;
            if (destino.Fotofobia != null)
                this.FotofobiaVisible = true;
            destino.Fonofobia = origen.Fonofobia;
            if (destino.Fonofobia != null)
                this.FonofobiaVisible = true;
            destino.Aura = origen.Aura;
            if (destino.Aura != null)
                this.AuraVisible = true;
            destino.Ipsilaterales = origen.Ipsilaterales;
            if (destino.Ipsilaterales != null)
                this.IpsilateralesVisible = true;
            destino.Inquietud = origen.Inquietud;
            if (destino.Inquietud != null)
                this.InquietudVisible = true;
            destino.Trayectoria_lineal = origen.Trayectoria_lineal;
            if (destino.Trayectoria_lineal != null)
                this.Trayectoria_linealVisible = true;
            destino.Inicio_brusco = origen.Inicio_brusco;
            if (destino.Inicio_brusco != null)
                this.Inicio_bruscoVisible = true;
            destino.Indometacina = origen.Indometacina;
            if (destino.Indometacina != null)
                this.IndometacinaVisible = true;
            destino.Triptan_ergotico = origen.Triptan_ergotico;
            if (destino.Triptan_ergotico != null)
                this.Triptan_ergoticoVisible = true;
            destino.Tos = origen.Tos;
            if (destino.Tos != null)
                this.TosVisible = true;
            destino.Esfuerzo_brusco = origen.Esfuerzo_brusco;
            if (destino.Esfuerzo_brusco != null)
                this.Esfuerzo_bruscoVisible = true;
            destino.Valsalva = origen.Valsalva;
            if (destino.Valsalva != null)
                this.ValsalvaVisible = true;
            destino.Actividad_sexual = origen.Actividad_sexual;
            if (destino.Actividad_sexual != null)
                this.Actividad_sexualVisible = true;
            destino.Sueño = origen.Sueño;
            if (destino.Sueño != null)
                this.SueñoVisible = true;
            destino.Inicio_inconfundible = origen.Inicio_inconfundible;
            if (destino.Inicio_inconfundible != null)
                this.Inicio_inconfundibleVisible = true;
            destino.Verificado = origen.Verificado;
            return destino;
        }
    }
}
