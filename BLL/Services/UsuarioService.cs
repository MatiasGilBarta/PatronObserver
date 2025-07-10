using BLL.Interfaces;
using DAL.Implementations.Memory;
using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioService()
        {
            usuarioRepository = new UsuarioRepository();
        }

        public void Add(Usuario usuario)
        {
            usuarioRepository.Add(usuario);
        }

        public void Delete(int IdUsuario)
        {
            usuarioRepository.Delete(IdUsuario);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return usuarioRepository.GetAll();
        }

        public Usuario GetbyId(int IdUsuario)
        {
            return usuarioRepository.GetbyId(IdUsuario);
        }

        public void Update(Usuario usuario)
        {
            usuarioRepository.Update(usuario);
        }
    }
}
