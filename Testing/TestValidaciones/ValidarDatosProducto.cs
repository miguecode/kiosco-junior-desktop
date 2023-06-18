using Entidades;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestValidaciones
{
    [TestClass]
    public class ValidarDatosProducto
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TipoNoValidoLanzaExcepcion()
        {
            Object? tipo = null;
            string nombre = "Obleas";
            string marca = "Terrabusi";
            float precio = 200;
            float stock = 20;
            string descripcion = "Descripcion del producto";

            Validador.ValidarDatosProducto(tipo, nombre, marca, precio, stock, descripcion);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NombreNoValidoLanzaExcepcion()
        {
            Object tipo = ETipo.Galletitas;
            string nombre = String.Empty;
            string marca = "Terrabusi";
            float precio = 200;
            float stock = 20;
            string descripcion = "Descripcion del producto";

            Validador.ValidarDatosProducto(tipo, nombre, marca, precio, stock, descripcion);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MarcaNoValidoLanzaExcepcion()
        {
            Object tipo = ETipo.Galletitas;
            string nombre = "Obleas";
            string marca = "--";
            float precio = 200;
            float stock = 20;
            string descripcion = "Descripcion del producto";

            Validador.ValidarDatosProducto(tipo, nombre, marca, precio, stock, descripcion);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PrecioNoValidoLanzaExcepcion()
        {
            Object tipo = ETipo.Galletitas;
            string nombre = "Obleas";
            string marca = "Terrabusi";
            float precio = -1;
            float stock = 20;
            string descripcion = "Descripcion del producto";

            Validador.ValidarDatosProducto(tipo, nombre, marca, precio, stock, descripcion);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StockNoValidoLanzaExcepcion()
        {
            Object tipo = ETipo.Galletitas;
            string nombre = "Obleas";
            string marca = "Terrabusi";
            float precio = 200;
            float stock = 99999999999;
            string descripcion = "Descripcion del producto";

            Validador.ValidarDatosProducto(tipo, nombre, marca, precio, stock, descripcion);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DescripcionNoValidoLanzaExcepcion()
        {
            Object tipo = ETipo.Galletitas;
            string nombre = "Obleas";
            string marca = "Terrabusi";
            float precio = 200;
            float stock = 20;
            string descripcion = "A";

            Validador.ValidarDatosProducto(tipo, nombre, marca, precio, stock, descripcion);
        }
    }
}
