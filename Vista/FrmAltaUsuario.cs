using Entidades;
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
                && ValidarStringDeUsuario(txt_Apellido.Text) && ValidarDniUsuario(txt_Dni.Text)
                && ValidarStringDeUsuario(txt_NombreDeUsuario.Text) && ValidarStringDeUsuario(txt_Contrasenia.Text)))
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

        private bool ValidarDniUsuario(string dniString)
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
            txt_Contrasenia.UseSystemPasswordChar = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
