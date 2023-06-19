using Entidades;
using Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmLogs : Form
    {
        private Logs controladorLogs;

        public FrmLogs()
        {
            InitializeComponent();
            controladorLogs = new Logs();
            Eventos.SeAgregaronRegistros += EscribirLogs;
        }

        private void FrmLogs_Load(object sender, EventArgs e)
        {
            EscribirLogs();
        }

        private void EscribirLogs()
        {
            rtb_Logs.Text = controladorLogs.GetLogs();
        }

        private void btn_Vaciar_Click(object sender, EventArgs e)
        {
            controladorLogs.VaciarRegistros();
            rtb_Logs.Text = String.Empty;
        }
    }
}