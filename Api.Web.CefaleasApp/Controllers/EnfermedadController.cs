using Microsoft.AspNetCore.Mvc;
using Pitasoft.Result;
using System.Threading.Tasks;
using CefaleasApp.DataAccess;
using CefaleasApp.Entities;

namespace Api.Web.CefaleasApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnfermedadController : ControllerBase
    {
        private readonly IEnfermedadRepository _enfermedadRepository;
        public EnfermedadController(IEnfermedadRepository enfermedadRepository) => _enfermedadRepository = enfermedadRepository;
        // GET api/<controller>
        [HttpGet("{IdEnfermedad}")]
        public Task<ResultEntity<Enfermedad>> GetEnfermedadAsync(int IdEnfermedad) => _enfermedadRepository.GetEnfermedadAsync(IdEnfermedad);

        // POST api/<controller>
        [HttpPost]
        public Task<ResultEntity<Enfermedad>> AddEnfermedadAsync(Enfermedad enfermedad) => _enfermedadRepository.AddEnfermedadAsync(enfermedad);

        //DELETE api/<controller>
        [HttpDelete("{IdEnfermedad}")]
        public Task<Result> DeleteEnfermedadAsync(int IdEnfermedad) => _enfermedadRepository.DeleteEnfermedadAsync(IdEnfermedad);

        //PUT api/<controller>
        [HttpPut]
        public Task<ResultEntity<Enfermedad>> UpdateEnfermedadAsync(Enfermedad enfermedad) => _enfermedadRepository.UpdateEnfermedadAsync(enfermedad);
    }
}
