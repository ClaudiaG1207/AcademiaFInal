using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class CD_Conexion
    {
        public static SqlConnection conectar = new SqlConnection(@"Data source=DESKTOP-VG9DFN6; Initial Catalog=AcademiaEuropea; Integrated Security = True");
       //public static SqlConnection conectar = new SqlConnection(@"Data source=CLAUDIA12; Initial Catalog=AcademiaEuropea; Integrated Security = True");
        private string res;
        public string Abrir()
        {
            try
            {
                if (conectar.State == System.Data.ConnectionState.Closed)
                {
                    conectar.Open();
                }
            }
            catch (Exception exep)
            {
                res = exep.Message;
            }
            return res;
        }



        public string  cerrar()
        {
            try
            {
                if (conectar.State == System.Data.ConnectionState.Open)
                {
                    conectar.Close();
                }
            }
            catch (Exception exep)
            {
                res = exep.Message;
            }
            return res;
        }
    }

}
