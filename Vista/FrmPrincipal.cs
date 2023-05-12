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
            
            configurarMenuPorRol(usuarioActual);
            CrearFormulariosMdi();
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

            if (formAltaProducto.ShowDialog() == DialogResult.OK && formProductos is not null)
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
            //Recorro todos los formularios que ya sean hijos del Contenedor MDI
            foreach (Form formulario in this.MdiChildren)
            {
                if(formulario.GetType() != tipoFormulario) //Si no es el que le paso, lo oculto
                {
                    formulario.Hide();
                }else                                    //Si es el que le paso,
                {
                    //formulario.Size = this.Size;
                    formulario.WindowState = FormWindowState.Maximized;
                    formulario.Show();               //Lo muestro
                }
            }
        }

        private void verDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularioHijo(typeof(FrmInfoUsuario));
        }

        private void configurarMenuPorRol(Usuario usuarioRecibido)
        {
            sbl_NombreUsuario.Text = usuarioRecibido.NombreCompleto;
            sbl_DniUsuario.Text = $"DNI: {usuarioRecibido.Dni}";

            if (usuarioRecibido.Rol == ERol.SuperUsuario)
            {
                smi_Usuarios.Visible = true;
                //smi_Cerrar.Margin.Left = 470
                sbl_NombreUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
                sbl_NombreUsuario.ForeColor = Color.FromArgb(234, 202, 51);
            }
            else if(usuarioRecibido.Rol == ERol.Cliente)
            {
                smi_Compras.Visible = true;
                smi_Producto.Visible = false;
                verDatosToolStripMenuItem.Visible = false;
                //smi_Cerrar.Margin.Left = 
            }
            else
            {
                //Empleado
                //smi_Cerrar.Margin.Left = 320
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
            mostrarFormularioHijo(typeof(FrmGestionUsuario));
        }

        private void smi_Compras_Click(object sender, EventArgs e)
        {
            mostrarFormularioHijo(typeof(FrmCompras));
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
        }
    }
}
