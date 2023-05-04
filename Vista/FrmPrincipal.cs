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
    public partial class FrmPrincipal : Form
    {
        private Usuario? usuarioActual;
        private FrmLogin formLogin;
        private FrmProductos formProductos;

        public FrmPrincipal(FrmLogin formLoginRecibido)
        {
            InitializeComponent();
            formLogin = formLoginRecibido;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            usuarioActual = formLogin.UsuarioIngresado;
            sbl_NombreUsuario.Text = usuarioActual.NombreCompleto;

            formProductos = new FrmProductos();
            formProductos.MdiParent = this;
        }
        private void smi_Cerrar_Click(object sender, EventArgs e)
        {
            formLogin.Close();
            this.Close();
        }

        private void smi_Inicio_Click(object sender, EventArgs e)
        {
            foreach (var formularioHijo in this.MdiChildren)
            {
                formularioHijo.Hide();
            }
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularioHijo(typeof(FrmProductos));
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FrmAltaProducto formAltaProducto = new FrmAltaProducto();

            if (formAltaProducto.ShowDialog() == DialogResult.OK)
            {
                Sistema.ListaDeProductos.Add(formAltaProducto.ProductoCreado);
                formProductos.ActualizarDataGrid(Sistema.ListaDeProductos);
            }else
            {
                formAltaProducto.Close();
            }
        }

        private void mostrarFormularioHijo(Type tipoFormulario)
        {
            // Verificar si el formulario ya está abierto como formulario hijo
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario.GetType() == tipoFormulario)
                {
                    formulario.Size = this.Size;
                    formulario.Show();
                    formulario.Activate();
                    //return true;
                }
            }
        }





    }
}
