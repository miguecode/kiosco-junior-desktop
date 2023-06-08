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
    public class VentaDB : ConsultasSQL, IManipulable<Venta>
    {
        public VentaDB() : base() { }

        public string NombreTabla { get => "ventas"; }
        public string Identificador { get => "id"; }
        public string Atributos 
        {
            get => "(nombre_cliente, valor_total, cantidad_productos," +
                    " cantidad_cigarrillos, cantidad_bebidas, cantidad_snacks," +
                    " cantidad_galletitas, cantidad_dulces, cantidad_comidas, cantidad_otros)";
        }
        public string Valores
        {
            get =>  "VALUES (@nombre_cliente, @valor_total, @cantidad_productos," +
                    " @cantidad_cigarrillos, @cantidad_bebidas, @cantidad_snacks," +
                    " @cantidad_galletitas, @cantidad_dulces, @cantidad_comidas, @cantidad_otros)"; 
        }

        public int Agregar(Venta venta)
        {
            string consulta = $"INSERT INTO {NombreTabla} {Atributos} {Valores}";

            SqlCommand command = new SqlCommand(consulta, Connection);

            EstablecerParametros(command, venta);

            return EjecutarConsultaNonQuery(command);
        }

        public int Eliminar(Venta identificacion)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Venta objeto)
        {
            throw new NotImplementedException();
        }

        public List<Venta> TraerTodosLosRegistros()
        {
            List<Venta> listaDeVentas = new List<Venta>();

            using (var dataTable = EjecutarConsulta($"{TodosLosRegistrosDe} {NombreTabla}"))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Venta nuevaVenta = new Venta();
                    nuevaVenta = nuevaVenta.CrearEntidadPorBaseDeDatos(row);

                    listaDeVentas.Add(nuevaVenta);
                }
            }

            return listaDeVentas;
        }

        public List<Venta> TraerUnRegistro(string id)
        {
            List<Venta> listaDeVentas = new List<Venta>();
            string consulta = $"{TodosLosRegistrosDe} {NombreTabla} WHERE {Identificador} = {id}";

            using (var dataTable = EjecutarConsulta(consulta))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Venta nuevaVenta = new Venta();
                    nuevaVenta = nuevaVenta.CrearEntidadPorBaseDeDatos(row);

                    listaDeVentas.Add(nuevaVenta);
                }
            }

            return listaDeVentas;
        }

        public void EstablecerParametros(SqlCommand command, Venta v)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nombre_cliente", v.NombreCliente);
            command.Parameters.AddWithValue("@valor_total", v.ValorTotal);
            command.Parameters.AddWithValue("@cantidad_productos", v.CantidadProductos);
            command.Parameters.AddWithValue("@cantidad_cigarrillos", v.CantidadCigarrillos);
            command.Parameters.AddWithValue("@cantidad_bebidas", v.CantidadBebidas);
            command.Parameters.AddWithValue("@cantidad_snacks", v.CantidadSnacks);
            command.Parameters.AddWithValue("@cantidad_galletitas", v.CantidadGalletitas);
            command.Parameters.AddWithValue("@cantidad_dulces", v.CantidadDulces);
            command.Parameters.AddWithValue("@cantidad_comidas", v.CantidadComidas);
            command.Parameters.AddWithValue("@cantidad_otros", v.CantidadOtros);
        }
    }
}
