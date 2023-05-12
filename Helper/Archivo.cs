using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Helper
{
    public class Archivo
    {
        public Archivo()
        {
        }

        public static void CargarArchivos()
        {
            CargarListas("listaUsuarios.txt", new Usuario());
            CargarListas("listaProductos.txt", new Producto());
            CargarListas("listaVentas.txt", new Venta());
        }

        public static void GuardarArchivos()
        {
            List<Dato> listaParser = new List<Dato>();

            listaParser.AddRange(Sistema.ListaDeUsuarios);
            Archivo.GuardarListas(listaParser, "listaUsuarios.txt");
            listaParser.Clear();

            listaParser.AddRange(Sistema.ListaDeProductos);
            Archivo.GuardarListas(listaParser, "listaProductos.txt");
            listaParser.Clear();

            listaParser.AddRange(Sistema.ListaDeVentas);
            Archivo.GuardarListas(listaParser, "listaVentas.txt");
        }

        public static void GuardarListas(List<Dato> entidadLista, string path)
        {
            StreamWriter sw = new StreamWriter(path, false);

            foreach (Dato entidadLinea in entidadLista)
            {
                sw.WriteLine(entidadLinea.GetParser());
            }

            sw.Close();
            sw.Dispose();
        }

        public static void CargarListas(string path, Dato entidad)
        {
            StreamReader sr = File.OpenText(path);

            while (!sr.EndOfStream)
            {
                List<string> listaDeDatos = GetDatosDividosPorCaracter(sr, ',');

                Dato entidadCreada = CrearEntidadPorDatos(listaDeDatos, entidad);

                AgregarEntidadALista(entidadCreada);         
            }

            sr.Close();
            sr.Dispose();
        }
        
        private static List<string> GetDatosDividosPorCaracter(StreamReader sr, char caracter)
        {
            List<string> listaDeDatos = new List<string>();

            string[]? datoDividido = sr.ReadLine()?.Split(caracter);

            if(datoDividido is not null)
            {
                listaDeDatos.AddRange(datoDividido);
            }

            return listaDeDatos;
        }

        private static Dato CrearEntidadPorDatos(List<string> listaDatos, Dato entidad)
        {
            Dato entidadCreada = entidad.CrearEntidadPorLista(listaDatos);

            return entidadCreada;
        }

        private static void AgregarEntidadALista(Dato entidad)
        {
            if (entidad is Producto)
                Sistema.ListaDeProductos.Add((Producto)entidad);

            if (entidad is Usuario)
                Sistema.ListaDeUsuarios.Add((Usuario)entidad);

            if (entidad is Venta)
                Sistema.ListaDeVentas.Add((Venta)entidad);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////
        public static void Auxiliares()
        {
            Console.WriteLine("Es Windows: {0}", OperatingSystem.IsWindows());
            Console.WriteLine("Es Linux: {0}", OperatingSystem.IsLinux());
            Console.WriteLine("Es MacOS: {0}", OperatingSystem.IsMacOS());
            Console.WriteLine("Es Android: {0}", OperatingSystem.IsAndroid());
            Console.WriteLine("Es IOS: {0}", OperatingSystem.IsIOS());
            Console.WriteLine("Es Browser: {0}", OperatingSystem.IsBrowser());

            Console.WriteLine("Version SO: {0}", Environment.OSVersion);
            Console.WriteLine("Info: {0}", Environment.OSVersion.Platform);
            Console.WriteLine("Info: {0}", Environment.MachineName);
        }

        public static void Rutas()
        {
            //PATH = RUTA
            Console.WriteLine("Path.DirectorySeparatorChar: {0}", Path.DirectorySeparatorChar);
            Console.WriteLine("Path.PathSeparator: {0}", Path.PathSeparator);
            Console.WriteLine("Path.GetFullPath: {0}", Path.GetFullPath(".\\."));
            Console.WriteLine("Path.Combine: {0}", Path.Combine("..", ".."));

            Console.WriteLine("Directory.GetCurrentDirectory: {0}", Directory.GetCurrentDirectory());
        }

        public static void EscribirEnArchivo()
        {
            StringBuilder sb = new StringBuilder();
        
            //sb.AppendLine("AAAAAAAAAAAAAAAAA");
            sb.AppendLine("Estoy escribiendo mi primer archivo.");
            sb.AppendLine("Esto podría ser la línea de datos de un producto.");
            sb.AppendLine("En este caso uso un StringBuilder.");
            sb.AppendLine("Y lo voy a crear con File.WriteAllText");
            File.WriteAllText("./mi_archivo.txt", sb.ToString());            
            //CREA un archivo y lo cierra. Si ya existía, lo sobreescribe.
            //WriteAllText recibe un path (ruta), y después el string.
            //Ese ' ./ ' que ponemos antes del nombre del archivo, es parte de la ruta.
            //Por defecto, si no escribimos la ruta entera se va a crear en donde se
            //esté ejecutando el programa. El '.txt' es el tipo de archivo.

            string[] texto =
            {                
                //"BBBBBBBBBBBBB",
                "Estoy escribiendo mi primer archivo.",
                "Esto podría ser la línea de datos de un producto.",
                "En este caso uso un array de strings.",
                "Y lo voy a crear con File.WriteAllLines"                
            };

            //File.WriteAllLines("./mi_archivo.txt", texto);
            //Recibe un array de strings y escribe todos sus elementos
            //Funciona igual que el anterior, creando o sobreescribiendo el archivo.
        }

        public static void Stream() //Otra forma de escribir archivos
        {
            List<string> listaDeTexto = new List<string>();

            listaDeTexto.Add("Estoy escribiendo mi primer archivo.");
            listaDeTexto.Add("En este caso uso una List<string>.");
            listaDeTexto.Add("Y lo voy a crear con un StreamWriter");

            StreamWriter streamWriter = new StreamWriter("mi_archivo_stream.txt", true);
            //Ese 'true' hace que funcione como un Append. Es decir, no va a sobreescribir nada.
            //No es necesario escribirlo porque por defecto es true, pero si ponemos false, sobreescribe.

            foreach (string linea in listaDeTexto)
            {
                //if() //Le podemos poner condiciones, si pasa tal cosa, le escribo, sino no, etc.
                //{
                    streamWriter.WriteLine(linea);
                    //El WriteLine escribe la línea en el archivo
                //}

            }

            streamWriter.Close(); //Cierra el archivo
            streamWriter.Dispose(); //Destruye el archivo
        }
    }
}
