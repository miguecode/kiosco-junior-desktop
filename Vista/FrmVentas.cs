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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dtg_Ventas.DataSource = null;
            dtg_Ventas.DataSource = Sistema.listaDeVentas;
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if(Sistema.ListaDeVentas.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro de borrar todo el historial de ventas?" +
                    "\nNo podrás recuperarlo.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    Sistema.ListaDeVentas.Clear();
                    dtg_Ventas.DataSource = null;
                    dtg_Ventas.DataSource = Sistema.listaDeVentas;
                    lbl_IngresosTotales.Text = "0,00";
                }
            }
        }

        private void EscribirIngresosTotales()
        {
            if (Sistema.ListaDeVentas.Count > 0)
            {
                foreach (Venta venta in Sistema.ListaDeVentas)
                {
                    
                }


            }




        }






    }
}
