using Microsoft.AspNetCore.Mvc;
using Pitasoft.Result;
using System.Threading.Tasks;
using CefaleasApp.DataAccess;
using CefaleasApp.Entities;

namespace Api.Web.CefaleasApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;
        public PacienteController(IPacienteRepository pacienteRepository) => _pacienteRepository = pacienteRepository;
        // GET api/<controller>
        [HttpGet]
        public Task<ResultEntities<Paciente>> GetPacientesAsync() => _pacienteRepository.GetPacientesAsync();

        // GET api/<controller>
        [HttpGet("{IdUsuario}")]
        public Task<ResultEntities<Paciente>> GetPacientesAsyncId(int IdUsuario) => _pacienteRepository.GetPacientesAsyncId(IdUsuario);

        // POST api/<controller>
        [HttpPost]
        public Task<ResultEntity<Paciente>> AddPacienteAsync(Paciente paciente) => _pacienteRepository.AddPacienteAsync(paciente);

        //DELETE api/<controller>
        [HttpDelete("{IdPaciente}")]
        public Task<Result> DeletePacienteAsync(int IdPaciente) => _pacienteRepository.DeletePacienteAsync(IdPaciente);

        //PUT api/<controller>
        [HttpPut]
        public Task<ResultEntity<Paciente>> UpdatePacienteAsync(Paciente paciente) => _pacienteRepository.UpdatePacienteAsync(paciente);
    }
}
