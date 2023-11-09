using Pitasoft.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess
{
    public interface IPacienteRepository
    {
        Task<ResultEntity<Paciente>> AddPacienteAsync(Paciente paciente);
        Task<ResultEntities<Paciente>> GetPacientesAsync();
        Task<ResultEntities<Paciente>> GetPacientesAsyncId(int IdUsuario);
        Task<ResultEntity<Paciente>> UpdatePacienteAsync(Paciente paciente);
        Task<Result> DeletePacienteAsync(int  IdPaciente);
    }
}
