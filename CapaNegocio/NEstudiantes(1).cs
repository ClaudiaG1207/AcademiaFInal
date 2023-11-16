using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEstudiantes
    {
        DEstudiantescs Estu = new DEstudiantescs();

        public void  AgregarEstudiante(string Ced, string NomAp, string Direc, int edad, int Cel, string Correo, string Nacionalidad, int idtutor)
        {
            Estu.InseeEtudiantes(Ced, NomAp, Direc, edad, Cel, Correo, Nacionalidad,idtutor);
        }
        public void EliminarEstudiante(int id)
        {
            Estu.EliminarEstudiante(id);
        }
        public void editarestudiante(int id,string Ced, string NomAp, string Direc, int edad, int Cel, string Correo, string Nacionalidad, int idtutor)
        {
            Estu.editarestudiantes(id,Ced, NomAp, Direc, edad, Cel, Correo, Nacionalidad,idtutor);
        }
        public void MostarEstudiante(DataTable dt)
        {
            Estu.MostarEstudiante(ref dt);
        }
        public void BuscarEstudiante(DataTable dt, string buscador)
        {
            Estu.BuscarEstudiantes(ref dt,buscador);
        }
    }
}
