using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NNotas
    {
        DNota not = new DNota();
        public void AgregarNotas(double notafinal, double primer, double segundo, int id)
        {
            not.InsertarNotas(notafinal,primer,segundo, id);
        }
    }
}
