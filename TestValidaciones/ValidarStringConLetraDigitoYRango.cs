using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestValidaciones
{
    [TestClass]
    public class ValidarStringConLetraDigitoYRango
    {
        [TestMethod]
        public void CadenaVaciaRetornaFalse()
        {
            string cadena = string.Empty;
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaMenorAlMinimoRetornaFalse()
        {
            string cadena = "A";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaMayorAlMaximoaRetornaFalse()
        {
            string cadena = "ABC12";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConCaracterEspecialRetornaFalse()
        {
            string cadena = "AB?12";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void SinCaracterEspecialDentroDelRangoRetornaTrue()
        {
            string cadena = "aaaaaaaa";
            int minimo = 1;
            int maximo = 20;

            bool resultado = Validador.ValidarStringConLetraDigitoYRango(cadena, minimo, maximo);

            Assert.IsTrue(resultado);
        }
    }
}
