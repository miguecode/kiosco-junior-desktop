using Entidades;
using Helper;
using System;
using System.Collections;
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
    public partial class FrmVentas : Form
    {
        private float ingresosTotales;
        private string compradorMasFrecuente;

        public FrmVentas()
        {
            InitializeComponent();
            ingresosTotales = 0;
            compradorMasFrecuente = String.Empty;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dtg_Ventas.DataSource = null;
            dtg_Ventas.DataSource = Sistema.ListaDeVentas;
            EscribirIngresosTotales(Sistema.ListaDeVentas);
            EscribirCompradorMasFrecuente(Sistema.ListaDeVentas);
            EscribirVentasTotales(Sistema.ListaDeVentas);
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if(Sistema.ListaDeVentas.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro de borrar todo el historial de ventas?" +
                    "\nNo podrás recuperarlo.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                    LimpiarPantalla();
            }
        }

        private void LimpiarPantalla()
        {
            Sistema.ListaDeVentas.Clear();
            dtg_Ventas.DataSource = null;
            dtg_Ventas.DataSource = Sistema.ListaDeVentas;
            EscribirIngresosTotales(Sistema.ListaDeVentas);
            EscribirCompradorMasFrecuente(Sistema.ListaDeVentas);
            EscribirVentasTotales(Sistema.ListaDeVentas);
        }

        private void EscribirIngresosTotales(List<Venta> lista)
        {
            ingresosTotales = 0;
            lbl_IngresosTotales.Text = ingresosTotales.ToString("0.00");

            if (lista.Count > 0)
            {
                foreach (Venta venta in lista)
                {
                    ingresosTotales += venta.ValorTotal;
                }

                lbl_IngresosTotales.Text = ingresosTotales.ToString("0.00");
            }
        }

        private void EscribirCompradorMasFrecuente(List<Venta> lista)
        {
            compradorMasFrecuente = String.Empty;
            lbl_CompradorFrecuente.Text = compradorMasFrecuente;

            if (Sistema.ListaDeVentas.Count > 0)
            {
                var grupoCompradores = lista.GroupBy(v => v.NombreCliente).OrderByDescending(g => g.Count());
                compradorMasFrecuente = grupoCompradores.First().Key;

                lbl_CompradorFrecuente.Text = compradorMasFrecuente;
            }
        }

        private void EscribirVentasTotales(List<Venta> lista)
        {
            lbl_VentasTotales.Text = lista.Count.ToString();
        }

        private void btn_VerDetalles_Click(object sender, EventArgs e)
        {
            if (Sistema.ListaDeVentas.Count > 0)
            {
                Venta ventaSeleccionada = SeleccionarVentaEspecifica(Sistema.ListaDeVentas);

                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Detalles de la venta\n");
                sb.AppendLine($"ID de la transacción: {ventaSeleccionada.Id}");
                sb.AppendLine($"Comprador: {ventaSeleccionada.NombreCliente}\n");
                sb.AppendLine($"Cantidad de productos comprados: {ventaSeleccionada.CantidadProductos}\n");
                sb.AppendLine($"Cigarrillos comprados: {ventaSeleccionada.CantidadCigarrillos}");
                sb.AppendLine($"Bebidas compradas: {ventaSeleccionada.CantidadBebidas}");
                sb.AppendLine($"Snacks compradas: {ventaSeleccionada.CantidadSnacks}");
                sb.AppendLine($"Galletitas compradas: {ventaSeleccionada.CantidadGalletitas}");
                sb.AppendLine($"Dulces comprados: {ventaSeleccionada.CantidadDulces}");
                sb.AppendLine($"Comidas compradas: {ventaSeleccionada.CantidadComidas}");
                sb.AppendLine($"Otros productos comprados: {ventaSeleccionada.CantidadOtros}\n");
                sb.AppendLine($"Importe Total: $ {ventaSeleccionada.ValorTotal.ToString("0.00")}");
                MessageBox.Show(sb.ToString(), "Kiosco Junior");
            }
        }

        private Venta SeleccionarVentaEspecifica(List<Venta> lista)
        {
            return lista[dtg_Ventas.CurrentRow.Index];
        }
    }
}
