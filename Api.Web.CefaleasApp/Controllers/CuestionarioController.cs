using Microsoft.AspNetCore.Mvc;
using Pitasoft.Result;
using System.Threading.Tasks;
using CefaleasApp.DataAccess;
using CefaleasApp.Entities;

namespace Api.Web.CefaleasApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CuestionarioController : ControllerBase
    {
        private readonly ICuestionarioRepository _cuestionarioRepository;
        public CuestionarioController(ICuestionarioRepository cuestionarioRepository) => _cuestionarioRepository = cuestionarioRepository;
        // GET api/<controller>
        [HttpGet("{IdPaciente}")]
        public Task<ResultEntity<Cuestionario>> GetCuestionariosAsync(int IdPaciente) => _cuestionarioRepository.GetCuestionariosAsync(IdPaciente);

        // POST api/<controller>
        [HttpPost]
        public Task<ResultEntity<Cuestionario>> AddCuestionarioAsync(Cuestionario cuestionario) => _cuestionarioRepository.AddCuestionarioAsync(cuestionario);

        //DELETE api/<controller>
        [HttpDelete("{IdCuestionario}")]
        public Task<Result> DeleteCuestionarioAsync(int IdCuestionario) => _cuestionarioRepository.DeleteCuestionarioAsync(IdCuestionario);

        //PUT api/<controller>
        [HttpPut]
        public Task<ResultEntity<Cuestionario>> UpdateCuestionarioAsync(Cuestionario cuestionario) => _cuestionarioRepository.UpdateCuestionarioAsync(cuestionario);
    }
}
