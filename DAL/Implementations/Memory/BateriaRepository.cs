using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memory
{
    public class BateriaRepository : IBateriaRepository
    {
        List<Bateria> _list = new List<Bateria>();

        public BateriaRepository() 
        {
            
        }

        public void Add(Bateria entity)
        {
            int IdBateria = _list.Count + 1;
            _list.Add(entity);
        }

        public void Delete(int id)
        {
            foreach (Bateria bateria in _list)
            {
                if (bateria.IdBateria == id)
                {
                    _list.Remove(bateria);
                }
            }
        }

        public IEnumerable<Bateria> GetAll()
        {
            return _list;
        }

        public Bateria GetbyId(int id)
        {
            foreach (Bateria bateria in _list)
            {
                if (bateria.IdBateria == id)
                {
                    return bateria;
                }
            }

            return null;
        }

        public void Update(Bateria entity)
        {
            Bateria current = null;

            foreach (Bateria bateria in _list)
            {
                if (bateria.IdBateria == entity.IdBateria)
                {
                    current = bateria;
                    break;
                }
            }

            current.NombreBateria = entity.NombreBateria;
            current.EstadoBateria = entity.EstadoBateria;
            //current.Code = entity.Code;
        }
    }
}
