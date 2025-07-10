using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBateriaService : IGenericService<Bateria>
    {
        void Notificar(Bateria bateria);
    }
}
