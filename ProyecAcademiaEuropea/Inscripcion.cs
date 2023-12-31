﻿using CapaDatos;
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
        public static string NombreEstudiante;
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
        private void AgregarCurso()
        {
            try
            {
                int IdIdioma = int.Parse(CBIdioma.SelectedValue.ToString());
                string Idioma = CBIdioma.Text;
                int IdNivel = int.Parse(CBNivel.SelectedValue.ToString());
                string Nivel = CBNivel.Text;
               

                dataCursos.Rows.Add(new object[]
                {
                    IdIdioma, Idioma, IdNivel, Nivel
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
            dtMatriculas.Columns[3].Visible = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            CBIdioma.Text = " ";
            CBNivel.Text = " ";
            TxtNomEstuIns.Clear();
            AgregarCurso();
        }
        private void Inscripcion_Load(object sender, EventArgs e)
        {
           MostrarDatos();
           button3.Enabled = false;
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
                        lst.Add(oConcepto);
                    }
                    LInscripcion parametros = new LInscripcion();
                    parametros.Idestudiante = Convert.ToInt32(txtIdEstudiante.Text);
                    parametros.Fecha = FechaIns.Value;
                    NInscripcion funcion = new NInscripcion();
                    funcion.InsertarInscripcion(parametros, lst);
                    MessageBox.Show("Se realizo la matricula con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.SelectedIndex = 0;
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
            NombreEstudiante =dtMatriculas.SelectedCells[5].Value.ToString();
            this.Hide();
            DetalleInscripcion da = new DetalleInscripcion();
            da.Idestudiante = IdEstudiante;
            da.Idinscripcion = IdInscripcion;
            da.nombreestudiante = NombreEstudiante;
            da.ShowDialog();

        }
        private void dtMatriculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtMatriculas.Columns["Ver1"].Index)
            {
                PasarIdInscripcion();
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(TxtNomEstuIns.Text) && !string.IsNullOrEmpty(CBIdioma.Text) && !string.IsNullOrEmpty(CBNivel.Text);
            button3.Enabled = vr;
            
        }

        private void TxtNomEstuIns_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void CBIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void CBNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FechaIns_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
