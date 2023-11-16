using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecAcademiaEuropea
{
    public partial class TutorEstudiante : Form
    {
        public TutorEstudiante()
        {
            
            InitializeComponent();
            MostrarTutor();
        }
        NTutor funcion = new NTutor();
        private void MostrarTutores()
        {
            DataTable dt = new DataTable();
            NTutor funcion = new NTutor();
            funcion.MostarTutor(dt);
            dtTutor.DataSource = dt;
            Bases.DiseñoDtv(ref dtTutor);
            dtTutor.Columns[0].Visible = false;
            dtTutor.Columns[1].Visible = false;
            dtTutor.Columns[3].Visible = false;
            dtTutor.Columns[4].Visible = false;
            dtTutor.Columns[5].Visible = false;
            dtTutor.Columns[6].Visible = false;
            dtTutor.Columns[7].Visible = false;
           

        }
        private void SelecionarTutorcs_Load(object sender, EventArgs e)
        {
            MostrarTutores();
        }
        private void Datos()
        {
            IdTutor = Convert.ToInt32(dtTutor.SelectedCells[3].Value);
            NombreTutor = dtTutor.SelectedCells[5].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public int IdTutor { get; set; }
        public string NombreTutor { get; set; }
        NTutor tuto = new NTutor();
        public string FCedula;
        
        public string FDirec;
        public int FEdad;
        public int FCel;
        public string FCorreo;
        public string FNacionalidad;
        
        private void MostrarTutor()
        {
            DataTable dt = new DataTable();
            NTutor funcion = new NTutor();
            funcion.MostarTutor(dt);
            dtTutor.DataSource = dt;
            Bases.DiseñoDtv(ref dtTutor);
        }
        private void INSERTAR()

        {
            FCedula = TxtCedTutor.Text;
            NombreTutor = TxtNomTutor.Text;
            FDirec = TxtDirecTutor.Text;
            FEdad = int.Parse(TxtEdadTutor.Text);
            FCel = int.Parse(TxtCelTutor.Text);
            FCorreo = TxtCorreoTutor.Text;
            FNacionalidad = CBNacionalidad.Text;
            tuto.AgregarTutor(FCedula, NombreTutor, FDirec, FEdad, FCel, FCorreo, FNacionalidad);
            MostrarTutor();
            LimpiarCampos();

        }
        private void LimpiarCampos()
        {
            TxtCedTutor.Clear();
            TxtNomTutor.Clear();
            TxtDirecTutor.Clear();
            TxtEdadTutor.Clear();
            TxtCelTutor.Clear();
            TxtCorreoTutor.Clear();
            CBNacionalidad.Text = "";
        }
        private void EditarTutor()

        {
            FCedula = TxtCedTutor.Text;
            NombreTutor = TxtNomTutor.Text;
            FDirec = TxtDirecTutor.Text;
            FEdad = int.Parse(TxtEdadTutor.Text);
            FCel = int.Parse(TxtCelTutor.Text);
            FCorreo = TxtCorreoTutor.Text;
            FNacionalidad = CBNacionalidad.Text;
            tuto.EditarTutor(IdTutor, FCedula, NombreTutor, FDirec, FEdad, FCel, FCorreo, FNacionalidad);
            MostrarTutor();
            LimpiarCampos();

        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCelTutor.Text.Length < 8)
            {
                MessageBox.Show("los digitos del celular deben de ser 8");
            }
            else
            {
                try
                {
                    INSERTAR();
                    LimpiarCampos();
                    TxtNomTutor.Focus();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal FP = new FormPrincipal();
            FP.Show();
        }
        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(TxtNomTutor.Text) && !string.IsNullOrEmpty(TxtDirecTutor.Text)
                && !string.IsNullOrEmpty(TxtCorreoTutor.Text) && !string.IsNullOrEmpty(TxtCelTutor.Text) &&
                !string.IsNullOrEmpty(TxtEdadTutor.Text) && !string.IsNullOrEmpty(TxtCedTutor.Text) && !string.IsNullOrEmpty(CBNacionalidad.Text);
            BtnGuardar.Enabled = vr;
            btnActualizar.Enabled = vr;
        }
        private void TutorEstudiante_Load(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = false;
        }
       
        private void dtTutor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Datos();
        }

        private void TxtEdadTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtCelTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
        public static void Letras(KeyPressEventArgs pE)
        {

            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }

            else if (Char.IsControl(pE.KeyChar))
            {

                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else

            {
                pE.Handled = true;
            }


        }
        private void TxtNomTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letras(e);
        }

        
        private void EliminarTutor()
        {
            IdTutor= int.Parse(dtTutor.SelectedCells[3].Value.ToString());
            funcion.EliminarTutor(IdTutor);
        }
        private void CapturarDatos()
        {

            IdTutor  = int.Parse(dtTutor.SelectedCells[3].Value.ToString());
            TxtCedTutor .Text = dtTutor.SelectedCells[4].Value.ToString();
            TxtNomTutor .Text = dtTutor.SelectedCells[5].Value.ToString();
            TxtDirecTutor.Text = dtTutor.SelectedCells[6].Value.ToString();
            TxtEdadTutor .Text = dtTutor.SelectedCells[7].Value.ToString();
            TxtCelTutor .Text = dtTutor.SelectedCells[8].Value.ToString();
            TxtCorreoTutor .Text = dtTutor.SelectedCells[9].Value.ToString();
            CBNacionalidad.Text = dtTutor.SelectedCells[10].Value.ToString();


        }
        private void dtTutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtTutor.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este Tutor?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarTutor();
                    MostrarTutor();
                }

            }
            if (e.ColumnIndex ==dtTutor.Columns["Editar"].Index)
            {
               
                CapturarDatos();
                btnActualizar.Visible = true;
                BtnGuardar.Visible = false;
            }


        }
       
       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EditarTutor();
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtNomTutor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void TxtDirecTutor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void TxtCorreoTutor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void TxtCedTutor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void TxtEdadTutor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void TxtCelTutor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void CBNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
    }
}
