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
        private Usuario usuarioActual;
        private FrmLogin formLogin;
        private FrmProductos? formProductos;
        private FrmInfoUsuario? formInfoUsuario;
        private FrmGestionUsuario? formGestionUsuario;
        private FrmCompras? formCompras;
        private FrmVentas? formVentas;

        public FrmPrincipal(FrmLogin formLoginRecibido)
        {
            InitializeComponent();
            usuarioActual = new Usuario();
            formLogin = formLoginRecibido;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            usuarioActual = formLogin.UsuarioIngresado;
            IsMdiContainer = true;
            CrearFormulariosMdi();
            ConfigurarMenuPorRol(usuarioActual);
        }

        private void smi_Cerrar_Click(object sender, EventArgs e)
        {
            formLogin.Close();
            Close();
        }

        private void smi_Inicio_Click(object sender, EventArgs e)
        {
            foreach (var formularioHijo in this.MdiChildren)
            {
                //pnl_Principal.Visible = true;
                formularioHijo.Hide();
            }
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmProductos));
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto productoNuevo = new Producto();

            FrmAltaProducto formAltaProducto = new FrmAltaProducto(productoNuevo, true);

            if (formAltaProducto.ShowDialog() == DialogResult.OK && formProductos is not null)
            {
                Sistema.ListaDeProductos.Add(formAltaProducto.ProductoIngresado);
                formProductos.ActualizarDataGrid(Sistema.ListaDeProductos);
            }else
                formAltaProducto.Close();
        }

        private void MostrarFormularioHijo(Type tipoFormulario)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario.GetType() != tipoFormulario)
                    formulario.Hide();

                else
                {
                    //pnl_Principal.Visible = false;
                    formulario.WindowState = FormWindowState.Maximized;
                    formulario.Show();
                }
            }
        }

        private void verDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmInfoUsuario));
        }

        private void ConfigurarMenuPorRol(Usuario usuarioRecibido)
        {
            sbl_NombreUsuario.Text = usuarioRecibido.NombreCompleto;
            sbl_DniUsuario.Text = $"DNI: {usuarioRecibido.Dni}";

            if (usuarioRecibido.Rol == ERol.SuperUsuario)
            {
                smi_Usuarios.Visible = true;
                sbl_NombreUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
                sbl_NombreUsuario.ForeColor = Color.FromArgb(234, 202, 51);
                //smi_Cerrar.Margin.Left = 470
            }
            else if(usuarioRecibido.Rol == ERol.Cliente)
            {
                smi_Compras.Visible = true;
                smi_Producto.Visible = false;
                smi_Ventas.Visible = false;
                verDatosToolStripMenuItem.Visible = false;
                //smi_Cerrar.Margin.Left = 
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin.LimpiarPantalla();
            formLogin.Show();
            this.Close();
        }

        private void smi_Usuarios_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmGestionUsuario));
        }

        private void smi_Compras_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmCompras));
        }

        private void CrearFormulariosMdi()
        {
            formProductos = new FrmProductos();
            formProductos.MdiParent = this;
            formInfoUsuario = new FrmInfoUsuario(usuarioActual);
            formInfoUsuario.MdiParent = this;
            formGestionUsuario = new FrmGestionUsuario();
            formGestionUsuario.MdiParent = this;
            formCompras = new FrmCompras(usuarioActual);
            formCompras.MdiParent = this;
            formVentas = new FrmVentas();
            formVentas.MdiParent = this;
        }

        private void smi_Ventas_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmVentas));
        }
    }
}
