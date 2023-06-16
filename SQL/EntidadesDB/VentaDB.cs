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
        Dictionary<string, string> consultas = new Dictionary<string, string>();

        public VentaDB() : base() { EscribirConsultas(); }

        public int Agregar(Venta venta)
        {
            string consulta = consultas["Agregar venta"];

            SqlCommand command = new SqlCommand(consulta, Connection);

            EstablecerParametros(command, venta);

            return EjecutarConsultaNonQuery(command);
        }

        public int Eliminar(Venta venta)
        {
            try
            {
                string consulta = consultas["Eliminar ventas"];

                SqlCommand command = new SqlCommand(consulta, Connection);

                return EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudieron eliminar las ventas de la DB");
            }
        }

        public int Modificar(Venta venta)
        {
            throw new Exception("No se modifican las ventas");
        }

        public List<Venta> TraerTodosLosRegistros()
        {
            List<Venta> listaDeVentas = new List<Venta>();
            string consulta = consultas["Traer todas las ventas"];

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

        public List<Venta> TraerUnRegistro(string id)
        {
            List<Venta> listaDeVentas = new List<Venta>();
            string consulta = $"SELECT * FROM ventas WHERE id = {id}";

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

        private void EscribirConsultas()
        {
            consultas.Add("Agregar venta",
                "INSERT INTO ventas (nombre_cliente, valor_total, cantidad_productos," +
                "cantidad_cigarrillos, cantidad_bebidas, cantidad_snacks," +
                "cantidad_galletitas, cantidad_dulces, cantidad_comidas, cantidad_otros) " +
                "VALUES(@nombre_cliente, @valor_total, @cantidad_productos," +
                "@cantidad_cigarrillos, @cantidad_bebidas, @cantidad_snacks," +
                "@cantidad_galletitas, @cantidad_dulces, @cantidad_comidas, @cantidad_otros)");

            consultas.Add("Eliminar ventas", "DELETE FROM ventas\n" +
                          "DBCC CHECKIDENT ('Ventas', RESEED, 1000)");

            consultas.Add("Traer todas las ventas", "SELECT * FROM ventas");

            //consultas.Add("Traer venta que coincida", "");
        }

        private void EstablecerParametros(SqlCommand command, Venta v)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", v.IdDB);
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
