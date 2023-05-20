using Entidades;
using Helper;

namespace HelperFormularios
{
    public static class Formularios
    {
        public static void MostrarFormularioHijo(Form formulario, Type tipoFormulario, Panel panelInicio)
        {
            foreach (Form itemFormulario in formulario.MdiChildren)
            {
                if (itemFormulario.GetType() != tipoFormulario)
                    itemFormulario.Hide();

                else
                {
                    panelInicio.SendToBack();
                    itemFormulario.WindowState = FormWindowState.Maximized;
                    itemFormulario.Show();
                }
            }
        }






    }
}