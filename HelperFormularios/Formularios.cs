using Entidades;
using Helper;

namespace HelperFormularios
{
    public static class Formularios
    {
        


        public static void LimpiarPantalla(TextBox textBoxNombre, TextBox textBoxContrasenia, Label labelError)
        {
            textBoxNombre.Text = string.Empty;
            textBoxContrasenia.Text = string.Empty;
            labelError.Visible = false;
        }















    }
}