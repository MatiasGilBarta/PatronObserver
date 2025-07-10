using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Interfaces
{
    public interface ISubjectBateriaRepository
    {
        void Suscribir(Usuario usuario);

        // Detach an observer from the subject.
        void Desuscribir(Usuario usuario);

        // Notify all observers about an event.
        IEnumerable<Usuario> GetAllSuscripciones();
    }
}
