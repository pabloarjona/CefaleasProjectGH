using Microsoft.EntityFrameworkCore;
using Pitasoft.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess.SQLServer.Repository
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly CefaleasContext _context;
        public PacienteRepository(CefaleasContext context) => _context = context;
        public async Task<ResultEntity<Paciente>> AddPacienteAsync(Paciente paciente)
        {
            try
            {
                await _context.Paciente.AddAsync(paciente);
                await _context.SaveChangesAsync();
                return ResultEntity<Paciente>.Added(paciente);
            }
            catch
            {
                return ResultEntity<Paciente>.DatabaseError();
            }
        }

        public async Task<Result> DeletePacienteAsync(int IdPaciente)
        {
            try
            {
                var entity = await _context.Paciente.SingleAsync(x => x.IdPaciente == IdPaciente );
                _context.Paciente.Remove(entity);
                await _context.SaveChangesAsync();
                return Result.Deleted();
            }
            catch
            {
                return ResultEntity<Paciente>.DatabaseError();
            }
        }

        public async Task<ResultEntities<Paciente>> GetPacientesAsync()
        {
            try
            { 
                List<Paciente> pacientes = new();
                pacientes.AddRange(await _context.Paciente.AsNoTracking().ToListAsync());
                return ResultEntities<Paciente>.Ok(pacientes);
            }
            catch
            {
                return ResultEntities<Paciente>.DatabaseError();
            }
        }

        public async Task<ResultEntities<Paciente>> GetPacientesAsyncId(int IdUsuario)
        {
            List<Paciente> pacientes = new();
            try
            {
                
              //  result.Model = _context.Paciente.Where(x => x.IdUsuario == IdUsuario).ToList();
                pacientes.AddRange(await _context.Paciente.Where(x => x.IdUsuario == IdUsuario).AsNoTracking().ToListAsync());
                return ResultEntities<Paciente>.Ok(pacientes);
            }
            catch
            {
                return ResultEntities<Paciente>.DatabaseError();
            }
        }

        public async Task<ResultEntity<Paciente>> UpdatePacienteAsync(Paciente paciente)
        {
            try
            {
                var entity = await _context.Paciente.SingleAsync(x => x.IdPaciente == paciente.IdPaciente && x.IdUsuario==paciente.IdUsuario);
                entity.Iniciales = paciente.Iniciales;
                entity.FechaConsulta = paciente.FechaConsulta;
                entity.Edad = paciente.Edad;
                entity.Sexo = paciente.Sexo;
                entity.IdUsuario = paciente.IdUsuario;
                _context.Paciente.UpdateRange(entity);
                await _context.SaveChangesAsync();
                return ResultEntity<Paciente>.Updated(paciente);
            }
            catch
            {
                return ResultEntity<Paciente>.DatabaseError();
            }
        }
    }
}
