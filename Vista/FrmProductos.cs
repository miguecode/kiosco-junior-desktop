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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid(Sistema.ListaDeProductos);
        }

        public void ActualizarDataGrid(List<Producto> listaProductos)
        {
            dtg_Productos.DataSource = null;
            dtg_Productos.DataSource = listaProductos;
        }

        private Producto SeleccionarProductoEspecifico()
        {
            return Sistema.ListaDeProductos[dtg_Productos.CurrentRow.Index];
        }

        private void btn_Detalles_Click(object sender, EventArgs e)
        {
            if(Sistema.ListaDeProductos.Count > 0)
            {
                Producto productoSeleccionado = SeleccionarProductoEspecifico();

                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"{productoSeleccionado.Nombre} \n");
                sb.AppendLine("Descripción");
                sb.AppendLine($"{productoSeleccionado.Descripcion}");

                MessageBox.Show(sb.ToString(), "DETALLES");
            }
        }

        private void btn_AltaProducto_Click(object sender, EventArgs e)
        {
            FrmAltaProducto formAltaProducto = new FrmAltaProducto();

            if (formAltaProducto.ShowDialog() == DialogResult.OK)
            {
                Sistema.ListaDeProductos.Add(formAltaProducto.ProductoCreado);
                this.ActualizarDataGrid(Sistema.ListaDeProductos);
            }else
            {
                formAltaProducto.Close();
            }
        }

        private void btn_BajaProducto_Click(object sender, EventArgs e)
        {
            if(Sistema.ListaDeProductos.Count > 0)
            {
                Producto productoSeleccionado = SeleccionarProductoEspecifico();
                Sistema.ListaDeProductos.Remove(productoSeleccionado);
                this.ActualizarDataGrid(Sistema.ListaDeProductos);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if(Sistema.ListaDeProductos.Count > 0)
            {
                FrmAltaProducto formAltaProducto = new FrmAltaProducto();
                Producto productoSeleccionado = SeleccionarProductoEspecifico();

                if (formAltaProducto.ShowDialog() == DialogResult.OK)
                {
                    int indice = Sistema.ListaDeProductos.IndexOf(productoSeleccionado);
                    Sistema.ListaDeProductos.Remove(productoSeleccionado);
                    formAltaProducto.ProductoCreado.Id = productoSeleccionado.Id;
                    Sistema.ListaDeProductos.Insert(indice, formAltaProducto.ProductoCreado);                  
                    this.ActualizarDataGrid(Sistema.ListaDeProductos);
                }
                else
                {
                    formAltaProducto.Close();
                }
            }
        }
    }
}
