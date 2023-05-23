using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class Sistema
    {
        private static List<Usuario> listaDeUsuarios;
        private static List<Producto> listaDeProductos;
        private static List<Venta> listaDeVentas;
        public static List<Usuario> ListaDeUsuarios { get => listaDeUsuarios; }
        public static List<Producto> ListaDeProductos { get => listaDeProductos; }
        public static List<Venta> ListaDeVentas { get => listaDeVentas; }

        static Sistema()
        {
            listaDeUsuarios = new List<Usuario>();
            listaDeProductos = new List<Producto>();
            listaDeVentas = new List<Venta>();
        }
    }
}
