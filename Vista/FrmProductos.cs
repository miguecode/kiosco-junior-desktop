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
            //dtg_Productos.DataSource = null;
            //dtg_Productos.DataSource = Sistema.ListaDeProductos;
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
            Producto productoSeleccionado = SeleccionarProductoEspecifico();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{productoSeleccionado.Nombre} \n");
            sb.AppendLine("Descripción");
            sb.AppendLine($"{productoSeleccionado.Descripcion}");

            MessageBox.Show(sb.ToString(), "DETALLES");
        }

        private void btn_AltaProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
