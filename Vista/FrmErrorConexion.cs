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
    public partial class FrmErrorConexion : Form
    {
        public FrmErrorConexion()
        {
            InitializeComponent();
        }

        private void btn_readme_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Leumig/CSharp-.NET-Kiosco-Junior/blob/master/README.md";

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir tu navegador, el link del README es: " +
                    "https://github.com/Leumig/CSharp-.NET-Kiosco-Junior/blob/master/README.md");
            }
        }

    }
}
