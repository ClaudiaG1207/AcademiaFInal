using CapaDatos;
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
    public partial class DetalleInscripcion : Form
    {
        public int Idestudiante;
        public int Idinscripcion;
        public string nombreestudiante;
        public static int IdDetalle;
        public static string Curso;
        public static double Monto;
        public DetalleInscripcion()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            DataTable dt = new DataTable();
            dgvdetalle.DataSource = dt;
            int idestudiante = Idestudiante;
            int idinscripcion = Idinscripcion;
            NInscripcion funcion = new NInscripcion();
            lblestudiante.Text = nombreestudiante;
            funcion.MostrarInscripcionDetalle(dt, idestudiante, idinscripcion);
            Bases.DiseñoDtv(ref dgvdetalle);
            dgvdetalle.Columns[2].Visible = false;
            dgvdetalle.Columns[3].Visible = false;
            dgvdetalle.Columns[4].Visible = false;
            dgvdetalle.Columns[5].Visible = false;
        }

        private void DetalleInscripcion_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void PasarDatos()
        {
            IdDetalle = Convert.ToInt32(dgvdetalle.SelectedCells[2].Value);
            Curso = dgvdetalle.SelectedCells[6].Value.ToString();
            Monto = Convert.ToDouble(dgvdetalle.SelectedCells[8].Value);
            tabControl1.SelectedIndex = 1;
        }

        private void dgvdetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvdetalle.Columns[1].Index)
            {
                PasarDatos();
            }
        }
    }
}
