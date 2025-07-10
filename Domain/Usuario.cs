using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Usuario : IObsevador
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }

        public void Update(Bateria bateria)
        {
            Console.WriteLine($"Soy {NombreUsuario} recibiendo notificacion estado bateria: {bateria.EstadoBateria}");
        }
    }
}
