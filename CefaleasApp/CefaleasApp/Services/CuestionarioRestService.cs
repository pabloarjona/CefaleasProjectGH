using Pitasoft.Client;
using Pitasoft.Result;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using CefaleasApp.Entities;
using CefaleasApp.Services.Interfaces;

namespace CefaleasApp.Services
{
    public class CuestionarioRestService : RestServiceBase, ICuestionarioRestService
    {
        public CuestionarioRestService(string uriString) : base(uriString) { }
        //POST
        public Task<ResultEntity<Cuestionario>> AddCuestionarioAsync(Cuestionario cuestionario) => PostAsync("/api/Cuestionario", cuestionario);
        //DELETE
        public Task<Result> DeleteCuestionarioAsync(int IdCuestionario) => DeleteAsync($"/api/Cuestionario/{IdCuestionario}");
        //GET
        public Task<ResultEntity<Cuestionario>> GetCuestionariosAsync(int IdPaciente) => GetAsync<Cuestionario>($"/api/Cuestionario/{IdPaciente}");
        //PUT
        public Task<ResultEntity<Cuestionario>> UpdateCuestionarioAsync(Cuestionario cuestionario) => PutAsync("/api/Cuestionario", cuestionario);

        protected override void OnUnauthorized(ResultBase result)
        {
            throw new NotImplementedException();
        }

    }
}
