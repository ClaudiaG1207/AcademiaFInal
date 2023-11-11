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
        NTutor tuto = new NTutor();
        public string FCedula;
        public string FNomAp;
        public string FDirec;
        public int FEdad;
        public int FCel;
        public string FCorreo;
        public string FNacionalidad;
        int idTutor;
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
            FNomAp = TxtNomTutor.Text;
            FDirec = TxtDirecTutor.Text;
            FEdad = int.Parse(TxtEdadTutor.Text);
            FCel = int.Parse(TxtCelTutor.Text);
            FCorreo = TxtCorreoTutor.Text;
            FNacionalidad = CBNacionalidad.Text;
            tuto.AgregarTutor(FCedula, FNomAp, FDirec, FEdad, FCel, FCorreo, FNacionalidad);
            MostrarTutor();

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
            FNomAp = TxtNomTutor.Text;
            FDirec = TxtDirecTutor.Text;
            FEdad = int.Parse(TxtEdadTutor.Text);
            FCel = int.Parse(TxtCelTutor.Text);
            FCorreo = TxtCorreoTutor.Text;
            FNacionalidad = CBNacionalidad.Text;
            tuto.EditarTutor(idTutor, FCedula, FNomAp, FDirec, FEdad, FCel, FCorreo, FNacionalidad);
            MostrarTutor();

        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            INSERTAR();
            LimpiarCampos();
            MostrarTutor();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal FP = new FormPrincipal();
            FP.Show();
        }
    }
}
