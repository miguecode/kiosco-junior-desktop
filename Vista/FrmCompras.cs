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
    public partial class FrmCompras : Form
    {
        private Cliente clienteActual;
        private List<Producto> menu;

        public FrmCompras(Usuario usuarioActual)
        {
            InitializeComponent();
            this.clienteActual = ConvertirUsuarioACliente(usuarioActual);

            this.menu = new List<Producto>();
            this.menu = Sistema.ListaDeProductos;

        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {;
            dtg_Productos.DataSource = null;
            dtg_Productos.DataSource = menu;
        }

        private void AgregarProductoAlCarrito()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico();

            if(productoSeleccionado is not null)
            {
                clienteActual.Carrito.Add(productoSeleccionado);
                lbl_Error.Visible = false;
            }else
            {
                lbl_Error.Visible = true;
            }
        }

        private void CrearPrecioTotal()
        {
            float precioTotal = 0;

            foreach (var itemCarrito in clienteActual.Carrito)
            {
                precioTotal += itemCarrito.Precio;
            }

            lbl_Total.Text = $"Precio TOTAL: $ {precioTotal.ToString("0,00")}";
        }

        public void ActualizarDataGrids(List<Producto> menu, List<Producto> carrito)
        {
            dtg_Productos.DataSource = null;
            dtg_Carrito.DataSource = null;
            dtg_Productos.DataSource = menu;
            dtg_Carrito.DataSource = carrito;
        }

        private Producto SeleccionarProductoEspecifico()
        {
            return menu[dtg_Productos.CurrentRow.Index];
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarProductoStock();

                AgregarProductoAlCarrito();

                CrearPrecioTotal();

                ActualizarDataGrids(menu, clienteActual.Carrito);

            }
            catch(Exception ex)
            {
                lbl_Error.Text = ex.Message;
                lbl_Error.Visible = true;
            }
        }

        private void ReducirStockProducto()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico();
            productoSeleccionado.Stock--;
        }


        private Cliente ConvertirUsuarioACliente(Usuario usuarioActual)
        {
            Cliente clienteCreado = new Cliente(usuarioActual.Nombre, usuarioActual.Apellido, usuarioActual.Dni,
                                        usuarioActual.NombreUsuario, usuarioActual.Contrasenia, usuarioActual.Rol);

            return clienteCreado;
        }

        private void VerificarProductoStock()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico();

            int contador = 1;

            foreach (Producto producto in clienteActual.Carrito)
            {
                if(producto == productoSeleccionado)
                {
                    contador++;
                }
            }

            if (contador > productoSeleccionado.Stock)
                throw new Exception("Producto agotado");
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {




        }










    }
}
