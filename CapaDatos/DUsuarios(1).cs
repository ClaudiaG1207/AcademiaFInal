using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class DUsuarios
    {
        CD_Conexion Conect = new CD_Conexion();
        public void Insertar(string Usuario, string Password)
        {
            Conect.Abrir();
            SqlCommand AggUser = new SqlCommand("Agregar_Usuario", CD_Conexion.conectar);
            AggUser.CommandType = CommandType.StoredProcedure;
            AggUser.Parameters.AddWithValue("@Usuario",Usuario);
            AggUser.Parameters.AddWithValue("@Clave", Password);
            AggUser.ExecuteNonQuery();
            Conect.cerrar();
        }
        public void MostarUsuarios(ref DataTable dt)
        {
            try
            {
                Conect.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("ListarUsuarios", CD_Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { Conect.cerrar(); }
        }
        public string Login(string User)
        {
            string ContraseñaHash = "";
            Conect.Abrir();
            SqlCommand SearchUser = new SqlCommand("BuscarUsuario", CD_Conexion.conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SearchUser.Parameters.AddWithValue("@Buscador", User);
            SqlDataReader LeerDatos = SearchUser.ExecuteReader();
            while (LeerDatos.Read())
            {
                ContraseñaHash = (string)LeerDatos["Clave"];
            }
            Conect.cerrar();
            return ContraseñaHash;
        }
        public void editarUsuario(int idUS, string us, string clave )
        {
            try
            {
                Conect.Abrir();
                SqlCommand cmd = new SqlCommand("EditarUsuario", CD_Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", idUS);
                cmd.Parameters.AddWithValue("@Usuario", us);
                cmd.Parameters.AddWithValue("@Clave", clave);
                


                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Conect.cerrar();
            }
        }
        public void EliminarUsuario(int id)
        {
            try
            {
                Conect.Abrir();
                SqlCommand cmd = new SqlCommand("EliminarUsuario", CD_Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", id);
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
        public void MostrarCargo(ComboBox combo)
        {
            try
            {
                //Crear la colección para el autocompletado
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                //Abrir la conexión a la base de datos
                Conect.Abrir();

                //Crear el comando SQL para el procedimiento almacenado
                SqlCommand da = new SqlCommand("MostrarCargo", CD_Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;

                //Crear el adapatador para ejecuatr el comando y llenar los datos en el DataTable
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);

                //Configurar el combobox para mostrar los datos
                combo.ValueMember = "IDCargo";
                combo.DisplayMember = "NombreCargo";
                combo.DataSource = dt;

                //Agregar los datos a la colección de autocompletado
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NombreCargo"].ToString());
                }

                //Asignar la colección de autocompletado al combobox
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Cerrar la conexión a la base de datos
                Conect.cerrar();
                //cambio
            }
        }
        public DataTable D_Usuarios(string usuario, string clave)
        {
            try
            {
                Conect.Abrir();
                SqlCommand cmd = new SqlCommand("Login", CD_Conexion.conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conect.cerrar();
            }
        }
    }
}
