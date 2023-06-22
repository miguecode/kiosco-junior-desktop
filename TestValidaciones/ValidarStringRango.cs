using Helper;
using System.Runtime.Versioning;

namespace TestValidaciones
{
    [TestClass]
    public class ValidarStringRango
    {
        [TestMethod]
        public void CadenaVaciaRetornaFalse()
        {
            string cadena = string.Empty;
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaMenorAlMinimoRetornaFalse()
        {
            string cadena = "A";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaMayorAlMaximoRetornaFalse()
        {
            string cadena = "ABCDE";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaDentroDelRangoRetornaTrue()
        {
            string cadena = "AB";
            int minimo = 1;
            int maximo = 3;

            bool resultado = Validador.ValidarStringRango(cadena, minimo, maximo);

            Assert.IsTrue(resultado);
        }
    }
}