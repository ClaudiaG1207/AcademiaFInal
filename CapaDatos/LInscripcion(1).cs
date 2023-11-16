using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class LInscripcion
    {
        public int IdInscripcion { get; set; }
        public int IdDetalleInscripcion { get; set; }
        public int IdIdioma { get; set; }
        public int IdNivel { get; set; }
        public string Semestre { get; set; }
        public string Grupo { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public int Idestudiante { get; set; }
    }
}
