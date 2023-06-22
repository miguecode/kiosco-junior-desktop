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
            object? tipo = null;
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
            object tipo = ETipo.Galletitas;
            string nombre = string.Empty;
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
            object tipo = ETipo.Galletitas;
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
            object tipo = ETipo.Galletitas;
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
            object tipo = ETipo.Galletitas;
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
            object tipo = ETipo.Galletitas;
            string nombre = "Obleas";
            string marca = "Terrabusi";
            float precio = 200;
            float stock = 20;
            string descripcion = "A";

            Validador.ValidarDatosProducto(tipo, nombre, marca, precio, stock, descripcion);
        }
    }
}
