using Microsoft.AspNetCore.Mvc;
using Pitasoft.Result;
using System.Threading.Tasks;
using CefaleasApp.DataAccess;
using CefaleasApp.Entities;

namespace Api.Web.CefaleasApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository) => _usuarioRepository = usuarioRepository;

        // GET api/<controller>
        [HttpGet]
        public Task<ResultEntities<Usuario>> GetUsuariosAsync() => _usuarioRepository.GetUsuariosAsync();

        [HttpGet("{id}")]
        public Task<ResultEntity<Usuario>> GetUsuarioAsync(int id) => _usuarioRepository.GetUsuarioAsync(id);

        // POST api/<controller>
        [HttpPost]
        public Task<ResultEntity<Usuario>> AddUsuarioAsync(Usuario usuario) => _usuarioRepository.AddUsuarioAsync(usuario);

        //DELETE api/<controller>
        [HttpDelete("{UsuarioId}")]
        public Task<Result> DeleteUsuarioAsync(int UsuarioId) => _usuarioRepository.DeleteUsuarioAsync(UsuarioId);

        //PUT api/<controller>
        [HttpPut]
        public Task<ResultEntity<Usuario>> UpdateUsuarioAsync(Usuario usuario) => _usuarioRepository.UpdateUsuarioAsync(usuario);
    }
}
