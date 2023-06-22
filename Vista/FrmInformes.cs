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
    public partial class FrmInformes : Form
    {
        private Usuario usuario;

        public FrmInformes(Usuario usuarioActual)
        {
            InitializeComponent();
            usuario = usuarioActual;
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            chk_ExportacionAutomatica.Checked = Sistema.ExportacionAutomatica;
        }

        private void btn_ExportarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorSerial.ExportarDatosCSV();
                MessageBox.Show("Exportación de datos CSV completada.", "Kiosco Junior",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Logs.CrearRegistro(usuario.NombreUsuario, "Exportó datos en formato CSV");
            } catch(Exception)
            {
                MessageBox.Show("Ocurrió un error en la exportación de datos CSV.", "Kiosco Junior",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorSerial.ExportarDatosJSON();
                MessageBox.Show("Exportación de datos JSON completada.", "Kiosco Junior",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Logs.CrearRegistro(usuario.NombreUsuario, "Exportó datos en formato JSON");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error en la exportación de datos JSON.", "Kiosco Junior",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ImportarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorSerial.ImportarDatosCSV();
                MessageBox.Show("Importación de datos CSV completada.", "Kiosco Junior",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Logs.CrearRegistro(usuario.NombreUsuario, "Importó datos en formato CSV");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error en la importación de datos CSV.", "Kiosco Junior",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_ImportarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorSerial.ImportarDatosJSON();
                MessageBox.Show("Importación de datos JSON completada.", "Kiosco Junior",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Logs.CrearRegistro(usuario.NombreUsuario, "Importó datos en formato JSON");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error en la importación de datos JSON.", "Kiosco Junior",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_ExportacionAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ExportacionAutomatica.Checked)
                Sistema.ExportacionAutomatica = true;
            else
                Sistema.ExportacionAutomatica = false;
        }
    }
}
