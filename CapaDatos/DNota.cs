using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;

namespace CapaDatos
{
    public class DNota
    {
        CD_Conexion Conect = new CD_Conexion();
        public void InsertarNotas(double notafinal, double primer, double segundo, int id)
        {
            
            try
            {
                Conect.Abrir();
                SqlCommand AggUser = new SqlCommand("AgregarNotasYCalcularPromedio", CD_Conexion.conectar);
                AggUser.CommandType = CommandType.StoredProcedure;
                AggUser.Parameters.AddWithValue("@notaPrimerSemestre", primer);
                AggUser.Parameters.AddWithValue("@notaSegundoSemestre", segundo);
                AggUser.Parameters.AddWithValue("@notafinal", notafinal);
                AggUser.Parameters.AddWithValue("@IDDetalleInscripcion", id);

                AggUser.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
            finally
            {
                Conect.cerrar();
            }
        }

    }
}
