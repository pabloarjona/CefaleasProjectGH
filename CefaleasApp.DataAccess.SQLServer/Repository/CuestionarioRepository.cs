using Microsoft.EntityFrameworkCore;
using Pitasoft.Result;
using System.Threading.Tasks;
using CefaleasApp.Entities;
using CefaleasApp.Entities.Interfaces;

namespace CefaleasApp.DataAccess.SQLServer.Repository
{
    public class CuestionarioRepository : ICuestionarioRepository
    {
        private readonly CefaleasContext _context;
        public CuestionarioRepository(CefaleasContext context) => _context = context;
        public async Task<ResultEntity<Cuestionario>> AddCuestionarioAsync(Cuestionario cuestionario)
        {
            try
            { 
                await _context.Cuestionario.AddAsync(cuestionario);
                await _context.SaveChangesAsync();
                return ResultEntity<Cuestionario>.Added(cuestionario);
            }
            catch
            {
                return ResultEntity<Cuestionario>.DatabaseError();
            }            
        }

        public async Task<Result> DeleteCuestionarioAsync(int IdCuestionario)
        {
            try
            {
                var entity = await _context.Cuestionario.SingleAsync(x => x.IdPaciente == IdCuestionario);
                _context.Cuestionario.Remove(entity);
                await _context.SaveChangesAsync();
                return Result.Deleted();
            }
            catch
            {
                return Result.DatabaseError(); 
            }
        }

        public async Task<ResultEntity<Cuestionario>> GetCuestionariosAsync(int IdPaciente)
        {
            try
            {
                var entity = await _context.Cuestionario.SingleAsync(x => x.IdPaciente == IdPaciente);
                return ResultEntity<Cuestionario>.Ok(entity);
            }
            catch(System.InvalidOperationException)
            {
                return ResultEntity<Cuestionario>.NotExists();
            }
            catch
            {
                return ResultEntity<Cuestionario>.DatabaseError();
            }
        }

        public async Task<ResultEntity<Cuestionario>> UpdateCuestionarioAsync(Cuestionario cuestionario)
        {
            try
            {
                var entity = await _context.Cuestionario.SingleAsync(x => x.IdPaciente == cuestionario.IdPaciente);
                entity.Episodios = cuestionario.Episodios;
                entity.Duracion = cuestionario.Duracion;
                entity.Duracion_episodio = cuestionario.Duracion_episodio;
                entity.Localizacion = cuestionario.Localizacion;
                entity.Dolor = cuestionario.Dolor;
                entity.Intensidad = cuestionario.Intensidad;
                entity.Actividad_fisica = cuestionario.Actividad_fisica;
                entity.Nauseas = cuestionario.Nauseas;
                entity.Vomitos = cuestionario.Vomitos;
                entity.Fotofobia = cuestionario.Fotofobia;
                entity.Fonofobia = cuestionario.Fonofobia;
                entity.Aura = cuestionario.Aura;
                entity.Ipsilaterales = cuestionario.Ipsilaterales;
                entity.Inquietud = cuestionario.Inquietud;
                entity.Trayectoria_lineal = cuestionario.Trayectoria_lineal;
                entity.Inicio_brusco = cuestionario.Inicio_brusco;
                entity.Indometacina = cuestionario.Indometacina;
                entity.Triptan_ergotico = cuestionario.Triptan_ergotico;
                entity.Tos = cuestionario.Tos;
                entity.Esfuerzo_brusco = cuestionario.Esfuerzo_brusco;
                entity.Valsalva = cuestionario.Valsalva;
                entity.Actividad_sexual = cuestionario.Actividad_sexual;
                entity.Sueño = cuestionario.Sueño;
                entity.Inicio_inconfundible = cuestionario.Inicio_inconfundible;
                entity.Verificado = cuestionario.Verificado;
                entity.IdEnfermedad = cuestionario.IdEnfermedad;
                entity.IdEnfermedadVerificada = cuestionario.IdEnfermedadVerificada;
                _context.Cuestionario.UpdateRange(entity);
                await _context.SaveChangesAsync();
                //CAMBIADO A UPDATE
                return ResultEntity<Cuestionario>.Updated(entity);
            }
            catch
            {
                return ResultEntity<Cuestionario>.DatabaseError();
            }
        }
    }
}
