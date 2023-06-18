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
    public class ValidarItemEnumerado
    {
        [TestMethod]
        public void ItemNullRetornaFalse()
        {
            Object? item = null;
            Type tipoEnumerado = typeof(ERol);

            bool resultado = Validador.ValidarItemEnumerado(item, tipoEnumerado);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ItemNoDefinidoEnEnumeradoRetornaFalse()
        {
            Object? item = "ItemNoDefinidoEnElEnumerado";
            Type tipoEnumerado = typeof(ERol);

            bool resultado = Validador.ValidarItemEnumerado(item, tipoEnumerado);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ItemDefinidoEnEnumeradoRetornaTrue()
        {
            Object? item = ERol.Empleado;
            Type tipoEnumerado = typeof(ERol);

            bool resultado = Validador.ValidarItemEnumerado(item, tipoEnumerado);

            Assert.IsTrue(resultado);
        }
    }
}
