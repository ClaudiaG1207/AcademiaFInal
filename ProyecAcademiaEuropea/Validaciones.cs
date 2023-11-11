using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecAcademiaEuropea
{
    public class Validaciones
    {
        public static bool EsCorreoValido(string correo)
        {
            // Expresión regular para validar el formato del correo
            string patronCorreo = @"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com|hotmail\.com|estu\.unan\.edu\.ni|\w+\.(com|es|net|org))$";

            // Realizar la validación del formato utilizando la expresión regular
            bool formatoValido = System.Text.RegularExpressions.Regex.IsMatch(correo, patronCorreo);

            // Retorna el resultado de la validación de formato
            return formatoValido;
        }

        public static bool ValidarLabelsVerdes( Label lblCorreo)
        {
            return
                 lblCorreo.ForeColor == Color.Green;
                
        }
    }
}
