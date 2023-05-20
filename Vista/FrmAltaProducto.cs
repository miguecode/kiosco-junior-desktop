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
    public partial class FrmAltaProducto : Form
    {
        private Producto productoIngresado;
        private bool esProductoNuevo;
        public Producto ProductoIngresado { get => productoIngresado; }

        public FrmAltaProducto(Producto productoIngresado, bool esProductoNuevo)
        {
            InitializeComponent();
            this.productoIngresado = productoIngresado;
            this.esProductoNuevo = esProductoNuevo;
        }

        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            if (!esProductoNuevo)
                Formularios.ConfigurarDatosModificables(productoIngresado, cmb_Tipo, txt_Nombre,
                                                        txt_Marca, rtb_Descripcion, nud_Precio, nud_Stock);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Validador.ValidarDatosProducto(cmb_Tipo.SelectedItem, txt_Nombre.Text, txt_Marca.Text,
                                                (float)nud_Precio.Value, (float)nud_Stock.Value, rtb_Descripcion.Text);

                AsignarDatosAlProducto();

                if (esProductoNuevo)
                    Dato.VerificarSiExisteEntidad(Sistema.ListaDeProductos, productoIngresado);

                this.DialogResult = DialogResult.OK;
            }catch(Exception ex)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AsignarDatosAlProducto()
        {
            _ = Enum.TryParse(cmb_Tipo.SelectedItem.ToString(), out ETipo tipo);
            string nombre = txt_Nombre.Text;
            string marca = txt_Marca.Text;
            string descripcion = rtb_Descripcion.Text;
            float precio = (float)nud_Precio.Value;
            int stock = (int)nud_Stock.Value;

            if(esProductoNuevo)
                productoIngresado = new Producto(nombre, tipo, marca, descripcion, precio, stock);
            else
            {
                productoIngresado.Tipo = tipo;
                productoIngresado.Nombre = nombre;
                productoIngresado.Marca = marca;
                productoIngresado.Descripcion = descripcion;
                productoIngresado.Precio = precio;
                productoIngresado.Stock = stock;
            }          
        }
    }
}
