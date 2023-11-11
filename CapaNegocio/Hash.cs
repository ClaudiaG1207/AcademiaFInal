using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace CapaNegocio
{
    public class Hash
    {
        public  string PasswordHash(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            return hashedPassword;
        }
        public  bool VerifyPassword(string inputPassword, string hashpas)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, hashpas);
        }
    }
}
