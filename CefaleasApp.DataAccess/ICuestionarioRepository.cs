using Pitasoft.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess
{
    public interface ICuestionarioRepository
    {
        Task<ResultEntity<Cuestionario>> AddCuestionarioAsync(Cuestionario cuestionario);
        Task<ResultEntity<Cuestionario>> GetCuestionariosAsync(int IdPaciente);
        Task<ResultEntity<Cuestionario>> UpdateCuestionarioAsync(Cuestionario cuestionario);
        Task<Result> DeleteCuestionarioAsync(int IdCuestionario);
    }
}
