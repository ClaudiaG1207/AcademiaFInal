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
        public double notafinal;
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
                if (dgvdetalle.SelectedCells.Count > 9) // Verificar si hay al menos 10 celdas seleccionadas
                {
                    IdDetalle = Convert.ToInt32(dgvdetalle.SelectedCells[2].Value);

                    // Verificar si las celdas no están vacías o son nulas antes de convertirlas
                    if (!string.IsNullOrEmpty(dgvdetalle.SelectedCells[8].Value?.ToString()))
                    {
                        nota1 = Convert.ToDouble(dgvdetalle.SelectedCells[8].Value.ToString());
                        txtnota1.Text = nota1.ToString();
                    }
                    else
                    {
                        txtnota1.Text = " ";
                    }

                    if (!string.IsNullOrEmpty(dgvdetalle.SelectedCells[9].Value?.ToString()))
                    {
                        nota2 = Convert.ToDouble(dgvdetalle.SelectedCells[9].Value.ToString());
                        txtnota2.Text = nota2.ToString();
                    }
                    else
                    {
                        txtnota2.Text = " ";
                    }

                    if (!string.IsNullOrEmpty(dgvdetalle.SelectedCells[10].Value?.ToString()))
                    {
                        notafinal = Convert.ToDouble(dgvdetalle.SelectedCells[10].Value.ToString());
                    }
                    else
                    {
                        notafinal = 0; // Asignar un valor predeterminado o dejarlo como cero si no hay datos
                    }

                    txtid.Text = IdDetalle.ToString();
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Selecciona una fila válida.");
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscripcion ins = new Inscripcion();
            ins.Show();
        }

        private void btnGuardarNota1_Click(object sender, EventArgs e)
        {
            PasarDatos();
            NNotas pasarno = new NNotas();
            pasarno.AgregarNotas(nota1,nota2,notafinal, IdDetalle);
        }


        private void dgvdetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
