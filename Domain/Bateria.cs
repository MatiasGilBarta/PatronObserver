using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bateria
    {
        public int IdBateria { get; set; }
        public string NombreBateria { get; set; }
        public int EstadoBateria { get; set; }

        //constructor
        public Bateria() 
        {
        }

        public Bateria(string nombreBateria, int estadoBateria)
        {
            NombreBateria = nombreBateria;
            EstadoBateria = estadoBateria;
        }
    }
}
