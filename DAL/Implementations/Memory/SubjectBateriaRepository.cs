using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL.Interfaces;

namespace DAL.Implementations.Memory
{
    public class SubjectBateriaRepository : ISubjectBateriaRepository
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        //public int Bateria { get; set; } = -0;

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private static List<Usuario> _suscripciones = new List<Usuario>();

        // The subscription management methods.
        public void Suscribir(Usuario usuario)
        {
            _suscripciones.Add(usuario);
            //Console.WriteLine("Subject: Attached an observer.");
        }

        public void Desuscribir(Usuario usuario)
        {
            _suscripciones.Remove(usuario);
            //Console.WriteLine("Subject: Detached an observer.");
        }

        public IEnumerable<Usuario> GetAllSuscripciones()
        {
            return _suscripciones;
        }



        // Trigger an update in each subscriber.

        /*public void CargaBateria(int watts = 10)
            {
            this.Bateria = this.Bateria + watts;
            Console.WriteLine($"cargo bateria");
            this.Notificar();
            }

        public void DescargaBateria(int watts = 10)
            {
            this.Bateria = this.Bateria - watts;
            Console.WriteLine($"descargo bateria");
            this.Notificar();
            }*/
    }
}
