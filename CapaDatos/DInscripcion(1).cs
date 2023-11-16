using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace CapaDatos
{
    public class DInscripcion
    {
        CD_Conexion conexion = new CD_Conexion();
        public void InsertaInscripcion(LInscripcion parametros, List<LInscripcion> lst)
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("IdIdioma");
                dt.Columns.Add("IdNivel");
                dt.Columns.Add("Semestre");
                dt.Columns.Add("Grupo");
                dt.Columns.Add("Estado");

                int i = 1;
                foreach (var oElement in lst)
                {
                    dt.Rows.Add(i, oElement.IdIdioma, oElement.IdNivel, oElement.Semestre, oElement.Grupo, oElement.Estado);
                    i++;
                }

                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("InsertarInscripcion", CD_Conexion.conectar);
                var parameterlst = new SqlParameter("@lstIdiomas", SqlDbType.Structured);
                parameterlst.TypeName = "Inscripcion";
                parameterlst.Value = dt;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(parameterlst);
                cmd.Parameters.AddWithValue("@IdEstudiante", parametros.Idestudiante);
                cmd.Parameters.AddWithValue("@Fecha", parametros.Fecha);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Ups! Ha ocurrido un error al agregar, por favor revise los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                conexion.cerrar();
            }
        }
        public void MostarInscripcion(ref DataTable dt)
        {
            try
            {
              conexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarInscripcion", CD_Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { conexion.cerrar(); }
        }
        public void MostarInscripcionDetalle(int idestudiante, int idinscripcion, ref DataTable dt)
        {
            try
            {
                //Se abre la conexión a la base de datos
                conexion.Abrir();

                //Crea el comando SQL para el procedimiento almacenado
                SqlDataAdapter da = new SqlDataAdapter("DetalleInscripcion", CD_Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idinscripcion", idinscripcion);
                da.SelectCommand.Parameters.AddWithValue("@idestudiante", idestudiante);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { conexion.cerrar(); }
        }
        public void PagarUNCUrso(int ID)
        {
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("Pagar", CD_Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexion.cerrar();
            }
        }
    }
    
}
