using Entidades;
using LogicaSQL.EntidadesDerivadas;
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
            serializadorUsuario = new Serializacion<Usuario>("usuariosCSV.csv", "usuariosJSON.json");
            serializadorProducto = new Serializacion<Producto>("productosCSV.csv", "productosJSON.json");
            serializadorVenta = new Serializacion<Venta>("ventasCSV.csv", "ventasJSON.json");
        }

        public static void ExportarDatosCSV()
        {
            serializadorUsuario.SerializarCSV(Sistema.ListaDeUsuarios);
            serializadorProducto.SerializarCSV(Sistema.ListaDeProductos);
            serializadorVenta.SerializarCSV(Sistema.ListaDeVentas);
        }

        public static void ImportarDatosCSV()
        {
            Sistema.ListaDeUsuarios = serializadorUsuario.DeserializarCSV();
            Sistema.ListaDeProductos = serializadorProducto.DeserializarCSV();
            Sistema.ListaDeVentas = serializadorVenta.DeserializarCSV();
            TrasladarImportacionALaDB();
            Eventos.ActualizarTodasLasListas();
        }

        public static void ExportarDatosJSON()
        {
            serializadorUsuario.SerializarJSON(Sistema.ListaDeUsuarios);
            serializadorProducto.SerializarJSON(Sistema.ListaDeProductos);
            serializadorVenta.SerializarJSON(Sistema.ListaDeVentas);
        }

        public static void ImportarDatosJSON()
        {
            Sistema.ListaDeUsuarios = serializadorUsuario.DeserializarJSON();
            Sistema.ListaDeProductos = serializadorProducto.DeserializarJSON();
            Sistema.ListaDeVentas = serializadorVenta.DeserializarJSON();
            TrasladarImportacionALaDB();
            Eventos.ActualizarTodasLasListas();
        }

        public static void ExportarAutomaticamente()
        {
            if (Sistema.ExportacionAutomatica)
            {
                ExportarDatosJSON();
                ExportarDatosCSV();
            }
        }

        /// <summary>
        /// Primero vacía cada tabla. Después las carga otra vez con los datos
        /// que tenga cada lista en el sistema.
        /// </summary>
        private static void TrasladarImportacionALaDB()
        {
            UsuarioDB controladorUsuarioDB = new UsuarioDB();
            controladorUsuarioDB.EliminarTodos();

            ProductoDB controladorProductoDB = new ProductoDB();
            controladorProductoDB.EliminarTodos();

            VentaDB controladorVentaDB = new VentaDB();
            controladorVentaDB.EliminarTodos();

            foreach (Usuario usuario in Sistema.ListaDeUsuarios)
            {
                controladorUsuarioDB.Agregar(usuario);
            }            
            
            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                controladorProductoDB.Agregar(producto);
            }            
            
            foreach (Venta venta in Sistema.ListaDeVentas)
            {
                controladorVentaDB.Agregar(venta);
            }
        }
    }
}
