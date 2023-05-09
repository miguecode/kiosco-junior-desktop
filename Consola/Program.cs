using System.Runtime.CompilerServices;
using Entidades;
using Helper;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Archivo.Auxiliares();
            //Archivo.EscribirEnArchivo();
            //Archivo.Stream();

            List<Parser> listaUsuariosParser = new List<Parser>();
            listaUsuariosParser.AddRange(Sistema.ListaDeUsuarios);

            List<Parser> listaProductosParser = new List<Parser>();
            listaProductosParser.AddRange(Sistema.ListaDeProductos);

            Archivo.GuardarListas(listaUsuariosParser, "listaUsuarios.txt");
            Archivo.GuardarListas(listaProductosParser, "listaProductos.txt");

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------\n");

            //Archivo.LeerListas("listaUsuarios.txt");
            //Archivo.LeerListas("listaProductos.txt");
        }
    }
}