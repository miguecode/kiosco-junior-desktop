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
            //Archivo.CargarArchivos();
            ControladorSerial.DeserializarDatos();
            Application.Run(new FrmLogin());
            //Archivo.GuardarArchivos();
            ControladorSerial.SerializarDatos();
        }
    }
}