using Pitasoft.Client;
using Pitasoft.Result;
using System;
using System.Threading.Tasks;
using CefaleasApp.Entities;
using CefaleasApp.Services.Interfaces;

namespace CefaleasApp.Services
{
    public class EnfermedadRestService : RestServiceBase, IEnfermedadRestService
    {
        public EnfermedadRestService(string uriString) : base(uriString) { }
        //POST
        public Task<ResultEntity<Enfermedad>> AddEnfermedadAsync(Enfermedad enfermedad) => PostAsync("/api/Enfermedad", enfermedad);
        //DELETE
        public Task<Result> DeleteEnfermedadAsync(int IdEnfermedad) => DeleteAsync($"/api/Enfermedad/{IdEnfermedad}");
        //GET
        public Task<ResultEntity<Enfermedad>> GetEnfermedadAsync(int IdEnfermedad) => GetAsync<Enfermedad>($"/api/Enfermedad/{IdEnfermedad}");
        //PUT
        public Task<ResultEntity<Enfermedad>> UpdateEnfermedadAsync(Enfermedad enfermedad) => PutAsync("/api/Enfermedad", enfermedad);

        protected override void OnUnauthorized(ResultBase result)
        {
            //result.Status = StatusResult.OK;
            throw new NotImplementedException();

        }

    }
}
