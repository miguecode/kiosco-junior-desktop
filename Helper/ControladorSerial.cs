using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class ControladorSerial
    {
        public static Serializacion<Usuario> serializadorUsuario;
        public static Serializacion<Producto> serializadorProducto;
        public static Serializacion<Venta> serializadorVenta;

        static ControladorSerial()
        {
            serializadorUsuario = new Serializacion<Usuario>("usuarios.csv");
            serializadorProducto = new Serializacion<Producto>("productos.csv");
            serializadorVenta = new Serializacion<Venta>("ventas.csv");
        }

        public static void SerializarDatos()
        {
            serializadorUsuario.SerializarCSV(Sistema.ListaDeUsuarios);
            serializadorProducto.SerializarCSV(Sistema.ListaDeProductos);
            serializadorVenta.SerializarCSV(Sistema.ListaDeVentas);
        }

        public static void DeserializarDatos()
        {
            Sistema.ListaDeUsuarios = serializadorUsuario.DeserializarCSV();
            Sistema.ListaDeProductos = serializadorProducto.DeserializarCSV();
            Sistema.ListaDeVentas = serializadorVenta.DeserializarCSV();
        }
    }
}
