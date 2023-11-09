using Pitasoft.Client;
using CefaleasApp.DataAccess;
using CefaleasApp.Entities;

namespace CefaleasApp.Services.Interfaces
{
    public interface IPacienteRestService : IRestService, IPacienteRepository
    {
        Paciente paciente { get; set; }

    }
}
