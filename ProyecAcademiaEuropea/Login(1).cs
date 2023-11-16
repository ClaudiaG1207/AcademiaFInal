using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyecAcademiaEuropea;
using System.Security.Cryptography;
using BCrypt.Net;
using System.Reflection.Emit;
using CapaNegocio;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyecAcademiaEuropea
{
    public partial class Login : Form
    {
        public static string Usuario;
        public static string clave;
        public static int idPersonal;
        public static string NombrePersonal;
        public static string Correo;
        public static string Cargo;
        FormPrincipal f = new FormPrincipal();
        NUsuarios nuser = new NUsuarios();
        FormPrincipal FP = new FormPrincipal();
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public static int IdUsuario;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.White;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = Color.White;

            }
        }

        private void TxtContra_Enter(object sender, EventArgs e)
        {
            if (TxtContra.Text == "CONTRASEÑA")
            {
                TxtContra.Text = "";
                TxtContra.ForeColor = Color.White;
                TxtContra.UseSystemPasswordChar = true;
            }
        }

        private void TxtContra_Leave(object sender, EventArgs e)
        {
            if (TxtContra.Text == "")
            {
                TxtContra.Text = "CONTRASEÑA";
                TxtContra.ForeColor = Color.White;
                TxtContra.UseSystemPasswordChar = false;
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "USUARIO")
            {

            }
            else { }
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Logueo();
            NUsuarios us = new NUsuarios();
            if (TxtUsuario.Text != "USUARIO")
            {

                if (us.LoginUsuario(TxtUsuario.Text, TxtContra.Text) == true)
                {

                    FP.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    TxtUsuario.Clear();
                    TxtContra.Clear();

                    if (TxtContra.Text == "")
                    {
                        TxtContra.Text = "CONTRASEÑA";
                        TxtContra.ForeColor = Color.White;
                        TxtContra.UseSystemPasswordChar = false;
                    }
                    if (TxtUsuario.Text == "")
                    {
                        TxtUsuario.Text = "USUARIO";
                        TxtUsuario.ForeColor = Color.White;
                    }

                }


            }
            else smsERROR("CAMPOS VACIOS");

        }
        private void Logueo()
        {
            if (string.IsNullOrEmpty(TxtUsuario.Text) || string.IsNullOrEmpty(TxtContra.Text))
            {
                MessageBox.Show("Los campos estan vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUsuario.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                Usuario = TxtUsuario.Text;
                clave = TxtContra.Text;

                try
                {
                    dt = nuser.NLogin(Usuario, clave);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        idPersonal = Convert.ToInt32(dt.Rows[0][0]);
                        NombrePersonal = dt.Rows[0][1].ToString();
                        Correo = dt.Rows[0][2].ToString();
                        Cargo = dt.Rows[0][2].ToString();
                        Usuario = dt.Rows[0][4].ToString();
                        f.Show();
                        this.Hide();
                        TxtContra.Clear();
                        TxtUsuario.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void smsERROR(string sms)
        {
            LbError.Text = "    " + sms;
            LbError.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CorreoRecu Re = new CorreoRecu();
            Re.Show();


        }

        private void LbError_Click(object sender, EventArgs e)
        {

        }
    }
}
