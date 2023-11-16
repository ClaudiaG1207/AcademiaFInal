using CapaNegocio;
using ProyecAcademiaEuropea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyecAcademiaEuropea
{
    public partial class RegistroEstudiantes : Form
    {
        private bool labelsVerdes = false;
        
        public RegistroEstudiantes()
        {
            InitializeComponent();
            MostrarEstudiante();
            this.toolTip1.SetToolTip(this.TxtCorreoEstu, "El correo debe ser ejemplo: nombre@abc.com");
            TxtCorreoEstu.TextChanged += TxtCorreoEstu_TextChanged1;
            lbltutor.Visible = false;
            txtTutor.Visible = false;
            btnBuscarTutor.Visible = false;
            txtIdTutor.Visible = false;
        }

        private void TxtCorreoEstu_TextChanged1(object sender, EventArgs e)
        {
            var textBox = (System.Windows.Forms.TextBox)sender;
            if (textBox == TxtCorreoEstu)
            {
                lblcorreo.ForeColor = Validaciones.EsCorreoValido(TxtCorreoEstu.Text) ? Color.Green : Color.Red;
                // Actualizar los colores de los labels y validar si todos están en verde
                labelsVerdes = Validaciones.ValidarLabelsVerdes(lblcorreo);

                BtnGuardar.Enabled = labelsVerdes;
                btnActualizar.Enabled = labelsVerdes;
            }
        }

        NEstudiantes Estudiante = new NEstudiantes();
        public string FCedula;
        public string FNomAp;
        public string FDirec;
        public int FEdad;
        public int FCel;
        public string FCorreo;
        public string FNacionalidad;
        int idestudiante;
        public int IDEstu { get; set; }
        public string NomBEstu { get; set; }

        public  int idTutor;
        public  string NomTutor;



        private void INSERTAR()

        {
            FCedula = TxtCedEstu.Text;
            FNomAp = TxtNomEstu.Text;
            FDirec = TxtDirecEstu.Text;
            FEdad = int.Parse(TxtEdadEStu.Text);
            FCel = int.Parse(TxtCelEstu.Text);
            FCorreo = TxtCorreoEstu.Text;
            FNacionalidad = CBNacionalidad.Text;           
            Estudiante.AgregarEstudiante(FCedula, FNomAp, FDirec, FEdad, FCel, FCorreo, FNacionalidad,idTutor);
            MostrarEstudiante();
           
        }
        private void EditarEstudiantes()

        {
            FCedula = TxtCedEstu.Text;
            FNomAp = TxtNomEstu.Text;
            FDirec = TxtDirecEstu.Text;
            FEdad = int.Parse(TxtEdadEStu.Text);
            FCel = int.Parse(TxtCelEstu.Text);
            FCorreo = TxtCorreoEstu.Text;
            FNacionalidad = CBNacionalidad.Text;
            Estudiante.editarestudiante(idestudiante, FCedula, FNomAp, FDirec, FEdad, FCel, FCorreo, FNacionalidad,idTutor);
            MostrarEstudiante();
           
        }
        private void LimpiarCampos()
        {
            TxtCedEstu.Clear();
            TxtNomEstu.Clear();
            TxtDirecEstu.Clear();
            TxtEdadEStu.Clear();
            TxtCelEstu.Clear();
            TxtCorreoEstu.Clear();
            CBNacionalidad.Text = "";
        }
        private void MostrarEstudiante()
        {
            DataTable dt = new DataTable();
            NEstudiantes funcion = new NEstudiantes();
            funcion.MostarEstudiante(dt);
            dtEstudiantes.DataSource = dt;
            Bases.DiseñoDtv(ref dtEstudiantes);
            dtEstudiantes.Columns[3].Visible = false;
            dtEstudiantes.Columns[11].Visible = false;
        }
        private void TxtDirecEstu_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

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
        private void RegistroEstudiantes_Load(object sender, EventArgs e)
        {

            BtnGuardar.Enabled = false;
            //txtIdTutor.Text = idTutor.ToString();
            //txtTutor.Text = NomTutor;
        }
        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(TxtNomEstu.Text) && !string.IsNullOrEmpty(TxtDirecEstu.Text) && !string.IsNullOrEmpty(TxtCorreoEstu.Text) && !string.IsNullOrEmpty(TxtCedEstu.Text) && !string.IsNullOrEmpty(TxtEdadEStu.Text) && !string.IsNullOrEmpty(TxtCelEstu.Text) && !string.IsNullOrEmpty(CBNacionalidad.Text);
            BtnGuardar.Enabled = vr;
            btnActualizar.Enabled = vr;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            if (TxtCelEstu.Text.Length<8)
            {
                MessageBox.Show("los digitos del celular deben de ser 8");
            }
            else
            {
                try
                {
                    INSERTAR();
                    LimpiarCampos();
                    TxtNomEstu.Focus();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        private void dtEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtEstudiantes.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este estudiante?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarEstudiante();
                    MostrarEstudiante();
                }

            }
            if (e.ColumnIndex == dtEstudiantes.Columns["Editar"].Index)
            {
                if (int.TryParse(TxtEdadEStu.Text, out int edad) && edad <= 17)
                {
                    lbltutor.Visible = true;
                    txtTutor.Visible = true;
                    btnBuscarTutor.Visible = true;
                    txtIdTutor.Visible = true;
                }
                else
                {
                    lbltutor.Visible = false;
                    txtTutor.Visible = false;
                    btnBuscarTutor.Visible = false;
                    txtIdTutor.Visible = false;
                }
                CapturarDatos();
                btnActualizar.Visible = true;
                BtnGuardar.Visible = false;
            }
        }
        private void CapturarDatos()
        {

            idestudiante = int.Parse(dtEstudiantes.SelectedCells[3].Value.ToString());
            TxtCedEstu.Text = dtEstudiantes.SelectedCells[4].Value.ToString();
            TxtNomEstu.Text = dtEstudiantes.SelectedCells[5].Value.ToString();
            TxtDirecEstu.Text = dtEstudiantes.SelectedCells[6].Value.ToString();
            TxtEdadEStu.Text = dtEstudiantes.SelectedCells[7].Value.ToString();
            TxtCelEstu.Text = dtEstudiantes.SelectedCells[8].Value.ToString();
            TxtCorreoEstu.Text = dtEstudiantes.SelectedCells[9].Value.ToString();
            CBNacionalidad.Text = dtEstudiantes.SelectedCells[10].Value.ToString();
            NomTutor=txtTutor.Text=dtEstudiantes.SelectedCells[11].Value.ToString();
            

        }
       
        private void EliminarEstudiante()
        {
            idestudiante = int.Parse(dtEstudiantes.SelectedCells[3].Value.ToString());
            Estudiante.EliminarEstudiante(idestudiante);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EditarEstudiantes();
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Estudiante.BuscarEstudiante(dt, txtbuscar.Text);
            dtEstudiantes.DataSource = dt;
            Bases.DiseñoDtv(ref dtEstudiantes);
        }

        private void TxtNomEstu_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void TxtCorreoEstu_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void TxtCedEstu_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void TxtEdadEStu_TextChanged(object sender, EventArgs e)
        {

            ValidarCampos();
           
        }

        private void TxtCelEstu_TextChanged(object sender, EventArgs e)
        {
            
            ValidarCampos();
        }

        private void CBNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            ValidarCampos();
        }


        private void TxtEdadEStu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtCelEstu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNomEstu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letras(e);
        }

        private void TxtEdadEStu_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(TxtEdadEStu.Text, out int edad) && edad <= 17)
            {
                MessageBox.Show("Seleccione un tutor para el estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbltutor.Visible = true;
                txtTutor.Visible = true;
                btnBuscarTutor.Visible = true;
                txtIdTutor.Visible=true;
                
            }
            else
            {
                lbltutor.Visible = false;
                txtTutor.Visible = false;
                txtIdTutor.Visible = false;
                btnBuscarTutor.Visible = false;
            }
        }

        private void btnBuscarTutor_Click(object sender, EventArgs e)
        {
            SelecionarTutorcs st = new SelecionarTutorcs();

            if (st.ShowDialog() == DialogResult.OK)
            {
                // Después de que Form2 se cierre, puedes acceder a la propiedad DatoSeleccionado
                // para obtener el dato seleccionado y utilizarlo en Form1.
                 idTutor = st.idTutor;
                NomTutor = st.NombreTutor;

                // Haz algo con el dato en Form1
                txtTutor.Text = NomTutor;
                txtIdTutor.Text = idTutor.ToString();
            }
        }

        private void dtEstudiantes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDEstu = int.Parse(dtEstudiantes.SelectedCells[3].Value.ToString());
            NomBEstu = dtEstudiantes.SelectedCells[5].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    } 
}
