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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if(Sistema.ConfirmarIngreso(txt_Nombre.Text, txt_Contrasenia.Text))
            {
                FrmPrincipal formPrincipal = new FrmPrincipal();
                formPrincipal.Show();
                this.Hide();
            }else
            {
                lbl_Error.Text = "Usuario y/o contraseña incorrectos";
                lbl_Error.Visible = true;
            }
        }

        private void btn_Autocompletar_Click(object sender, EventArgs e)
        {

        }
    }
}
