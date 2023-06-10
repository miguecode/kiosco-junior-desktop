using ConexionSQL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDB
{
    public class ProductoDB : ConsultasSQL, IManipulable<Producto>
    {
        Dictionary<string, string> consultas = new Dictionary<string, string>();

        public ProductoDB() : base() { EscribirConsultas(); }

        public int Agregar(Producto producto)
        {
            try
            {
                string consulta = consultas["Agregar producto"];

                SqlCommand command = new SqlCommand(consulta, Connection);

                EstablecerParametros(command, producto);

                return EjecutarConsultaNonQuery(command);
            }
            catch(Exception)
            {
                throw new Exception("No se pudo agregar el producto a la DB.");
            }
        }

        public int Eliminar(Producto producto)
        {
            try
            {
                string consulta = consultas["Eliminar producto"];

                SqlCommand command = new SqlCommand(consulta, Connection);
                command.Parameters.AddWithValue("@id", producto.IdDB);

                return EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo eliminar el producto de la DB");
            }
        }

        public int Modificar(Producto producto)
        {
            try
            {
                string consulta = consultas["Modificar producto"];

                SqlCommand command = new SqlCommand(consulta, Connection);

                EstablecerParametros(command, producto);

                return EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo modificar el producto en la DB");
            }
        }

        public List<Producto> TraerTodosLosRegistros()
        {
            List<Producto> listaDeProductos = new List<Producto>();
            string consulta = consultas["Traer todos los productos"];

            using (var dataTable = EjecutarConsulta(consulta))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Producto nuevoProducto = new Producto();
                    nuevoProducto = nuevoProducto.CrearEntidadPorBaseDeDatos(row);

                    listaDeProductos.Add(nuevoProducto);
                }
            }

            return listaDeProductos;
        }

        public List<Producto> TraerUnRegistro(string id)
        {
            List<Producto> listaDeProductos = new List<Producto>();
            string consulta = $"SELECT * FROM productos WHERE id = {id}";

            using (var dataTable = EjecutarConsulta(consulta))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Producto nuevoProducto = new Producto();
                    nuevoProducto = nuevoProducto.CrearEntidadPorBaseDeDatos(row);

                    listaDeProductos.Add(nuevoProducto);
                }
            }

            return listaDeProductos;
        }

        private void EscribirConsultas()
        {
            consultas.Add("Agregar producto",
                "INSERT INTO productos (nombre, tipo, descripcion, marca, precio, stock )" +
                "VALUES (@nombre, @tipo, @descripcion, @marca, @precio, @stock)");

            consultas.Add("Eliminar producto",
                "DELETE FROM productos WHERE id = @id");

            consultas.Add("Modificar producto",
                "UPDATE productos SET nombre = @nombre, tipo = @tipo, " +
                "descripcion = @descripcion, marca = @marca, precio = @precio, stock = @stock " +
                "WHERE id = @id");

            consultas.Add("Traer todos los productos", "SELECT * FROM productos");
            //consultas.Add("Traer producto que coincida", "");
        }

        private void EstablecerParametros(SqlCommand command, Producto p)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", p.IdDB);
            command.Parameters.AddWithValue("@nombre", p.Nombre);
            command.Parameters.AddWithValue("@tipo", p.Tipo);
            command.Parameters.AddWithValue("@descripcion", p.Descripcion);
            command.Parameters.AddWithValue("@marca", p.Marca);
            command.Parameters.AddWithValue("@precio", p.Precio);
            command.Parameters.AddWithValue("@stock", p.Stock);
        }
    }
}

