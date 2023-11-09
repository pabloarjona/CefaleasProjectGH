using Pitasoft.Client;
using Pitasoft.Result;
using System;
using System.Threading.Tasks;
using CefaleasApp.Entities;
using CefaleasApp.Services.Interfaces;

namespace CefaleasApp.Services
{

    public class UsuarioRestService : RestServiceBase, IUsuarioRestService
    {
        public UsuarioRestService(string UriString) : base(UriString) {}
        public Usuario usuario { get; set; }

        //POST
        public Task<ResultEntity<Usuario>> AddUsuarioAsync(Entities.Usuario usuario) => PostAsync("/api/Usuario", usuario);
        //DELETE
        public Task<Result> DeleteUsuarioAsync(int UsuarioId) => DeleteAsync($"/api/Usuario/{UsuarioId}");
        //GET
        public Task<ResultEntities<Entities.Usuario>> GetUsuariosAsync() => GetsAsync<Entities.Usuario>("/api/Usuario");
        //PUT
        public Task<ResultEntity<Entities.Usuario>> UpdateUsuarioAsync(Entities.Usuario usuario) => PutAsync("/api/Usuario", usuario);

        protected override void OnUnauthorized(ResultBase result)
        {
            //result.Status = StatusResult.OK;
            throw new NotImplementedException();

        }
    }
}
