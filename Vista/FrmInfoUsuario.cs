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
        private Usuario? usuarioActual;
        private FrmLogin formLogin;

        public FrmInfoUsuario(FrmLogin formLoginRecibido)
        {
            InitializeComponent();
            formLogin = formLoginRecibido;
        }

        private void FrmInfoUsuario_Load(object sender, EventArgs e)
        {
            lbl_Nombre.Text = formLogin.UsuarioIngresado.Nombre;



        }
    }
}
