using Entidades;
using Helper;

namespace HelperFormularios
{
    public static class Formularios
    {
        /// <summary>
        /// Revisa cada formulario hijo del formulario contenedor MDI. Cuando llegue al
        /// tipo de formulario que recibió por parámetro, lo muestra. A todos los demás, los esconde.
        /// </summary>
        /// <param name="formulario"></param>
        /// <param name="tipoFormulario"></param>
        /// <param name="panelInicio"></param>
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

        /// <summary>
        /// Recibe los valores de los datos del usuario que se haya ingresado.
        /// Se encarga de cargarle esos datos a los controles del formulario recibidos por parámetros.
        /// </summary>
        /// <param name="usuarioIngresado"></param>
        /// <param name="rol"></param>
        /// <param name="verContrasenia"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public static void ConfigurarDatosModificables(Usuario usuarioIngresado, ComboBox rol, Button verContrasenia,
                           TextBox nombreUsuario, TextBox contrasenia, TextBox nombre, TextBox apellido, TextBox dni)
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
    }
}