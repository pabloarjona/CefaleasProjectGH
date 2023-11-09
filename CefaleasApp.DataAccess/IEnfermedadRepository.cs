using Pitasoft.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess
{
    public interface IEnfermedadRepository
    {
        Task<ResultEntity<Enfermedad>> AddEnfermedadAsync(Enfermedad enfermedad);
        Task<ResultEntity<Enfermedad>> GetEnfermedadAsync(int IdEnfermedad);
        Task<ResultEntity<Enfermedad>> UpdateEnfermedadAsync(Enfermedad enfermedad);
        Task<Result> DeleteEnfermedadAsync(int IdEnfermedad);
    }
}
