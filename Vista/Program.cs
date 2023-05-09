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
            CargarDatos();
            Application.Run(new FrmLogin());
            GuardarDatos();
        }

        private static void CargarDatos()
        {
            Archivo.CargarListas("listaUsuarios.txt", new Usuario());
            Archivo.CargarListas("listaProductos.txt", new Producto());
        }

        private static void GuardarDatos()
        {
            List<Parser> listaParser = new List<Parser>();

            listaParser.AddRange(Sistema.ListaDeUsuarios);

            Archivo.GuardarListas(listaParser, "listaUsuarios.txt");

            listaParser.Clear();

            listaParser.AddRange(Sistema.ListaDeProductos);

            Archivo.GuardarListas(listaParser, "listaProductos.txt");
        }







    }
}