using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Repositories
{
    public interface IUsuarioRepository
    {
        Task AddUsuario(UsuarioModels novoUsuario);
        public Task<UsuarioModels?> GetUsuario(string usuarioId);
    }
}
