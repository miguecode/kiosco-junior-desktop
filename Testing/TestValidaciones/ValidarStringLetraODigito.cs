using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestValidaciones
{
    [TestClass]
    public class ValidarStringLetraODigito
    {
        [TestMethod]
        public void CadenaConCaracterEspecialRetornaFalse1()
        {
            string cadena = "ABC?";

            bool resultado = Validador.ValidarStringLetraODigito(cadena);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConCaracterEspecialRetornaFalse2()
        {
            string cadena = "ABC   ";

            bool resultado = Validador.ValidarStringLetraODigito(cadena);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConCaracterEspecialRetornaFalse3()
        {
            string cadena = "A-B";

            bool resultado = Validador.ValidarStringLetraODigito(cadena);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConCaracterEspecialRetornaFalse4()
        {
            string cadena = "%ABC";

            bool resultado = Validador.ValidarStringLetraODigito(cadena);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaSinCaracterEspecialRetornaTrue()
        {
            string cadena = "ABC123";

            bool resultado = Validador.ValidarStringLetraODigito(cadena);

            Assert.IsTrue(resultado);
        }
    }
}
