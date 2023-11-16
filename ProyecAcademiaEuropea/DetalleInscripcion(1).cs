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
        public  int Idestudiante;
        public  int Idinscripcion;
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
            funcion.MostrarInscripcionDetalle(dt,idestudiante,idinscripcion);
            Bases.DiseñoDtv(ref dgvdetalle);
        }

        private void DetalleInscripcion_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Sumar();
        }
        private void Sumar()
        {
            // Variables para almacenar la suma y el estado a buscar
            decimal sumaTotal = 0;
            string estadoBuscado = "Pendiente";

            // Itera a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dgvdetalle.Rows)
            {
                // Asegúrate de que la fila no sea la fila de encabezados
                if (!fila.IsNewRow)
                {
                    // Obtiene el valor de la columna "Estado"
                    string estado = fila.Cells[9].Value as string;

                    // Comprueba si el estado coincide con "pendiente"
                    if (estado == estadoBuscado)
                    {
                        // Obtiene el valor de la columna "Cantidad"
                        decimal cantidad = Convert.ToDecimal(fila.Cells[8].Value);

                        // Agrega la cantidad a la suma total
                        sumaTotal += cantidad;
                    }
                }
            }

            // La variable sumaTotal ahora contiene la suma de "Cantidad" donde el "Estado" es "pendiente"
           // MessageBox.Show("La suma de cantidades con estado 'pendiente' es: " + sumaTotal.ToString());
           lbldeuda.Text= sumaTotal.ToString();

        }
        private void PasarDatos()
        {
            IdDetalle = Convert.ToInt32(dgvdetalle.SelectedCells[2].Value);           
            Curso = dgvdetalle.SelectedCells[6].Value.ToString();
            Monto = Convert.ToDouble(dgvdetalle.SelectedCells[8].Value);
            Pagos p = new Pagos();
            p.idDetalle = IdDetalle;
            p.curso1 = Curso;
            p.monto = Monto;
            p.ShowDialog();
        }

        private void dgvdetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvdetalle.Columns["Pagar"].Index)
            {
                PasarDatos();
            }
        }
    }
}
