using Pitasoft.Client;
using Pitasoft.Result;
using System;
using System.Threading.Tasks;
using CefaleasApp.Entities;
using CefaleasApp.Services.Interfaces;

namespace CefaleasApp.Services
{
    public class PacienteRestService : RestServiceBase, IPacienteRestService
    {
        public PacienteRestService(string uriString) : base(uriString){}
        public Paciente paciente { get; set; }

        //POST
        public Task<ResultEntity<Paciente>> AddPacienteAsync(Paciente paciente) => PostAsync("/api/Paciente", paciente);
        //DELETE
        public Task<Result> DeletePacienteAsync(int IdPaciente) => DeleteAsync($"/api/Paciente/{IdPaciente}");
        //GET
        public Task<ResultEntities<Paciente>> GetPacientesAsync() => GetsAsync<Paciente>("/api/Paciente");
        //GET
        public Task<ResultEntities<Paciente>> GetPacientesAsyncId(int IdUsuario) => GetsAsync<Paciente>($"/api/Paciente/{IdUsuario}");
        //PUT
        public Task<ResultEntity<Paciente>> UpdatePacienteAsync(Paciente paciente) => PutAsync("/api/Paciente", paciente);

        protected override void OnUnauthorized(ResultBase result)
        {
            //result.Status = StatusResult.OK;
            throw new NotImplementedException();

        }

    }
}
