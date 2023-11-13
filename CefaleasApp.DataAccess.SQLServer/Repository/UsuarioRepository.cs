using CefaleasApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Pitasoft.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CefaleasApp.Entities;
using CefaleasApp.Entities.Interfaces;

namespace CefaleasApp.DataAccess.SQLServer.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CefaleasContext _context;
        public UsuarioRepository(CefaleasContext context) => _context = context;
        public async Task<ResultEntity<Usuario>> AddUsuarioAsync(Usuario usuario)
        {
            try
            {
                await _context.Usuario.AddAsync(usuario);
                await _context.SaveChangesAsync();
                return ResultEntity<Usuario>.Added(usuario);
            }
            catch
            {
                return ResultEntity<Usuario>.DatabaseError();
            }
        }

        public async Task<Result> DeleteUsuarioAsync(int IdUsuario)
        {
            try
            {
                var entity = await _context.Usuario.SingleAsync(x => x.IdUsuario == IdUsuario);
                _context.Usuario.Remove(entity);
                await _context.SaveChangesAsync();
                return ResultEntity<Usuario>.Deleted(entity);
            }
            catch
            {
                return ResultEntity<Usuario>.DatabaseError();
            }
        }

        public async Task<ResultEntities<Usuario>> GetUsuariosAsync()
        {
            try
            {
                List<Usuario> usuarios = new();
                usuarios.AddRange(await _context.Usuario.AsNoTracking().ToListAsync());
                return ResultEntities<Usuario>.Ok(usuarios);
            }
            catch
            {
                return ResultEntities<Usuario>.DatabaseError();
            }
        }

        public async Task<ResultEntity<Usuario>> GetUsuarioAsync(int id)
        {
            try
            {
                var entity = await _context.Usuario.SingleAsync(x => x.IdUsuario == id);
                return ResultEntity<Usuario>.Ok(entity);
            }
            catch
            {
                return ResultEntity<Usuario>.DatabaseError();
            }
        }

        public async Task<ResultEntity<Usuario>> UpdateUsuarioAsync(Usuario usuario)
        {
            try
            {
                var entity = await _context.Usuario.SingleAsync(x => x.IdUsuario == usuario.IdUsuario);
                entity.Nombre = usuario.Nombre;
                entity.NColegiado = usuario.NColegiado;
                entity.Correo = usuario.Correo;
                entity.Password= usuario.Password;
                entity.NVerificacion = usuario.NVerificacion;
                entity.Verificado = usuario.Verificado;
                _context.Usuario.UpdateRange(entity);
                await _context.SaveChangesAsync();
                return ResultEntity<Usuario>.Updated(usuario);
            }
            catch
            {
                return ResultEntity<Usuario>.DatabaseError();
            }
        }
    }
}
