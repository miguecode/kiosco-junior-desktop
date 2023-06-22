using Entidades;
using Helper;
using LogicaSQL.EntidadesDerivadas;
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
        private Usuario usuarioIngresado;

        public FrmInfoUsuario(Usuario usuarioIngresado)
        {
            InitializeComponent();
            this.usuarioIngresado = usuarioIngresado;
        }

        private void FrmInfoUsuario_Load(object sender, EventArgs e)
        {
            if (usuarioIngresado is not null)
                EscribirDatos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario formModificar = new FrmAltaUsuario(usuarioIngresado, false);

            if (formModificar.ShowDialog() == DialogResult.OK)
            {
                UsuarioDB controladorDB = new UsuarioDB();
                controladorDB.Modificar(usuarioIngresado);

                Logs.CrearRegistro(usuarioIngresado.NombreUsuario, "Modificó sus propios datos");

                EscribirDatos();
            }

            else
                formModificar.Close();
        }

        private void EscribirDatos()
        {
            lbl_Nombre.Text = usuarioIngresado.Nombre;
            lbl_Apellido.Text = usuarioIngresado.Apellido;
            lbl_Dni.Text = usuarioIngresado.Dni.ToString();
            lbl_NombreDeUsuario.Text = usuarioIngresado.NombreUsuario;
            lbl_Rol.Text = usuarioIngresado.Rol.ToString();
        }
    }
}
