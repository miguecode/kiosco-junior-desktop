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
    public partial class FrmInfoUsuario : Form
    {
        private FrmLogin formLogin;

        public FrmInfoUsuario(FrmLogin formLoginRecibido)
        {
            InitializeComponent();
            formLogin = formLoginRecibido;
        }

        private void FrmInfoUsuario_Load(object sender, EventArgs e)
        {
            if(formLogin is not null)
            {
                lbl_Nombre.Text = formLogin.UsuarioIngresado.Nombre;
                lbl_Apellido.Text = formLogin.UsuarioIngresado.Apellido;
                lbl_Dni.Text = formLogin.UsuarioIngresado.Dni.ToString();
                lbl_NombreDeUsuario.Text = formLogin.UsuarioIngresado.NombreUsuario;
                lbl_Rol.Text = formLogin.UsuarioIngresado.Rol.ToString();
            }
        }
    }
}
