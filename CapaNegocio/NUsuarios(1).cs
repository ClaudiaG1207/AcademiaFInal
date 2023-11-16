using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NUsuarios
    {

        DUsuarios Usuariop = new DUsuarios();
        Hash hashPassword = new Hash();

        public void AgregarUsuario( string NombreUsuario, string Contrasena)
        {
            string ContrasenaHasheada = hashPassword.PasswordHash(Contrasena);
            Usuariop.Insertar( NombreUsuario, ContrasenaHasheada);
        }
        public void EditarUS(int id, string NombreUsuario, string Contrasena)
        {
            string ContrasenaHasheada = hashPassword.PasswordHash(Contrasena);
            Usuariop.editarUsuario(id, NombreUsuario, ContrasenaHasheada);
        }
        public void MostarUsuarios(DataTable dt)
        {
            Usuariop.MostarUsuarios(ref dt);
        }      
        public bool LoginUsuario(string NombreUsuario, string ContrasenaUser)
        {
            string PassHasheada = Usuariop.Login(NombreUsuario);
            bool Verificar;
            
            if (hashPassword.VerifyPassword(ContrasenaUser, PassHasheada) == true)
            {
                Verificar = true;
            }
            else
            {
                Verificar = false;
            }
            return Verificar;
        }
        private string GenerarNuevaContraseña()
        {
            Random rd = new Random();
            string CaracteresPassword = "ABDCEFGHIJKLMNOPQRSTUVWXZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder NewPassword = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                int Indice = rd.Next(CaracteresPassword.Length);
                NewPassword.Append(CaracteresPassword[Indice]);
            }
            string NuevaContrasena = NewPassword.ToString();
            //string NuevaContraHasheada = hashPassword.PasswordHash(ContrasenaNueva);
            //Aqui llamaría al metodo para actualizar la contraseña en la base de datos.
            return NuevaContrasena;
        }
        private void EnviarCorreo(string CorreoGmail, string ContraseñaGenerada)
        {
            string ContraseñaGmail = "lsor esio tzeb njsu";
            string mensaje = string.Empty;

            string Destinatario = CorreoGmail;
            string Remitente = "claudiatamaraguevagarcia12@gmail.com";
            string Asunto = "Nueva Contraseña De Acceso A \"Academia Europea\"";
            string CuerpoMensaje = "Su nueva contraseña para acceder al sistema es " + ContraseñaGenerada + "\n\nSi no solicitó restablecer su contraseña, " +
                "puede ignorar este mensaje. Puede obtener más información sobre por qué pudo haber recibido este correo electrónico comunicandose con el administrador."
                + "\n\nMuchas Gracias," + "\n\nThe Development Team >:(";

            MailMessage message = new MailMessage(Remitente, Destinatario, Asunto, CuerpoMensaje);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential(Remitente, ContraseñaGmail);
            try
            {
                Task.Run(() =>
                {
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    smtp.Send(message);
                    message.Dispose();
                }
                );
            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
        }
        public void RecuperacionContraseña(string CorreoUsuario)
        {
            //Almacena la contraseña random generada.
            string NewPassword = GenerarNuevaContraseña();
            EnviarCorreo(CorreoUsuario, NewPassword);
        }
        public void EliminarUsuario(int id)
        {
            Usuariop.EliminarUsuario(id);
        }
        public void MostarCargos(ComboBox combo)
        {
            Usuariop.MostrarCargo(combo);
        }
        readonly DUsuarios objd = new DUsuarios();
        public DataTable NLogin(string usuario, string clave)
        {
            string ContrasenaHasheada = hashPassword.PasswordHash(clave);
            return objd.D_Usuarios(usuario,ContrasenaHasheada);
        }
    }


}
