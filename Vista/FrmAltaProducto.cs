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
            if(!esProductoNuevo)
                RecibirDatosDelProductoAModificar();
        }

        private void RecibirDatosDelProductoAModificar()
        {
            cmb_Tipo.Text = productoIngresado.Tipo.ToString();
            txt_Nombre.Text = productoIngresado.Nombre;
            txt_Marca.Text = productoIngresado.Marca;
            rtb_Descripcion.Text = productoIngresado.Descripcion.ToString();
            nud_Precio.Value = (decimal)productoIngresado.Precio;
            nud_Stock.Value = productoIngresado.Stock;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Validador.ValidarDatosProducto(cmb_Tipo.SelectedItem, txt_Nombre.Text, txt_Marca.Text,
                                                (float)nud_Precio.Value, (float)nud_Stock.Value, rtb_Descripcion.Text);

                AsignarDatosAlProducto();

                if (esProductoNuevo)
                    VerificarSiExisteProducto(productoIngresado);

                this.DialogResult = DialogResult.OK;

            }catch(Exception ex)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
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
       
        private void VerificarSiExisteProducto(Producto productoRecibido)
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
