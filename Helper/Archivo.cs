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
            Archivo.GuardarListas(listaParser, "llistaProductos.txt");
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
                List<string> listaDeDatos = GetDatosDividosPorCaracter(sr, ';');

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

            if (datoDividido is not null)
                listaDeDatos.AddRange(datoDividido);

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
    }
}
