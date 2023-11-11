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
    public partial class SelecionarTutorcs : Form
    {
        public SelecionarTutorcs()
        {
            InitializeComponent();
        }

        private void MostrarTutor()
        {
            DataTable dt = new DataTable();
            NTutor funcion = new NTutor();
            funcion.MostarTutor(dt);
            dtTutor.DataSource = dt;
            Bases.DiseñoDtv(ref dtTutor);
            dtTutor.Columns[0].Visible = false;
            dtTutor.Columns[1].Visible = false;
            dtTutor.Columns[3].Visible = false;
            dtTutor.Columns[4].Visible = false;
            dtTutor.Columns[5].Visible = false;
            dtTutor.Columns[6].Visible = false;
            dtTutor.Columns[7].Visible = false;


        }

        private void SelecionarTutorcs_Load(object sender, EventArgs e)
        {
            MostrarTutor();
        }
        public  int idTutor { get; set; }
        public  string NombreTutor { get; set; }


        private void Datos()
        {
            idTutor = int.Parse(dtTutor.SelectedCells[0].Value.ToString());
            NombreTutor = dtTutor.SelectedCells[2].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
  
        private void dtTutor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Datos();
        }
    }
}
