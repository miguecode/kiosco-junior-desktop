using Entidades;
using Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAltaUsuario : Form
    {
        private Usuario usuarioCreado;
        public Usuario UsuarioCreado { get => usuarioCreado; }

        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDatosUsuario();
                //ValidarUsuarioExistente(UsuarioCreado);
                //Buscar si el usuario ya existe

                ERol rolSeleccionado = (ERol)Enum.Parse(typeof(ERol), cmb_Rol.SelectedItem.ToString());

                //ERol rolSeleccionado = (ERol) cmb_Rol.SelectedItem;

                usuarioCreado = new Usuario(txt_Nombre.Text, txt_Apellido.Text, int.Parse(txt_Dni.Text),
                              txt_NombreDeUsuario.Text, txt_Contrasenia.Text, rolSeleccionado);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
        }

        private void ValidarDatosUsuario()
        {
            if (!(ValidarRolDeUsuario() && ValidarStringDeUsuario(txt_Nombre.Text)
                && ValidarStringDeUsuario(txt_Apellido.Text) && ValidarDniDeUsuario(txt_Dni.Text)
                && ValidarStringDeUsuario(txt_NombreDeUsuario.Text) && ValidarContraseniaDeUsuario(txt_Contrasenia.Text)))
            {
                throw new Exception("Datos invalidos");
            }
        }

        private bool ValidarStringDeUsuario(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) || cadena.Length > 14)
                return false;

            // Verifica si el nombre contiene caracteres no válidos.
            foreach (char caracter in cadena)
            {
                if (!char.IsLetter(caracter) && caracter != ' ' && caracter != '-')
                {
                    return false;
                }
            }

            // Verifica si el nombre contiene más de un espacio seguido o un guión seguido.
            for (int i = 0; i < cadena.Length - 1; i++)
            {
                if ((cadena[i] == ' ' && cadena[i + 1] == ' ') || (cadena[i] == '-' && cadena[i + 1] == '-'))
                {
                    return false;
                }
            }

            return true;
        }

        private bool ValidarContraseniaDeUsuario(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) || cadena.Length > 14)
                return false;

            // Verifica si el nombre contiene caracteres no válidos.
            foreach (char caracter in cadena)
            {
                if (!char.IsLetterOrDigit(caracter))
                {
                    return false;
                }
            }

            return true;
        }

        private bool ValidarDniDeUsuario(string dniString)
        {
            return dniString.Length == 8 && int.TryParse(dniString, out _);
            //Si es igual a 8 y se puede parsear a Int, devuelve true
        }

        private bool ValidarRolDeUsuario()
        {
            return cmb_Rol.SelectedItem != null;
        }

        private void btn_VerContrasenia_Click(object sender, EventArgs e)
        {
            if(!txt_Contrasenia.UseSystemPasswordChar)
            {
                txt_Contrasenia.UseSystemPasswordChar = true;
            }else
            {
                txt_Contrasenia.UseSystemPasswordChar = false;
            }           
        }

        private void ValidarUsuarioExistente(Usuario usuarioRecibido)
        {
            foreach (Usuario usuario in Sistema.ListaDeUsuarios)
            {
                if (usuario == usuarioRecibido)
                {
                    throw new Exception("Ese usuario ya existe");
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
