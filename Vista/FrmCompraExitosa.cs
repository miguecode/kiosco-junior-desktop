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
    public partial class FrmCompraExitosa : Form
    {
        private Eventos eventosCompras;

        public FrmCompraExitosa(Eventos eventos)
        {
            InitializeComponent();
            this.eventosCompras = eventos;
            eventosCompras.SeConfirmoLaCompra += EscribirMensaje;
        }

        private void FrmCompraExitosa_Load(object sender, EventArgs e)
        {

        }

        private void EscribirMensaje(string mensaje)
        {
            rtb_Mensaje.Text = mensaje;
            this.ShowDialog();
        }
    }
}
