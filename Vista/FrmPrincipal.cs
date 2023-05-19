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

        private void smi_Inicio_Click(object sender, EventArgs e)
        {
            foreach (var formularioHijo in this.MdiChildren)
            {
                formularioHijo.Hide();
                pnl_Imagen.BringToFront();
            }
        }

        private void smi_Producto_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmProductos));
        }

        private void smi_Compras_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmCompras));
        }

        private void smi_Ventas_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmVentas));
        }

        private void smi_Usuarios_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmGestionUsuario));
        }

        private void tsm_VerDatos_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(typeof(FrmInfoUsuario));
        }

        private void tsm_CerrarSesion_Click(object sender, EventArgs e)
        {
            formLogin.LimpiarPantalla();
            formLogin.Show();
            this.Close();
        }

        private void smi_Cerrar_Click(object sender, EventArgs e)
        {
            formLogin.Close();
            Close();
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

        private void ConfigurarMenuPorRol(Usuario usuarioRecibido)
        {
            sbl_NombreUsuario.Text = usuarioRecibido.NombreCompleto;
            sbl_DniUsuario.Text = $"DNI: {usuarioRecibido.Dni}";


            if (usuarioRecibido.Rol == ERol.SuperUsuario)
            {
                smi_Usuarios.Visible = true;
                sbl_NombreUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
                //smi_Cerrar.Margin.Left = 470
            }
            else if (usuarioRecibido.Rol == ERol.Cliente)
            {
                smi_Compras.Visible = true;
                smi_Producto.Visible = false;
                smi_Ventas.Visible = false;
                tsm_VerDatos.Visible = false;
                //smi_Cerrar.Margin.Left = 
            }
        }

        private void MostrarFormularioHijo(Type tipoFormulario)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario.GetType() != tipoFormulario)
                    formulario.Hide();

                else
                {
                    pnl_Imagen.SendToBack();
                    formulario.WindowState = FormWindowState.Maximized;
                    formulario.Show();
                }
            }
        }
    }
}
