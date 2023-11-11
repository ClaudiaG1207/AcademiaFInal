using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyecAcademiaEuropea
{
    public partial class CorreoRecu : Form
    {
        NUsuarios us = new NUsuarios();
        public CorreoRecu()
        {
            InitializeComponent();
        }
        
        private void CorreoRecu_Load(object sender, EventArgs e)
        {

        }

       
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CorreoRecu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LG = new Login();
            LG.Show();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (TxtCorreo.Text))
            {
                MessageBox.Show("Campos Vacios", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                us.RecuperacionContraseña(TxtCorreo.Text);
                MessageBox.Show("Se envio correo", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
