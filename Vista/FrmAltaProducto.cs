using Entidades;
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

                ETipo tipoSeleccionado = (ETipo)Enum.Parse(typeof(ETipo), cmb_Tipo.SelectedItem.ToString());

                productoCreado = new Producto(txt_Nombre.Text, tipoSeleccionado, txt_Marca.Text, 
                            rtb_Descripcion.Text, (float)nud_Precio.Value, (int)nud_Stock.Value);


                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
        }

        private void ValidarDatosProducto()
        {
            if(!(ValidarTipoDeProducto() && ValidarStringDeProducto(txt_Nombre.Text)
                && ValidarStringDeProducto(txt_Marca.Text)
                && ValidarPrecioDeProducto((float)nud_Precio.Value) && ValidarStockDeProducto((int)nud_Stock.Value)
                && ValidarDescripcionDeProducto(rtb_Descripcion.Text)))
            {
                throw new Exception("Datos invalidos");
            }
        }

        private bool ValidarTipoDeProducto()
        {
            return cmb_Tipo.SelectedItem != null;
        }

        private bool ValidarStringDeProducto(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) || cadena.Length < 3 || cadena.Length > 23)
                return false;

            foreach (char caracter in cadena)
            {
                if (!char.IsLetter(caracter) && caracter != ' ' && caracter != '-')
                {
                    return false;
                }
            }

            return true;
        }

        private bool ValidarStockDeProducto(int stock)
        {
            return stock > 0 && stock <= 2000;
        }

        private bool ValidarPrecioDeProducto(float precio)
        {
            return precio > 0 && precio <= 5000;
        }

        private bool ValidarDescripcionDeProducto(string descripcion)
        {
            return descripcion.Length > 5 && descripcion.Length <= 120;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
