using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics.Contracts;

namespace CapaDatos
{
    public class DEstudiantescs
    {
        CD_Conexion Conect = new CD_Conexion();

        public bool InseeEtudiantes(string ced, string NomA, string direc, int Edad, int cel, string correo, string nacionalidad, int idtutor)
        {
            try
            {
                Conect.Abrir();
                SqlCommand AggUser = new SqlCommand("AgregarEstudiante", CD_Conexion.conectar);
                AggUser.CommandType = CommandType.StoredProcedure;
                AggUser.Parameters.AddWithValue("@Cedula", ced);
                AggUser.Parameters.AddWithValue("@NomAp", NomA);
                AggUser.Parameters.AddWithValue("@Direccion", direc);
                AggUser.Parameters.AddWithValue("@Edad", Edad);
                AggUser.Parameters.AddWithValue("@cel", cel);
                AggUser.Parameters.AddWithValue("@Correo", correo);
                AggUser.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                AggUser.Parameters.AddWithValue("@idTutor", idtutor);
                AggUser.ExecuteNonQuery();
                MessageBox.Show("Se realizo el regitro con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conect.cerrar();

            }
        }
        public void MostarEstudiante(ref DataTable dt)
        {
            try
            {
                Conect.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("ListarEstudiantes", CD_Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { Conect.cerrar(); }
        }
        public bool editarestudiantes(int idestudiante,string ced, string NomA, string direc, int Edad, int cel, string correo, string nacionalidad, int idtutor)
        {
            try
            {
                Conect.Abrir();
                SqlCommand cmd = new SqlCommand("EditarEstudiantes", CD_Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEstudiante", idestudiante);
                cmd.Parameters.AddWithValue("@Cedula", ced);
                cmd.Parameters.AddWithValue("@NomAp", NomA);
                cmd.Parameters.AddWithValue("@Direccion", direc);
                cmd.Parameters.AddWithValue("@Edad", Edad);
                cmd.Parameters.AddWithValue("@cel", cel);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                cmd.Parameters.AddWithValue("@idtutor", idtutor);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizo el regitro con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conect.cerrar();
            }
        }
        public void EliminarEstudiante(int id)
        {
            try
            {
                Conect.Abrir();
                SqlCommand cmd = new SqlCommand("EliminarEstudiante", CD_Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idestudiante", id);               
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
            finally
            {
                Conect.cerrar();
            }
        }
        public void BuscarEstudiantes(ref DataTable dt, string buscador)
        {
            try
            {
                Conect.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarEstudiantes", CD_Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { Conect.cerrar(); }
        }
    }
}
