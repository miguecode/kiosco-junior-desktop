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

        public static void ConfigurarDatosModificables(Producto productoIngresado, ComboBox tipo, TextBox nombre,
                                   TextBox marca, RichTextBox descripcion, NumericUpDown precio, NumericUpDown stock)
        {
            tipo.Text = productoIngresado.Tipo.ToString();
            nombre.Text = productoIngresado.Nombre;
            marca.Text = productoIngresado.Marca;
            descripcion.Text = productoIngresado.Descripcion.ToString();
            precio.Value = (decimal)productoIngresado.Precio;
            stock.Value = productoIngresado.Stock;
        }

        public static void ConfigurarDatosModificables(Usuario usuarioIngresado, ComboBox rol, Button verContrasenia,
                                   TextBox nombreUsuario, TextBox contrasenia , TextBox nombre, TextBox apellido, TextBox dni)
        {
            if (!(usuarioIngresado.Rol == ERol.Cliente))
                rol.Enabled = false;

            verContrasenia.Enabled = false;
            nombreUsuario.Enabled = false;
            contrasenia.Enabled = false;
            rol.Text = usuarioIngresado.Rol.ToString();
            nombre.Text = usuarioIngresado.Nombre;
            apellido.Text = usuarioIngresado.Apellido;
            dni.Text = usuarioIngresado.Dni.ToString();
            nombreUsuario.Text = usuarioIngresado.NombreUsuario;
            contrasenia.Text = usuarioIngresado.Contrasenia;
        }

    }
}