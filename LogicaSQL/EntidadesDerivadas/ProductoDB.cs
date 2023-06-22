using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSQL.EntidadesDerivadas
{
    public class ProductoDB : EntidadDB<Producto>
    {
        private const string auxTabla = "productos";

        private const string auxColumnas = "nombre, tipo, descripcion, marca, precio, stock";

        private const string auxValores = "@nombre, @tipo, @descripcion, @marca, @precio, @stock";

        private const string auxId = "id";

        private const string auxAsignacion = "nombre = @nombre, tipo = @tipo," +
            " descripcion = @descripcion, marca = @marca, precio = @precio, stock = @stock";

        public ProductoDB() : base(auxTabla, auxColumnas, auxValores, auxId, auxAsignacion) { }

        protected override Producto CrearEntidadDesdeDataTable(DataRow row)
        {
            int id = Convert.ToInt32(row["id"].ToString());
            string nombre = row["nombre"].ToString() ?? "";
            string marca = row["marca"].ToString() ?? "";
            string descripcion = row["descripcion"].ToString() ?? "";
            float precio = Convert.ToSingle(row["precio"].ToString());
            _ = Enum.TryParse(row["tipo"].ToString() ?? "", out ETipo tipo);
            int stock = Convert.ToInt32(row["stock"].ToString());

            Producto productoCreado = new Producto(id, nombre, tipo, marca, descripcion, precio, stock);

            return productoCreado;
        }
    }
}
