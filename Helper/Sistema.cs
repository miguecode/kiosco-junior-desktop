using Entidades;
using EntidadesDB;
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
        public static List<Usuario> ListaDeUsuarios { get => listaDeUsuarios; set => listaDeUsuarios = value; }
        public static List<Producto> ListaDeProductos { get => listaDeProductos; set => listaDeProductos = value; }
        public static List<Venta> ListaDeVentas { get => listaDeVentas; set => listaDeVentas = value; }

        static Sistema()
        {
            /*listaDeUsuarios = new List<Usuario>();
            listaDeProductos = new List<Producto>();
            listaDeVentas = new List<Venta>();*/

            UsuarioDB entidadUsuarioDB = new UsuarioDB();
            ProductoDB entidadProductoDB = new ProductoDB();
            VentaDB entidadVentaDB = new VentaDB();

            listaDeUsuarios = entidadUsuarioDB.TraerTodosLosRegistros();
            listaDeProductos = entidadProductoDB.TraerTodosLosRegistros();
            listaDeVentas = entidadVentaDB.TraerTodosLosRegistros();
        }
    }
}
