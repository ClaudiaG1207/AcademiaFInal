using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaNegocio
{
    public class NIdioma
    {
        DIdioma Idioma = new DIdioma();
        public void AgregarIdioma(string NombreIdioma)
        {
            Idioma.Insertaridioma(NombreIdioma);
        }
        public void EliminarIdioma(int id)
        {
            Idioma.EliminarIdioma(id);
        }
        public void EditarIdioma(int id, string idioma)
        {
            Idioma.editarIdioma(id, idioma);
        }
        public void MostarIdioma(DataTable dt)
        {
            Idioma.MostarIdioma(ref dt);
        }
        public void MostrarNivel(ComboBox combo)
        {
            Idioma.MostrarNivel(combo);
        }
        public void MostrarIdiomaCombo(ComboBox combo)
        {
            Idioma.MostrarIdiomaCombo(combo);
        }

    }
}
