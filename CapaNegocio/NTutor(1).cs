using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NTutor
    {
        DTutor Tutor = new DTutor();

        public void AgregarTutor(string Ced, string NomAp, string Direc, int edad, int Cel, string Correo, string Nacionalidad)
        {
            Tutor.IsertarTutor(Ced, NomAp, Direc, edad, Cel, Correo, Nacionalidad);
        }
        public void EliminarTutor(int id)
        {
            Tutor.EliminarTutor(id);
        }
        public void EditarTutor(int id, string Ced, string NomAp, string Direc, int edad, int Cel, string Correo, string Nacionalidad)
        {
            Tutor.EditarTutor(id, Ced, NomAp, Direc, edad, Cel, Correo, Nacionalidad);
        }
        public void MostarTutor(DataTable dt)
        {
            Tutor.MostarTutor(ref dt);
        }
        public void BuscarTutor(DataTable dt, string buscador)
        {
            Tutor.BuscarTutor(ref dt, buscador);
        }
    }



}
