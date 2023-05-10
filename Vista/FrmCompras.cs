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

        public FrmCompras(Usuario usuarioActual)
        {
            InitializeComponent();
            this.clienteActual = (Cliente)usuarioActual;
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            ActualizarDataGrids(Sistema.ListaDeProductos, clienteActual.Carrito);
        }

        private void AgregarProductoAlCarrito()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico();

            if(productoSeleccionado is not null && productoSeleccionado.Stock > 0)
            {
                clienteActual.Carrito.Add(productoSeleccionado, productoSeleccionado.Precio);
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
                precioTotal += itemCarrito.Value;
            }

            lbl_Total.Text = $"Precio TOTAL: $ {precioTotal.ToString("000,00")}";
        }

        public void ActualizarDataGrids(List<Producto> menu, Dictionary<Producto, float> carrito)
        {
            dtg_Productos.DataSource = null;
            dtg_Carrito.DataSource = null;
            dtg_Productos.DataSource = menu;
            dtg_Carrito.DataSource = carrito;
        }

        private Producto SeleccionarProductoEspecifico()
        {
            return Sistema.ListaDeProductos[dtg_Productos.CurrentRow.Index];
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito();

            CrearPrecioTotal();

            ActualizarDataGrids(Sistema.ListaDeProductos, clienteActual.Carrito);

            ReducirStockProducto();
        }

        private void ReducirStockProducto()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico();
            productoSeleccionado.Stock--;
        }









    }
}
