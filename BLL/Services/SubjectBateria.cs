using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Implementations.Memory;

namespace BLL.Services
{
    public class SubjectBateria
    {
        private readonly ISubjectBateriaRepository subjectBateriaRepository;

        public SubjectBateria()
        {
            subjectBateriaRepository = new SubjectBateriaRepository();
        }

        //private static Dictionary<Ciudad, List<Usuario>> _suscripciones = new Dictionary<Ciudad, List<Usuario>>();
        //el notificar en esta version nueva lo mandamos para el servicio que brinda la info
        //Tanto el suscribir como el desuscribir ahora vamos a laburarlos desde el repo

        //a diferencia del profe no ponemos static en ninguna pq estamos usando el singleton
        //public List<Usuario> Notificar()
        //{
        //    return subjectBateriaRepository.TodasLasSuscripciones();
        //}

        public void Suscribir(Usuario usuario)
        {
            Console.WriteLine("sujeto suscripto al observador");
            subjectBateriaRepository.Suscribir(usuario);
        }

        public void Desuscribir(Usuario usuario)
        {
            Console.WriteLine("sujeto desuscripto al observador");
            subjectBateriaRepository.Desuscribir(usuario);
        }
    }
}
