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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroEstudiantes E = new RegistroEstudiantes();
            E.Show();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            this.Hide();
          ResgistroPersonal P = new ResgistroPersonal();
            P.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           // LblNombre.Text = Login.Nombre;
        }

        private void txtusuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuarios u = new frmUsuarios();
            u.Show();
        }

        private void PBLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagos Pag = new Pagos();
            Pag.Show();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscripcion IN = new Inscripcion();
            IN.Show();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {

            this.Hide();
            RegistroIdioma ID = new RegistroIdioma();
            ID.Show();
        }

        private void btnAcercadeNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nosotros nos = new Nosotros();
            nos.Show();
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //nivel nil = new nivel();
            //nil.Show();
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nota nota = new Nota();
            nota.Show();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorEstudiante tuto = new TutorEstudiante();
            tuto.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Pagos pag = new Pagos ();
            pag.Show();

        }
    }
}
