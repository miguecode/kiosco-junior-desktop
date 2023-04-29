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
    public partial class FrmPrincipal : Form
    {
        private Usuario? usuarioActual;
        private FrmLogin formLogin;

        public FrmPrincipal(FrmLogin formLoginRecibido)
        {
            InitializeComponent();
            formLogin = formLoginRecibido;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            usuarioActual = formLogin.UsuarioIngresado;

            lbl_Datos.Text = usuarioActual.NombreCompleto;
        }







    }
}
