using Entidades;
using EntidadesDB;
using Helper;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCompras : Form
    {
        private VentaDB controladorDB;
        private Cliente clienteActual;
        private List<Producto> menu;
        private float precioTotal;
        private int cantidadCigarrillos = 0;
        private int cantidadBebidas = 0;
        private int cantidadSnacks = 0;
        private int cantidadGalletitas = 0;
        private int cantidadDulces = 0;
        private int cantidadComidas = 0;
        private int cantidadOtros = 0;
        private Venta ventaActual;
        private float aumento = 1.05f;
        private Eventos eventosCompras; 

        public FrmCompras(Usuario usuarioActual)
        {
            InitializeComponent();
            controladorDB = new VentaDB();
            clienteActual = ConvertirUsuarioACliente(usuarioActual);
            ventaActual = new Venta();
            menu = new List<Producto>();
            menu.AddRange(Sistema.ListaDeProductos);
            eventosCompras = new Eventos();
            _ = new FrmCompraExitosa(eventosCompras);
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            Sistema.ListaDeVentas = controladorDB.TraerTodosLosRegistros();
            dtg_Productos.DataSource = null;
            dtg_Productos.DataSource = menu;
            OcultarProductosAgotados();
            ReiniciarCantidadDeProductos();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (dtg_Productos.Rows.Count > 0)
            {
                try
                {
                    VerificarProductoStockOrThrow();

                    AgregarProductoAlCarrito();

                    EscribirPrecioTotal();

                    ActualizarDataGrids(menu, clienteActual.Carrito);

                    lbl_Error.Visible = false;
                }
                catch (Exception ex)
                {
                    lbl_Error.Text = ex.Message;
                    lbl_Error.Visible = true;
                }
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (clienteActual.Carrito.Count > 0)
            {
                CalcularCantidadDeProductosCompradosPorTipo();
                int cantidadProductos = CalcularTamañoDeCarrito();

                ventaActual = new Venta(clienteActual.NombreCompleto, precioTotal, cantidadProductos,
                    cantidadCigarrillos, cantidadBebidas, cantidadSnacks,
                    cantidadGalletitas, cantidadDulces, cantidadComidas, cantidadOtros);

                Sistema.ListaDeVentas.Add(ventaActual);

                controladorDB.Agregar(ventaActual);
 
                eventosCompras.NotificarCompraExitosa(GenerarMensajeCompraExitosa());

                ReducirStockProducto();

                OcultarProductosAgotados();

                ReiniciarCarrito();
            }
        }

        private void btn_Sacar_Click(object sender, EventArgs e)
        {
            if (clienteActual.Carrito.Count > 0)
            {
                Producto productoSeleccionado = SeleccionarProductoEspecifico(true);

                productoSeleccionado.CantidadEnCarrito = 0;
                clienteActual.Carrito.Remove(productoSeleccionado);

                ActualizarDataGrids(menu, clienteActual.Carrito);
                EscribirPrecioTotal();
            }
        }

        private void btn_VaciarCarrito_Click(object sender, EventArgs e)
        {
            if (clienteActual.Carrito.Count > 0)
                ReiniciarCarrito();
        }
        private void rad_Efectivo_CheckedChanged(object sender, EventArgs e)
        {
            EscribirPrecioTotal();
        }

        private void rad_MercadoPago_CheckedChanged(object sender, EventArgs e)
        {
            EscribirPrecioTotal();
        }

        private void OcultarProductosAgotados()
        {
            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                if (producto.Stock == 0)
                    menu.Remove(producto);
            }
        }

        private void ReiniciarCantidadDeProductos()
        {
            cantidadCigarrillos = 0;
            cantidadBebidas = 0;
            cantidadSnacks = 0;
            cantidadGalletitas = 0;
            cantidadDulces = 0;
            cantidadComidas = 0;
            cantidadOtros = 0;

            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                producto.CantidadEnCarrito = 0;
            }
        }

        /// <summary>
        /// Recorre al carrito. Dependiendo del tipo del producto por el que esté
        /// pasando, se aumentará la cantidad de veces que aparece el tipo de tal producto.
        /// </summary>
        private void CalcularCantidadDeProductosCompradosPorTipo()
        {
            foreach (Producto producto in clienteActual.Carrito)
            {
                string tipo = producto.Tipo.ToString();

                switch (tipo)
                {
                    case "Cigarrillos":
                        cantidadCigarrillos += producto.CantidadEnCarrito;
                        break;
                    case "Bebidas":
                        cantidadBebidas += producto.CantidadEnCarrito;
                        break;
                    case "Snacks":
                        cantidadSnacks += producto.CantidadEnCarrito;
                        break;
                    case "Galletitas":
                        cantidadGalletitas += producto.CantidadEnCarrito;
                        break;
                    case "Dulces":
                        cantidadDulces += producto.CantidadEnCarrito;
                        break;
                    case "Comidas":
                        cantidadComidas += producto.CantidadEnCarrito;
                        break;
                    default:
                        cantidadOtros += producto.CantidadEnCarrito;
                        break;
                }
            }
        }

        private void VerificarProductoStockOrThrow()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico(false);

            if (productoSeleccionado.CantidadEnCarrito > (productoSeleccionado.Stock - 1))
                throw new Exception("Producto agotado");
        }

        /// <summary>
        /// Si el bool que recibe es true, significa que necesitamos retornar al producto
        /// seleccionado en el DataGridView del carrito. Si el bool es false, se retorna
        /// al producto seleccionado en el DataGridView del menú.
        /// </summary>
        /// <param name="esCarrito"></param>
        /// <returns></returns>
        private Producto SeleccionarProductoEspecifico(bool esCarrito)
        {
            if (esCarrito)
                return clienteActual.Carrito[dtg_Carrito.CurrentRow.Index];

            return menu[dtg_Productos.CurrentRow.Index];
        }

        /// <summary>
        /// Si el carrito ya tenía al producto seleccionado, le aumenta la cantidad.
        /// Si no lo tenía, lo agrega y le aumenta la cantidad.
        /// </summary>
        private void AgregarProductoAlCarrito()
        {
            Producto productoSeleccionado = SeleccionarProductoEspecifico(false);

            if (clienteActual.Carrito.Contains(productoSeleccionado))
                productoSeleccionado.CantidadEnCarrito++;
            else
            {
                clienteActual.Carrito.Add(productoSeleccionado);
                productoSeleccionado.CantidadEnCarrito++;
                lbl_Error.Visible = false;
            }
        }

        /// <summary>
        /// Recorre cada producto del carrito y hace el cálculo para asignarle el resultado al
        /// atributo precioTotal. El cálculo va a depender de si se está pagando con Efectivo o con MercadoPago.
        /// Por último, lo escribe en el label del formulario que corresponde.
        /// </summary>
        private void EscribirPrecioTotal()
        {
            precioTotal = 0;

            foreach (Producto producto in clienteActual.Carrito)
            {
                if (rad_Efectivo.Checked)
                    precioTotal += producto.Precio * producto.CantidadEnCarrito;

                else
                    precioTotal += (producto.Precio * aumento) * producto.CantidadEnCarrito;
            }

            lbl_Total.Text = $"TOTAL: $ {precioTotal:0.00}";

            if (rad_MercadoPago.Checked)
                lbl_Total.Text += " (+5%)";
        }

        private void ActualizarDataGrids(List<Producto> menuLista, List<Producto> carrito)
        {
            dtg_Productos.DataSource = null;
            dtg_Productos.DataSource = menuLista;

            dtg_Carrito.DataSource = null;
            dtg_Carrito.DataSource = carrito;
        }

        private void ReiniciarCarrito()
        {
            ReiniciarCantidadDeProductos();
            clienteActual.Carrito.Clear();
            ActualizarDataGrids(menu, clienteActual.Carrito);
            precioTotal = 0;
            lbl_Total.Text = $"TOTAL: $ {precioTotal:0.00f}";
        }

        private void ReducirStockProducto()
        {
            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                if (producto.CantidadEnCarrito > 0)
                {
                    producto.Stock -= producto.CantidadEnCarrito;

                    ProductoDB controladorDB = new ProductoDB();
                    controladorDB.Modificar(producto);
                }
            }
        }

        private string GenerarMensajeCompraExitosa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Comprador: {clienteActual.NombreCompleto}\n");
            sb.AppendLine($"Cantidad de productos comprados: {CalcularTamañoDeCarrito()}\n");

            foreach (Producto producto in clienteActual.Carrito)
            {
                sb.AppendLine($"{producto.Nombre} (x{producto.CantidadEnCarrito})  -  ${producto.Precio}");
            }

            sb.AppendLine($"\nImporte Total: $ {ventaActual.ValorTotal.ToString("0.00")}");

            return sb.ToString();
        }

        private int CalcularTamañoDeCarrito()
        {
            int cantidad = 0;

            foreach (Producto producto in clienteActual.Carrito)
            {
                cantidad += producto.CantidadEnCarrito;
            }

            return cantidad;
        }

        private static Cliente ConvertirUsuarioACliente(Usuario usuarioActual)
        {
            Cliente clienteCreado = new Cliente(usuarioActual.Nombre, usuarioActual.Apellido, usuarioActual.Dni,
                                        usuarioActual.NombreUsuario, usuarioActual.Contrasenia, usuarioActual.Rol);

            return clienteCreado;
        }
    }
}