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
                usuarioIngresado = Autenticacion.ConfirmarIngreso(txt_Nombre.Text, txt_Contrasenia.Text);
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
            if (Sistema.ListaDeUsuarios.Count > 0)
            {
                Random rnd = new Random();
                int numeroRandom = rnd.Next(0, Sistema.ListaDeUsuarios.Count);

                txt_Contrasenia.UseSystemPasswordChar = true;
                txt_Nombre.Text = Sistema.ListaDeUsuarios[numeroRandom].NombreUsuario;
                txt_Contrasenia.Text = Sistema.ListaDeUsuarios[numeroRandom].Contrasenia;
            }
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            if (!txt_Contrasenia.UseSystemPasswordChar)
                txt_Contrasenia.UseSystemPasswordChar = true;

            else
                txt_Contrasenia.UseSystemPasswordChar = false;
        }

        private void btn_IngresarAdmin_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Sistema.ListaDeUsuarios)
            {
                if(usuario.Rol == ERol.SuperUsuario)
                {
                    IngresarRapidoPorUsuario(usuario);
                    break;
                }
            }
        }

        private void btn_IngresarEmpleado_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Sistema.ListaDeUsuarios)
            {
                if (usuario.Rol == ERol.Empleado)
                {
                    IngresarRapidoPorUsuario(usuario);
                    break;
                }
            }
        }

        private void btn_IngresarCliente_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Sistema.ListaDeUsuarios)
            {
                if (usuario.Rol == ERol.Cliente)
                {
                    IngresarRapidoPorUsuario(usuario);
                    break;
                }
            }
        }

        public void LimpiarDatos()
        {
            txt_Nombre.Text = String.Empty;
            txt_Contrasenia.Text = String.Empty;
            lbl_Error.Visible = false;
            txt_Contrasenia.UseSystemPasswordChar = true;
        }

        private void IngresarRapidoPorUsuario(Usuario usuario)
        {
            usuarioIngresado = usuario;
            FrmPrincipal formPrincipal = new FrmPrincipal(this);
            formPrincipal.Show();
            this.Hide();
        }
    }
}
