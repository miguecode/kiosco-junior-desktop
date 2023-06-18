using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestValidaciones
{
    [TestClass]
    public class ValidarStringNumericoRango
    {
        [TestMethod]
        public void CadenaVaciaRetornaFalse()
        {
            string cadena = String.Empty;
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringNumericoRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaMenorAlMinimoRetornaFalse()
        {
            string cadena = "1";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringNumericoRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaMayorAlMaximoRetornaFalse()
        {
            string cadena = "12345";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringNumericoRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConCaracterNoNumericoRetornaFalse()
        {
            string cadena = "12A12";
            int minimo = 1;
            int maximo = 10;

            bool resultado = Validador.ValidarStringNumericoRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaNumericaDentroDelRangoRetornaTrue()
        {
            string cadena = "123";
            int minimo = 2;
            int maximo = 4;

            bool resultado = Validador.ValidarStringNumericoRango(cadena, minimo, maximo);

            Assert.IsTrue(resultado);
        }
    }
}
