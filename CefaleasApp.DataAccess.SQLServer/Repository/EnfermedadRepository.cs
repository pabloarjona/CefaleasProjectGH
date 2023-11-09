using Microsoft.EntityFrameworkCore;
using Pitasoft.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess.SQLServer.Repository
{
    public class EnfermedadRepository : IEnfermedadRepository
    {
        private readonly CefaleasContext _context;
        public EnfermedadRepository(CefaleasContext context) => _context = context;
        public async Task<ResultEntity<Enfermedad>> AddEnfermedadAsync(Enfermedad enfermedad)
        {
            try
            {
                await _context.Enfermedad.AddAsync(enfermedad);
                await _context.SaveChangesAsync();
                return ResultEntity<Enfermedad>.Added(enfermedad);
            }
            catch
            {
                return ResultEntity<Enfermedad>.DatabaseError();
            }
        }

        public async Task<Result> DeleteEnfermedadAsync(int IdEnfermedad)
        {
            try
            {
                var entity = await _context.Enfermedad.SingleAsync(x => x.IdEnfermedad == IdEnfermedad);
                _context.Enfermedad.Remove(entity);
                await _context.SaveChangesAsync();
                return Result.Deleted();
            }
            catch
            {
                return Result.DatabaseError();
            }
        }

        public async Task<ResultEntity<Enfermedad>> GetEnfermedadAsync(int IdEnfermedad)
        {
            try
            {
                return ResultEntity<Enfermedad>.Ok(await _context.Enfermedad.SingleAsync(x => x.IdEnfermedad == IdEnfermedad));
            }
            catch
            {
                return ResultEntity<Enfermedad>.DatabaseError();
            }
        }

        public async Task<ResultEntity<Enfermedad>> UpdateEnfermedadAsync(Enfermedad enfermedad)
        {
            try
            {
                var entity = await _context.Enfermedad.SingleAsync(x => x.IdEnfermedad==enfermedad.IdEnfermedad);
                entity.Nombre_Enfermedad = enfermedad.Nombre_Enfermedad;
                entity.Tratamiento = enfermedad.Tratamiento;
                _context.Enfermedad.UpdateRange(entity);
                await _context.SaveChangesAsync();
                return ResultEntity<Enfermedad>.Updated(enfermedad);
            }
            catch
            {
                return ResultEntity<Enfermedad>.DatabaseError();
            }
        }
    }
}
