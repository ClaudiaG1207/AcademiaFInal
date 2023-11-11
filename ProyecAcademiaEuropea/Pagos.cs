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
    public partial class Pagos : Form
    {
        public  int idDetalle;
        public string curso1;
        public double monto;
        public Pagos()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void CargarDatos()
        {
            txtidcurso.Text=idDetalle.ToString();
            txtcurso.Text = curso1;
           TxtMonto.Text= monto.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal FP = new FormPrincipal();
            FP.Show();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            NInscripcion ni = new NInscripcion();
            int id = int.Parse(txtidcurso.Text);
            ni.PagarUnCurso(id);
        }
    }
}
