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
    public partial class FrmAltaProducto : Form
    {
        private Producto productoCreado;
        public Producto ProductoCreado { get => productoCreado; }

        public FrmAltaProducto()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDatosProducto();

                //Buscar si el producto ya existe

                _ = Enum.TryParse(cmb_Tipo.SelectedItem.ToString(), out ETipo tipoSeleccionado);
                string nombreIngresado = txt_Nombre.Text;
                string marcaIngresada = txt_Marca.Text;
                string descripcion = rtb_Descripcion.Text;
                float precio = (float)nud_Precio.Value;
                int stock = (int)nud_Stock.Value;

                productoCreado = new Producto(nombreIngresado, tipoSeleccionado, marcaIngresada,
                                              descripcion, (float)precio, stock);

                this.DialogResult = DialogResult.OK;

            }catch(Exception ex)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
        }

        private void ValidarDatosProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos no válidos:");

            if (!Validador.ValidarItemEnumerado(cmb_Tipo.SelectedItem, typeof(ETipo)))
                sb.AppendLine("- Tipo");

            if (!Validador.ValidarStringConLetraSinDigitoYRango(txt_Nombre.Text, 2, 24))
                sb.AppendLine("- Nombre");

            if (!Validador.ValidarStringConLetraSinDigitoYRango(txt_Marca.Text, 2, 24))
                sb.AppendLine("- Marca");

            if (!Validador.ValidarCantidadRango((float)nud_Precio.Value, 0, 5001))
                sb.AppendLine("- Precio");

            if (!Validador.ValidarCantidadRango((float)nud_Stock.Value, 0, 2001))
                sb.AppendLine("- Stock");

            if (!Validador.ValidarStringRango(rtb_Descripcion.Text, 4, 121))
                sb.AppendLine("- Descripción");

            if(sb.Length > 19)
                throw new Exception(sb.ToString());
        }
       
        private void ValidarProductoExistente(Producto productoRecibido)
        {
            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                if (producto == productoRecibido)
                {
                    throw new Exception("Ese producto ya existe");
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
