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
    /*public class Archivo
    {
        /// <summary>
        /// Carga los archivos principales si es que existen, y sino, los crea por default.
        /// </summary>
        public static void CargarArchivos()
        {
            ComprobarArchivosExistentes("listaUsuarios.txt", "listaProductos.txt", "listaVentas.txt");
            CargarListas("listaUsuarios.txt", new Usuario());
            CargarListas("listaProductos.txt", new Producto());
            CargarListas("listaVentas.txt", new Venta());
        }

        /// <summary>
        /// Verifica la existencia de los 3 archivos principales.
        /// De no existir, los crea y les carga valores predeterminados.
        /// </summary>
        /// <param name="pathUno"></param>
        /// <param name="pathDos"></param>
        /// <param name="pathTres"></param>
        private static void ComprobarArchivosExistentes(string pathUno, string pathDos, string pathTres)
        {
            if (!(File.Exists(pathUno) && File.Exists(pathDos) && File.Exists(pathTres)))
                CrearArchivosPorDefault(pathUno, pathDos, pathTres);
        }

        /// <summary>
        /// Recibe 3 string que serán las rutas. Su función es crear un archivo por cada una de ellas.
        /// Una lista de usuarios, de productos y de ventas. A cada uno le escribe un valor predeterminado.
        /// </summary>
        /// <param name="pathUno"></param>
        /// <param name="pathDos"></param>
        /// <param name="pathTres"></param>
        private static void CrearArchivosPorDefault(string pathUno, string pathDos, string pathTres)
        {
            string valorDefault = "SuperUsuario;Administrador;Administrador;10000000;Nombre;Apellido";
            File.WriteAllText(pathUno, valorDefault);

            valorDefault = "1000;Nombre;Otros;Descripcion del producto.;Marca;100;50";
            File.WriteAllText(pathDos, valorDefault);

            valorDefault = "1000;Nombre Apellido;100;1;0;0;0;0;0;0;1";
            File.WriteAllText(pathTres, valorDefault);
        }

        /// <summary>
        /// Crea una lista de tipo Dato. Se agrega las listas de usuarios, productos y ventas,
        /// y con esas listas llama al método GuardarListas para escribirlas en archivos una por una.
        /// </summary>
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

        /// <summary>
        /// Guarda una lista en específico dependiendo de qué entidad recibe, haciendo uso del GetParser.
        /// </summary>
        /// <param name="entidadLista"></param>
        /// <param name="path"></param>
        public static void GuardarListas(List<Dato> entidadLista, string path)
        {
            StreamWriter sw = new StreamWriter(path, false);

            foreach (Dato entidadLinea in entidadLista)
            {
                //sw.WriteLine(entidadLinea.GetParser());
            }

            sw.Close();
            sw.Dispose();
        }

        /// <summary>
        /// Abre un archivo y lo lee línea a línea. Cada dato de la línea lo lee
        /// separado por ';' haciendo uso del método GetDatosDivididosPorCaracter.
        /// Después, crea todas las entidades una por una y las agrega a su lista correspondiente.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="entidad"></param>
        private static void CargarListas(string path, Dato entidad)
        {
            StreamReader sr = File.OpenText(path);

            while (!sr.EndOfStream)
            {
                List<string> listaDeDatos = GetDatosDivididosPorCaracter(sr, ';');

                Dato entidadCreada = CrearEntidadPorDatos(listaDeDatos, entidad);

                AgregarEntidadALista(entidadCreada);
            }

            sr.Close();
            sr.Dispose();
        }

        /// <summary>
        /// Crea una lista de strings los cuales representan cada dato de una entidad.
        /// Usa Split pasandole el caracter separador que recibe por parámetro.
        /// </summary>
        /// <param name="sr"></param>
        /// <param name="caracter"></param>
        /// <returns>Retorna la lista de strings creada</returns>
        private static List<string> GetDatosDivididosPorCaracter(StreamReader sr, char caracter)
        {
            List<string> listaDeDatos = new List<string>();

            string[]? datoDividido = sr.ReadLine()?.Split(caracter);

            if (datoDividido is not null)
                listaDeDatos.AddRange(datoDividido);

            return listaDeDatos;
        }

        /// <summary>
        /// Dependiendo de cuál sea la entidad, la crea usando CrearEntidadPorLista.
        /// </summary>
        /// <param name="listaDatos"></param>
        /// <param name="entidad"></param>
        /// <returns>Devuelve la entidad creada</returns>
        private static Dato CrearEntidadPorDatos(List<string> listaDatos, Dato entidad)
        {
            //Dato entidadCreada = entidad.CrearEntidadPorLista(listaDatos);

            return entidadCreada;
        }

        /// <summary>
        /// Dependiendo de cuál sea la entidad, se la agrega a su lista correspondiente.
        /// </summary>
        /// <param name="entidad"></param>
        private static void AgregarEntidadALista(Dato entidad)
        {
            if (entidad is Producto)
                Sistema.ListaDeProductos.Add((Producto)entidad);

            if (entidad is Usuario)
                Sistema.ListaDeUsuarios.Add((Usuario)entidad);

            if (entidad is Venta)
                Sistema.ListaDeVentas.Add((Venta)entidad);
        }
    }*/
}
