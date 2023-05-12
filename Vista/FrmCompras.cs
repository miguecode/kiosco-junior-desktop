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
            menu = new List<Producto>();
            menu.AddRange(Sistema.ListaDeProductos);
            ventaActual = new Venta();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            dtg_Productos.DataSource = null;
            dtg_Productos.DataSource = menu;
            OcultarProductosAgotados();

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarProductoStock();

                AgregarProductoAlCarrito();

                EscribirPrecioTotal();

                ActualizarDataGrids(menu, clienteActual.Carrito);
            }catch (Exception ex)
            {
                lbl_Error.Text = ex.Message;
                lbl_Error.Visible = true;
            }
        }
        private void VerificarProductoStock()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico();

            int contador = ContarRepeticionesProducto(productoSeleccionado);

            if (contador > productoSeleccionado.Stock)
                throw new Exception("Producto agotado");
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

            if(productoSeleccionado is not null)
            {
                clienteActual.Carrito.Add(productoSeleccionado);
                lbl_Error.Visible = false;
            }else
                throw new Exception("Producto no encontrado");
        }

        private Producto SeleccionarProductoEspecifico()
        {
            return menu[dtg_Productos.CurrentRow.Index];
        }

        private void EscribirPrecioTotal()
        {
            precioTotal = 0;

            foreach (var itemCarrito in clienteActual.Carrito)
            {
                precioTotal += itemCarrito.Precio;
            }

            lbl_Total.Text = $"Precio TOTAL: $ {precioTotal:0.00}";
        }

        private void ReducirStockProducto()
        {
            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                if (clienteActual.Carrito.Contains(producto))
                {                
                    int contador = ContarRepeticionesProducto(producto);
                    contador--;

                    producto.Stock -= contador;
                }
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if(clienteActual.Carrito.Count > 0)
            {
                string nombreCliente = clienteActual.NombreCompleto;
                //List<Producto> carrito = clienteActual.Carrito;

                //string factura = ventaActual.EscribirLista(clienteActual.Carrito);

                float valorTotal = precioTotal;

                //ventaActual = new Venta(nombreCliente, factura, valorTotal);

                ventaActual = new Venta(nombreCliente, valorTotal);

                Sistema.ListaDeVentas.Add(ventaActual);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"ID: {ventaActual.Id}");
                sb.AppendLine($"Nombre Cliente: {ventaActual.NombreCliente}");
                sb.AppendLine($"Valor Total: {ventaActual.ValorTotal}");
                //sb.AppendLine($"Cantidad de productos: {ventaActual.CantidadProductos}");
                sb.AppendLine($"Productos:\n{ventaActual.EscribirLista(clienteActual.Carrito)}");

                MessageBox.Show(sb.ToString());

                ReducirStockProducto();

                OcultarProductosAgotados();

                ReiniciarCarrito();
            }
        }

        private void btn_VaciarCarrito_Click(object sender, EventArgs e)
        {
            ReiniciarCarrito();
        }

        private void ReiniciarCarrito()
        {
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
                {
                    menu.Remove(producto);
                }
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
