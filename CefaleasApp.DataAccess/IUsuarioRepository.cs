using Pitasoft.Result;
using System.Threading.Tasks;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess
{
    public interface IUsuarioRepository
    {
        Task<ResultEntity<Usuario>> AddUsuarioAsync(Usuario usuario);
        Task<ResultEntities<Usuario>> GetUsuariosAsync();
        Task<ResultEntity<Usuario>> UpdateUsuarioAsync(Usuario usuario);
        Task<Result> DeleteUsuarioAsync(int UsuarioId);

    }
}
