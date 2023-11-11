using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NInscripcion
    {
        DInscripcion DInscripcion = new DInscripcion();
        public void InsertarInscripcion(LInscripcion parametros, List<LInscripcion> lst)
        {
            DInscripcion.InsertaInscripcion(parametros, lst);
        }
        public void MostrarInscripcion(DataTable dt)
        {
            DInscripcion.MostarInscripcion(ref dt);
        }
        public void MostrarInscripcionDetalle(DataTable dt,int idestudiante, int idinscripcion)
        {
            DInscripcion.MostarInscripcionDetalle(idestudiante,idinscripcion,ref dt);
        }
        public void PagarUnCurso(int id)
        {
            DInscripcion.PagarUNCUrso(id);
        }
    }
}
