using Acr.UserDialogs;
using Pitasoft.Collections;
using Pitasoft.Commands;
using Pitasoft.Result;
using Pitasoft.Result.Extensions;
using Pitasoft.Shell.Xamarin.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using CefaleasApp.Entities;
using CefaleasApp.Models;
using CefaleasApp.Services.Interfaces;
using CefaleasApp.Services;

namespace CefaleasApp.ViewModels
{
    public class PacienteViewModel : PageBase
    {
        public static List<Paciente> Listapac { get; set; } = new List<Paciente>{};
        private readonly IXamarin1SettingsService _settingsService;
        private static ObservableCollection<Paciente> Pacientes { get; set; }
        private readonly CefaleasRestService _cefaleasRestService;
        private ObservableCollection<Paciente> _listaPacientes;
        public ObservableCollection<Paciente> ListaPacientes 
        {   get=>_listaPacientes;
            set => SetProperty(ref _listaPacientes, value);
        }
        private int _totalPacientes;
        public int TotalPacientes
        {
            get => _totalPacientes;
            set => SetProperty(ref _totalPacientes, value);
        }
        private Paciente _pacienteSelected;
        public Paciente PacienteSelected
        {
            get => _pacienteSelected;
            set => SetProperty(ref _pacienteSelected, value);
        }

        public static ObservableCollection<Paciente> GetSearchResults(string queryString)
        {
            var normalizedQuery = queryString?.ToLower() ?? "";
            Listapac= Listapac.Where(f => f.Iniciales.ToLowerInvariant().Contains(normalizedQuery)).ToList();
            var oc = new ObservableCollection<Paciente>();
            foreach (var item in Listapac)
                oc.Add(item);
            return oc;
        }
        public ICommand PerformSearch => new Command<string>((string query) =>
        {
            ListaPacientes.Clear();
            ListaPacientes = GetSearchResults(query);
        });
        public ICommand RefreshCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand SelectedCommand { get; }
        public ICommand AddFormCommand { get; }
        public PacienteViewModel(CefaleasRestService cefaleasRestService, IXamarin1SettingsService settingsService) : base()
        {
            _settingsService = settingsService;
            _cefaleasRestService = cefaleasRestService;
            ListaPacientes = new ObservableCollection<Paciente>();
            Title = "Pacientes";
            RefreshCommand = new DelegateCommand(() => DoTask(RefreshCommandAsync()));
            AddCommand = new DelegateCommand(() => DoTask(AddCommandExecute()));
            UpdateCommand = new DelegateCommand(() => DoTask(UpdateCommandExecute()), PacienteIsSelected).ObservesProperty(() => PacienteSelected);
            DeleteCommand = new DelegateCommand(() => DoTask(DeleteCommandExecuteAsync()), PacienteIsSelected).ObservesProperty(() => PacienteSelected);
            AddFormCommand = new DelegateCommand(() => DoTask(AddCommandFormExecute()), PacienteIsSelected).ObservesProperty(() => PacienteSelected);
        }

        public override Task InitializeAsync(object navigationData)
        {
            DoTask(RefreshCommandAsync());
            return base.InitializeAsync(navigationData);
        }
        private async Task RefreshCommandAsync()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            ResultEntities<Paciente> result = await _cefaleasRestService.GetPacientesAsyncId(_settingsService.Usuario.IdUsuario);
            if (result.IsSuccess())
            {
                if (result.Entities.Count() != 0)
                {
                    DoAction(() =>
                    {
                        Listapac.Clear();
                        Listapac.AddRange(result.Entities);
                        ListaPacientes.Clear();
                        ListaPacientes.AddRange(result.Entities);
                    });
                    this.TotalPacientes = ListaPacientes.Count;
                    UserDialogs.Instance.HideLoading();
                }
                else
                {
                    ListaPacientes.Clear();
                    Listapac.Clear();                    
                    UserDialogs.Instance.HideLoading();
                }
            }
            else
            {
                UserDialogs.Instance.HideLoading();
                await DialogService.ShowAlertAsync("Error", "Ha habido un error de conexión de red intentelo más tarde", "Aceptar");

            }
        }
        private Task AddCommandFormExecute()=> NavigationService.NavigateToAsync<FormularioViewModel>(PacienteSelected);
        
        private Task AddCommandExecute() => NavigationService.NavigateToAsync<PacienteAddViewModel>();
        private Task UpdateCommandExecute() => NavigationService.NavigateToAsync<PacienteUpdateViewModel>(PacienteSelected);
        private async Task DeleteCommandExecuteAsync()
        {
            UserDialogs.Instance.ShowLoading("Cargando...");
            Result result = await _cefaleasRestService.DeletePacienteAsync(PacienteSelected.IdPaciente);
            if (result.IsSuccess())
            {
                UserDialogs.Instance.HideLoading();
                await RefreshCommandAsync();
                await DialogService.ShowAlertAsync("Paciente eliminado correctamente", "¡Eliminado!", "Aceptar");
            }
            else
            {
                UserDialogs.Instance.HideLoading();
                await DialogService.ShowAlertAsync("Ha habido un error de conexión de red, inténtelo más tarde","Error", "Aceptar");
            }
        }
        private bool PacienteIsSelected() => PacienteSelected != null;
    }
}
