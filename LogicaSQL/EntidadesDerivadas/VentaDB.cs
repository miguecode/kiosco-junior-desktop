using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSQL.EntidadesDerivadas
{
    public class VentaDB : EntidadDB<Venta>
    {
        private const string auxTabla = "ventas";

        private const string auxColumnas = "nombre_cliente, valor_total, cantidad_productos," +
            " cantidad_cigarrillos, cantidad_bebidas, cantidad_snacks, cantidad_galletitas," +
            " cantidad_dulces, cantidad_comidas, cantidad_otros";

        private const string auxValores = "@nombre_cliente, @valor_total, @cantidad_productos," +
            " @cantidad_cigarrillos, @cantidad_bebidas, @cantidad_snacks, @cantidad_galletitas," +
            " @cantidad_dulces, @cantidad_comidas, @cantidad_otros";

        private const string auxId = "id";

        public VentaDB() : base(auxTabla, auxColumnas, auxValores, auxId, string.Empty) { }

        protected override Venta CrearEntidadDesdeDataTable(DataRow row)
        {
            int id = Convert.ToInt32(row["id"].ToString());
            string nombreCliente = row["nombre_cliente"].ToString() ?? "";
            float valor = Convert.ToSingle(row["valor_total"].ToString());
            int cantidadProductos = Convert.ToInt32(row["cantidad_productos"].ToString());
            int cantidadCigarrillos = Convert.ToInt32(row["cantidad_cigarrillos"].ToString());
            int cantidadBebidas = Convert.ToInt32(row["cantidad_bebidas"].ToString());
            int cantidadSnacks = Convert.ToInt32(row["cantidad_snacks"].ToString());
            int cantidadGalletitas = Convert.ToInt32(row["cantidad_galletitas"].ToString());
            int cantidadDulces = Convert.ToInt32(row["cantidad_dulces"].ToString());
            int cantidadComidas = Convert.ToInt32(row["cantidad_comidas"].ToString());
            int cantidadOtros = Convert.ToInt32(row["cantidad_otros"].ToString());

            Venta ventaCreada = new Venta(id, nombreCliente, valor, cantidadProductos, cantidadCigarrillos,
                            cantidadBebidas, cantidadSnacks, cantidadGalletitas, cantidadDulces, cantidadComidas, cantidadOtros);

            return ventaCreada;
        }
    }
}
