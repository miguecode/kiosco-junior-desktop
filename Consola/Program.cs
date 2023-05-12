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

            List<Dato> listaUsuariosParser = new List<Dato>();
            listaUsuariosParser.AddRange(Sistema.ListaDeUsuarios);

            List<Dato> listaProductosParser = new List<Dato>();
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