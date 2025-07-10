using BLL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Implementations.Memory;
using DAL.Interfaces;

namespace BLL.Services
{
    public class BateriaService : IBateriaService
    {
        private readonly IBateriaRepository bateriaRepository;
        private readonly ISubjectBateriaRepository subjectBateriaRepository;

        public BateriaService()
        {
            bateriaRepository = new BateriaRepository();
            subjectBateriaRepository = new SubjectBateriaRepository();
        }

        public void Add(Bateria bateria)
        {
            bateriaRepository.Add(bateria);
        }

        public void Delete(int IdBateria)
        {
            bateriaRepository.Delete(IdBateria);
        }

        public IEnumerable<Bateria> GetAll()
        {
            return bateriaRepository.GetAll();
        }

        public Bateria GetbyId(int IdBateria)
        {
            return bateriaRepository.GetbyId(IdBateria);
        }

        public void Update(Bateria bateria)
        {
            bateriaRepository.Update(bateria);

            Notificar(bateria);
        }

        //al final me di cuenta que arranca desde aca notificar pq es un servicio
        // pero de igual forma depende de un metodo que le traiga todas las suscripciones
        public void Notificar(Bateria bateria)
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var item in subjectBateriaRepository.GetAllSuscripciones())
            {
                item.Update(bateria);
            }
        }
    }
}
