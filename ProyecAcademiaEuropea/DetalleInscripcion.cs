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
        public int IdDetalle;
        public double nota1;
        public double nota2;
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
            //dgvdetalle.Columns[2].Visible = false;
            //dgvdetalle.Columns[3].Visible = false;
            //dgvdetalle.Columns[4].Visible = false;
            //dgvdetalle.Columns[5].Visible = false;
        }

        private void DetalleInscripcion_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void PasarDatos()
        {
            try
            {
                IdDetalle = Convert.ToInt32(dgvdetalle.SelectedCells[2].Value);
                //nota1 = Convert.ToDouble(dgvdetalle.SelectedCells[8].Value.ToString());
                //nota2 = Convert.ToDouble(dgvdetalle.SelectedCells[9].Value.ToString());

                if (dgvdetalle.SelectedCells[8].Value== null)
                {
                    nota1 = 10;
                }
                if (dgvdetalle.SelectedCells[9].Value == null)
                {
                    nota2 = 0;
                }
                txtnota1.Text = nota1.ToString();
                txtnota2.Text = nota2.ToString();
                txtid.Text = IdDetalle.ToString();
                tabControl1.SelectedIndex = 1;
                if (nota1 != 0)
                {
                    semestre1.Enabled = false;
                }
                if (nota1 == 0)
                {
                    semestre1.Enabled = true;
                    semestre2.Enabled = false;
                }
                if (nota2 != 0)
                {
                    semestre2.Enabled = false;
                }
                if (nota2 == 0)
                {
                    semestre1.Enabled = true;
                    semestre2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
