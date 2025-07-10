using DAL.Interfaces;
using Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memory
{
    public class UsuarioRepository : IUsuarioRepository
    {
        List<Usuario> _list = new List<Usuario>();

        public UsuarioRepository() 
        { 
        }

        public void Add(Usuario entity)
        {
            foreach(Usuario usuario in _list)
            {
                if (usuario.NombreUsuario == entity.NombreUsuario)
                { return; } // El foreach es para cuando ya existe, no lo agregamos
            }
            int IdUsuario = _list.Count + 1;
            _list.Add(entity);
        }

        public void Delete(int id)
        {
            foreach (Usuario usuario in _list)
            {
                if (usuario.IdUsuario == id)
                {
                    _list.Remove(usuario);
                }
            }
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _list;
        }

        public Usuario GetbyId(int id)
        {
            foreach (Usuario usuario in _list)
            {
                if (usuario.IdUsuario == id)
                {
                    return usuario;
                }
            }
            return null; 
        }

        public void Update(Usuario entity)
        {
            Usuario current = null;

            foreach (Usuario usuario in _list)
            {
                if (usuario.IdUsuario == entity.IdUsuario)
                {
                    current = usuario;
                    break;
                }
            }

            current.NombreUsuario = entity.NombreUsuario;
            //current.Code = entity.Code;
        }
    }
}
