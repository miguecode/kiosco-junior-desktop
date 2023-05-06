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

                _ = Enum.TryParse(cmb_Rol.SelectedItem.ToString(), out ERol rolSeleccionado);

                usuarioCreado = new Usuario(txt_Nombre.Text, txt_Apellido.Text, int.Parse(txt_Dni.Text),
                        txt_NombreDeUsuario.Text, txt_Contrasenia.Text, rolSeleccionado);

                this.DialogResult = DialogResult.OK;
            }catch (Exception ex)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
        }

        private void ValidarDatosUsuario()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos no válidos:");

            if (!Validador.ValidarItemEnumerado(cmb_Rol.SelectedItem, typeof(ERol)))
                sb.AppendLine("- Rol");

            if (!Validador.ValidarStringConLetraSinDigitoYRango(txt_Nombre.Text, 2, 24))
                sb.AppendLine("- Nombre");

            if (!Validador.ValidarStringConLetraSinDigitoYRango(txt_Apellido.Text, 2, 24))               
                sb.AppendLine("- Apellido");

            if (!Validador.ValidarStringNumericoRango(txt_Dni.Text, 7, 9))
                sb.AppendLine("- DNI");

            if (!Validador.ValidarStringConLetraDigitoYRango(txt_NombreDeUsuario.Text, 4, 17))
                sb.AppendLine("- Nombre de Usuario");

            if (!Validador.ValidarStringRango(txt_Contrasenia.Text, 7, 17))
                sb.AppendLine("- Contraseña");

            if (sb.Length > 19)
            {
                throw new Exception(sb.ToString());
            }
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
