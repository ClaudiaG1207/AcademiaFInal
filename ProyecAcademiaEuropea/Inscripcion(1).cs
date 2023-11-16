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
    public partial class Inscripcion : Form
    {
        public int IDESTU;
        public string nomEStu;
        public static int IdEstudiante;
        public static int IdInscripcion;
        public Inscripcion()
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal FP = new FormPrincipal();
            FP.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscarestudiante_Click(object sender, EventArgs e)
        {
            RegistroEstudiantes re = new RegistroEstudiantes();

            if (re.ShowDialog() == DialogResult.OK)
            {
                // Después de que Form2 se cierre, puedes acceder a la propiedad DatoSeleccionado
                // para obtener el dato seleccionado y utilizarlo en Form1.
                IDESTU = re.IDEstu;
                nomEStu = re.NomBEstu;

                // Haz algo con el dato en Form1
                TxtNomEstuIns.Text = nomEStu;
                txtIdEstudiante.Text = IDESTU.ToString();
            }

        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            Pagos pagos = new Pagos();
            pagos.Show();
        }
        private void AgregarCurso()
        {
            try
            {
                int IdIdioma = int.Parse(CBIdioma.SelectedValue.ToString());
                string Idioma = CBIdioma.Text;
                int IdNivel = int.Parse(CBNivel.SelectedValue.ToString());
                string Nivel = CBNivel.Text;
                string Semestre = CBSemestre.Text;
                string Grupo = CBGrupo.Text;

                dataCursos.Rows.Add(new object[]
                {
                    IdIdioma, Idioma, IdNivel, Nivel, Semestre, Grupo
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void MostrarDatos()
        {
            NIdioma NI = new NIdioma();
            NI.MostrarNivel(CBNivel);
            NI.MostrarIdiomaCombo(CBIdioma);
            NInscripcion nInscripcion = new NInscripcion();
            DataTable dt = new DataTable();
            dtMatriculas.DataSource = dt;
            nInscripcion.MostrarInscripcion(dt);
            Bases.DiseñoDtv(ref dtMatriculas);
            //dtMatriculas.Columns[3].Visible = false;
            //dtMatriculas.Columns[4].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarCurso();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            MostrarDatos();

            Bases.DiseñoDtv(ref dataCursos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarInscripcion();
            MostrarDatos();
        }
        private void GuardarInscripcion()
        {
            try
            {
                if (dataCursos.Rows.Count == 0)
                {
                    MessageBox.Show("Sin registros");
                }
                else
                {
                    List<LInscripcion> lst = new List<LInscripcion>();
                    foreach (DataGridViewRow dr in dataCursos.Rows)
                    {
                        LInscripcion oConcepto = new LInscripcion();
                        oConcepto.IdIdioma = int.Parse(dr.Cells[0].Value.ToString());
                        oConcepto.IdNivel = int.Parse(dr.Cells[2].Value.ToString());
                        oConcepto.Semestre = dr.Cells[4].Value.ToString();
                        oConcepto.Grupo = dr.Cells[5].Value.ToString();
                        lst.Add(oConcepto);
                    }
                    LInscripcion parametros = new LInscripcion();
                    parametros.Idestudiante = Convert.ToInt32(txtIdEstudiante.Text);
                    parametros.Fecha = FechaIns.Value;
                    NInscripcion funcion = new NInscripcion();
                    funcion.InsertarInscripcion(parametros, lst);
                    MessageBox.Show("Se realizo la matricula con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataCursos.Rows.Clear();
                    dataCursos.Columns.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void PasarIdInscripcion()
        {
            IdEstudiante = Convert.ToInt32(dtMatriculas.SelectedCells[4].Value);
            IdInscripcion = Convert.ToInt32(dtMatriculas.SelectedCells[3].Value);
            DetalleInscripcion da = new DetalleInscripcion();
            da.Idestudiante = IdEstudiante;
            da.Idinscripcion = IdInscripcion;
            da.ShowDialog();
        }

        private void dtMatriculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtMatriculas.Columns["Ver"].Index)
            {
                PasarIdInscripcion();
            }
        }
    }
}
