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
    public partial class FrmLogin : Form
    {
        private Usuario usuarioIngresado;
        public Usuario UsuarioIngresado { get => usuarioIngresado; }

        public FrmLogin()
        {
            InitializeComponent();
            usuarioIngresado = new Usuario();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioIngresado = Sistema.ConfirmarIngreso(txt_Nombre.Text, txt_Contrasenia.Text);
                FrmPrincipal formPrincipal = new FrmPrincipal(this);
                formPrincipal.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                lbl_Error.Text = ex.Message;
                lbl_Error.Visible = true;
            }
        }

        private void btn_Autocompletar_Click(object sender, EventArgs e)
        {
            List<Usuario> listaDeUsuarios = Sistema.ListaDeUsuarios;

            Random rnd = new Random();
            int numeroRandom = rnd.Next(0, listaDeUsuarios.Count);

            txt_Nombre.Text = listaDeUsuarios[numeroRandom].NombreUsuario;
            txt_Contrasenia.Text = listaDeUsuarios[numeroRandom].Contrasenia;
        }

        public void LimpiarPantalla()
        {
            txt_Nombre.Text = String.Empty;
            txt_Contrasenia.Text = String.Empty;
            lbl_Error.Visible = false;
        }
    }
}
