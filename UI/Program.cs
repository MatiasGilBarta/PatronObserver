using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BLL.Services;
using BLL;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario us1 = new Usuario();
            us1.NombreUsuario = "Juan";
            Usuario us2 = new Usuario();
            us2.NombreUsuario = "Carlos";

            UsuarioService serviceUsuario = new UsuarioService();
            serviceUsuario.Add(us1);

            Bateria bat1 = new Bateria();

            BateriaService serviceBateria = new BateriaService();
            serviceBateria.Add(bat1);

            SubjectBateria servicioSuscripcion = new SubjectBateria();
            servicioSuscripcion.Suscribir(us1);
            servicioSuscripcion.Desuscribir(us1);
            servicioSuscripcion.Suscribir(us1);
            servicioSuscripcion.Suscribir(us2);

            serviceBateria.Update(new Bateria("bateria notebook", 45));

            foreach (var item in serviceBateria.GetAll())
            {
                Console.WriteLine(item.EstadoBateria);
            }

            Console.ReadLine(); 


        }
    }
}
