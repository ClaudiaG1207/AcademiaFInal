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
    public  class DIdioma
    {
        CD_Conexion Conect = new CD_Conexion();
        public void Insertaridioma(string Idioma, double costo)
        {
            Conect.Abrir();
            SqlCommand AggUser = new SqlCommand("AgregarIdiomas",CD_Conexion.conectar);
            AggUser.CommandType = CommandType.StoredProcedure;
            AggUser.Parameters.AddWithValue("@Idioma", Idioma);    
            AggUser.Parameters.AddWithValue("@Costo", costo);
            AggUser.ExecuteNonQuery();
            Conect.cerrar();
        }
       
        public void MostarIdioma(ref DataTable dt)
        {
            try
            {
                Conect.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("ListarIdiomas", CD_Conexion.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally { Conect.cerrar(); }
        }
        public void editarIdioma(int idIdioma, string NomIdioma, double costo)
        {
            try
            {
                Conect.Abrir();
                SqlCommand cmd = new SqlCommand("EditarIdioma", CD_Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdIdioma", idIdioma);
                cmd.Parameters.AddWithValue("@NomIdioma", NomIdioma);
                cmd.Parameters.AddWithValue("@Costo", costo);
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
        public void EliminarIdioma(int id)
        {
            try
            {
                Conect.Abrir();
                SqlCommand cmd = new SqlCommand("EliminarIdioma", CD_Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idIdioma", id);
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
        public void MostrarNivel(ComboBox combo)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conect.Abrir();
                SqlCommand da = new SqlCommand("MostrarNivelCurso", CD_Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IDNivelCurso";
                combo.DisplayMember = "NivelCurso";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NivelCurso"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
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
        public void MostrarIdiomaCombo(ComboBox combo)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conect.Abrir();
                SqlCommand da = new SqlCommand("ListarIdiomas", CD_Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IDIdioma";
                combo.DisplayMember = "NombreIdioma";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["NombreIdioma"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
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
    }
}
