using System.Threading.Tasks;
using Core.Models;

namespace Core.Services {
    public interface IUsuarioService {
        Task<UsuarioModels> RegistrarUsuario(UsuarioModels novoUsuario);
        Task<UsuarioModels> GetUsuarioOrThrowException(string usuarioId);
        Task<UsuarioModels?> GetUsuario(string usuarioId);
    }
}
