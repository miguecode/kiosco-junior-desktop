using Entidades;
using Helper;
using HelperFormularios;
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
            IsMdiContainer = true;
            usuarioActual = formLogin.UsuarioIngresado;
            CrearFormulariosMdi();
            ConfigurarMenuPorRol(usuarioActual);
        }

        private void smi_Inicio_Click(object sender, EventArgs e)
        {
            foreach (var formularioHijo in this.MdiChildren)
            {
                formularioHijo.Hide();
                pnl_Inicio.BringToFront();
            }
        }

        private void tim_HoraYFecha_Tick(object sender, EventArgs e)
        {
            lbl_Horario.Text = DateTime.Now.ToShortTimeString();
            lbl_Fecha.Text = DateTime.Now.ToString("dd 'de' MMMM yyyy");
        }

        private void smi_Producto_Click(object sender, EventArgs e)
        {
            Formularios.MostrarFormularioHijo(this, typeof(FrmProductos), pnl_Inicio);
        }

        private void smi_Compras_Click(object sender, EventArgs e)
        {
            Formularios.MostrarFormularioHijo(this, typeof(FrmCompras), pnl_Inicio);
        }

        private void smi_Ventas_Click(object sender, EventArgs e)
        {
            Formularios.MostrarFormularioHijo(this, typeof(FrmVentas), pnl_Inicio);
        }

        private void smi_Usuarios_Click(object sender, EventArgs e)
        {
            Formularios.MostrarFormularioHijo(this, typeof(FrmGestionUsuario), pnl_Inicio);
        }

        private void tsm_VerDatos_Click(object sender, EventArgs e)
        {
            Formularios.MostrarFormularioHijo(this, typeof(FrmInfoUsuario), pnl_Inicio);
        }

        private void tsm_CerrarSesion_Click(object sender, EventArgs e)
        {
            formLogin.LimpiarDatos();
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
            sbl_RolUsuario.Text = usuarioRecibido.Rol.ToString();

            if (usuarioRecibido.Rol == ERol.SuperUsuario)
                smi_Usuarios.Visible = true;

            else if (usuarioRecibido.Rol == ERol.Cliente)
            {
                smi_Compras.Visible = true;
                smi_Producto.Visible = false;
                smi_Ventas.Visible = false;
                tsm_VerDatos.Visible = false;
            }
        }
    }
}
