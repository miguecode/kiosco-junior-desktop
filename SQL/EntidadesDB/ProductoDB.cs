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
        public ProductoDB() : base(){}

        public string NombreTabla { get => "productos"; }
        public string Identificador { get => "id"; }
        public string Atributos { get => "(nombre, tipo, descripcion, marca, precio, stock)"; }
        public string Valores { get => "VALUES (@nombre, @tipo, @descripcion, @marca, @precio, @stock)"; }

        public int Agregar(Producto producto)
        {
            try
            {
                string consulta = $"INSERT INTO {NombreTabla} {Atributos} {Valores}";

                SqlCommand command = new SqlCommand(consulta, Connection);

                EstablecerParametros(command, producto);

                return EjecutarConsultaNonQuery(command);
            }
            catch(Exception)
            {
                throw new Exception("No se pudo agregar el producto a la DB.");
            }
        }

        public int Eliminar(Producto identificacion)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Producto objeto)
        {
            throw new NotImplementedException();
        }

        public List<Producto> TraerTodosLosRegistros()
        {
            List<Producto> listaDeProductos = new List<Producto>();

            using (var dataTable = EjecutarConsulta($"{TodosLosRegistrosDe} {NombreTabla}"))
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
            string consulta = $"{TodosLosRegistrosDe} {NombreTabla} WHERE {Identificador} = {id}";

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

        public void EstablecerParametros(SqlCommand command, Producto p)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nombre", p.Nombre);
            command.Parameters.AddWithValue("@tipo", p.Tipo);
            command.Parameters.AddWithValue("@descripcion", p.Descripcion);
            command.Parameters.AddWithValue("@marca", p.Marca);
            command.Parameters.AddWithValue("@precio", p.Precio);
            command.Parameters.AddWithValue("@stock", p.Stock);
        }
    }
}

