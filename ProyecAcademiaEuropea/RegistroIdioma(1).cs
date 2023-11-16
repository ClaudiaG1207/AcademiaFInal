using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecAcademiaEuropea
{
    public partial class RegistroIdioma : Form
    {
        public RegistroIdioma()
        {
            InitializeComponent();
        }
        NIdioma Idio = new NIdioma();
        public string NomIdioma;
        public double Costo;
        int idIdioma;
        public string IDIOMA;
        public double COSTO;
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal FP = new FormPrincipal();
            FP.Show();
        }
        private void MostrarIdioma()
        {
            DataTable dt = new DataTable();
            NIdioma funcion = new NIdioma();
            funcion.MostarIdioma(dt);
            dtIdioma.DataSource = dt;
            Bases.DiseñoDtv(ref dtIdioma);
            
            
        }
        private void INSERTAR()
        {
            NomIdioma = TxtNomIdioma.Text;
            Costo = Convert.ToDouble(TxtCostoIdioma.Text);
            TxtCostoIdioma.Clear();
            TxtNomIdioma.Clear();
            Idio.AgregarIdioma( NomIdioma, Costo);
            MostrarIdioma();
            MessageBox.Show("Se realizo el regitro con exito");
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                INSERTAR();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void CapturarDatos()
        {

            idIdioma = int.Parse(dtIdioma.SelectedCells[3].Value.ToString());
            TxtNomIdioma.Text = dtIdioma.SelectedCells[5].Value.ToString();
            TxtCostoIdioma.Text = dtIdioma.SelectedCells[6].Value.ToString();
        }
        private void dtIdioma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtIdioma.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este Idioma?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                   EliminarIdioma();
                   MostrarIdioma();
                }

            }
            if (e.ColumnIndex == dtIdioma.Columns["Editar"].Index)
            {
                CapturarDatos();
                BtnEditar.Visible = true;
                BtnGuardar.Visible = false;
            }
        }
        private void EliminarIdioma()
        {
            idIdioma = int.Parse(dtIdioma.SelectedCells[3].Value.ToString());
            Idio.EliminarIdioma(idIdioma);
        }
        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(TxtCostoIdioma.Text) &&
            !string.IsNullOrEmpty(TxtNomIdioma.Text);
            BtnGuardar.Enabled = vr;
            BtnEditar.Enabled = vr;
        }
        private void TxtNomIdioma_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
        private void TxtCostoIdioma_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
        private void EditarIdioma()

        {
            IDIOMA = TxtNomIdioma.Text;
            COSTO = Convert.ToDouble(TxtCostoIdioma.Text);
            TxtCostoIdioma.Clear();
            TxtNomIdioma.Clear();
            Idio.EditarIdioma(idIdioma, NomIdioma, Costo);
            MostrarIdioma();
            MessageBox.Show("Se actualizo el regitro con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                EditarIdioma();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RegistroIdioma_Load(object sender, EventArgs e)
        {
            MostrarIdioma();
        }
    }
}
