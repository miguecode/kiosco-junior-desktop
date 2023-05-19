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
        private float precioTotal;
        private Venta ventaActual;

        public FrmCompras(Usuario usuarioActual)
        {
            InitializeComponent();
            clienteActual = ConvertirUsuarioACliente(usuarioActual);
            ventaActual = new Venta();
            menu = new List<Producto>();
            menu.AddRange(Sistema.ListaDeProductos);
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            dtg_Productos.DataSource = null;
            dtg_Productos.DataSource = menu;
            OcultarProductosAgotados();
            ReiniciarCantidadDeProductos();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarProductoStock();

                AgregarProductoAlCarrito();

                EscribirPrecioTotal();

                ActualizarDataGrids(menu, clienteActual.Carrito);
            }
            catch (Exception ex)
            {
                lbl_Error.Text = ex.Message;
                lbl_Error.Visible = true;
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (clienteActual.Carrito.Count > 0)
            {
                string nombreCliente = clienteActual.NombreCompleto;
                float valorTotal = precioTotal;

                ventaActual = new Venta(nombreCliente, valorTotal);

                Sistema.ListaDeVentas.Add(ventaActual);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("¡Compra realizada con éxito!\n");
                sb.AppendLine($"ID de la transacción: {ventaActual.Id}");
                sb.AppendLine($"Cantidad de productos comprados: {clienteActual.TamañoDeCarrito}");
                sb.AppendLine($"Comprador: {nombreCliente}\n");
                sb.AppendLine($"Importe Total: $ {ventaActual.ValorTotal.ToString("0.00")}"); ;

                MessageBox.Show(sb.ToString(), "Kiosco Junior");

                ReducirStockProducto();

                OcultarProductosAgotados();

                ReiniciarCarrito();
            }
        }

        private void btn_VaciarCarrito_Click(object sender, EventArgs e)
        {
            ReiniciarCarrito();
        }

        private void VerificarProductoStock()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico();

            if (productoSeleccionado.CantidadEnCarrito > (productoSeleccionado.Stock -1))
                throw new Exception("Producto agotado");


           /* int contador = ContarRepeticionesProducto(productoSeleccionado);

            if (contador > productoSeleccionado.Stock)
                throw new Exception("Producto agotado");*/
        }

        private int ContarRepeticionesProducto(Producto productoSeleccionado)
        {
            int contador = 1;

            foreach (Producto producto in clienteActual.Carrito)
            {
                if (producto == productoSeleccionado)
                    contador++;
            }

            return contador;
        }

        private void AgregarProductoAlCarrito()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico();

            if (clienteActual.Carrito.Contains(productoSeleccionado))
                productoSeleccionado.CantidadEnCarrito++;
            else
            {
                clienteActual.Carrito.Add(productoSeleccionado);
                productoSeleccionado.CantidadEnCarrito++;
                lbl_Error.Visible = false;
            }

            /*if (productoSeleccionado is not null)
            {
                clienteActual.Carrito.Add(productoSeleccionado);
                lbl_Error.Visible = false;
            }
            else
                throw new Exception("Producto no encontrado");*/
        }

        private void ReiniciarCantidadDeProductos()
        {
            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                producto.CantidadEnCarrito = 0;
            }
        }

        private Producto SeleccionarProductoEspecifico()
        {
            return menu[dtg_Productos.CurrentRow.Index];
        }

        private void EscribirPrecioTotal()
        {
            precioTotal = 0;

            foreach (Producto producto in clienteActual.Carrito)
            {
                precioTotal += producto.Precio * producto.CantidadEnCarrito;
            }

            lbl_Total.Text = $"Precio TOTAL: $ {precioTotal:0.00}";
        }

        private void ReducirStockProducto()
        {
            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                producto.Stock -= producto.CantidadEnCarrito;


                /*if (clienteActual.Carrito.Contains(producto))
                {
                    int contador = ContarRepeticionesProducto(producto);
                    contador--;

                    producto.Stock -= contador;
                }*/
            }
        }

        private void ReiniciarCarrito()
        {
            ReiniciarCantidadDeProductos();
            clienteActual.Carrito.Clear();
            ActualizarDataGrids(menu, clienteActual.Carrito);
            precioTotal = 0;
            lbl_Total.Text = $"Precio TOTAL: $ {precioTotal:0.00}";
        }

        private void OcultarProductosAgotados()
        {
            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                if (producto.Stock == 0)
                    menu.Remove(producto);
            }
        }

        private void ActualizarDataGrids(List<Producto> menu, List<Producto> carrito)
        {
            dtg_Productos.DataSource = null;
            dtg_Productos.DataSource = menu;

            dtg_Carrito.DataSource = null;
            dtg_Carrito.DataSource = carrito;
        }

        private Cliente ConvertirUsuarioACliente(Usuario usuarioActual)
        {
            Cliente clienteCreado = new Cliente(usuarioActual.Nombre, usuarioActual.Apellido, usuarioActual.Dni,
                                        usuarioActual.NombreUsuario, usuarioActual.Contrasenia, usuarioActual.Rol);

            return clienteCreado;
        }
    }
}