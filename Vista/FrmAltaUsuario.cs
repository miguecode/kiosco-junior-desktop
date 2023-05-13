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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmAltaUsuario : Form
    {
        private Usuario usuarioIngresado;
        private bool esUsuarioNuevo;

        public Usuario UsuarioIngresado { get => usuarioIngresado; }

        public FrmAltaUsuario(Usuario usuarioIngresado, bool esUsuarioNuevo)
        {
            InitializeComponent();
            this.usuarioIngresado = usuarioIngresado;
            this.esUsuarioNuevo = esUsuarioNuevo;
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            if (!esUsuarioNuevo)
                RecibirDatosDelUsuarioAModificar();
        }

        private void RecibirDatosDelUsuarioAModificar()
        {
            txt_NombreDeUsuario.Enabled = false;
            txt_Contrasenia.Enabled = false;
            cmb_Rol.Text = usuarioIngresado.Rol.ToString();
            txt_Nombre.Text = usuarioIngresado.Nombre;
            txt_Apellido.Text = usuarioIngresado.Apellido;
            txt_Dni.Text = usuarioIngresado.Dni.ToString();
            txt_NombreDeUsuario.Text = usuarioIngresado.NombreUsuario;
            txt_Contrasenia.Text = usuarioIngresado.Contrasenia;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {              
                Validador.ValidarDatosUsuario(cmb_Rol.SelectedItem, txt_Nombre.Text, txt_Apellido.Text,
                                                txt_Dni.Text, txt_NombreDeUsuario.Text, txt_Contrasenia.Text);

                AsignarDatosAlUsuario();

                if (esUsuarioNuevo)
                    VerificarSiExisteUsuario(usuarioIngresado);

                this.DialogResult = DialogResult.OK;
            }catch (Exception ex)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
        }
     
        private void AsignarDatosAlUsuario()
        {
            _ = Enum.TryParse(cmb_Rol.SelectedItem.ToString(), out ERol rol);
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            int dni = int.Parse(txt_Dni.Text);
            string nombreDeUsuario = txt_NombreDeUsuario.Text;
            string contrasenia = txt_Contrasenia.Text;

            usuarioIngresado.Rol = rol;
            usuarioIngresado.Nombre = nombre;
            usuarioIngresado.Apellido = apellido;
            usuarioIngresado.Dni = dni;
            usuarioIngresado.NombreUsuario = nombreDeUsuario;
            usuarioIngresado.Contrasenia = contrasenia;
        }

        private void btn_VerContrasenia_Click(object sender, EventArgs e)
        {
            if (!txt_Contrasenia.UseSystemPasswordChar)
                txt_Contrasenia.UseSystemPasswordChar = true;

            else
                txt_Contrasenia.UseSystemPasswordChar = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void VerificarSiExisteUsuario(Usuario usuarioIngresado)
        {
            foreach (Usuario usuario in Sistema.ListaDeUsuarios)
            {
                if (usuario == usuarioIngresado)
                    throw new Exception("Ese usuario ya existe");
            }
        }
    }
}
