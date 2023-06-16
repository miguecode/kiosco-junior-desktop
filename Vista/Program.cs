using Entidades;
using Helper;

namespace Vista
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //ControladorSerial.ImportarDatosJSON();
            Application.Run(new FrmLogin());
            ControladorSerial.ExportarDatosCSV();
            ControladorSerial.ExportarDatosJSON();
        }
    }
}