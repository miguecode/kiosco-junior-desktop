using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestValidaciones
{
    [TestClass]
    public class ValidarStringConLetraSinDigitoYRango
    {
        [TestMethod]
        public void CadenaVaciaRetornaFalse()
        {
            string cadena = String.Empty;
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraSinDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaMenorAlMinimoRetornaFalse()
        {
            string cadena = "A";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraSinDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaMayorAlMaximoaRetornaFalse()
        {
            string cadena = "ABCDE";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraSinDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConCaracterEspecialRetornaFalse()
        {
            string cadena = "AB?CD";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraSinDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConEspaciosSeguidosRetornaFalse()
        {
            string cadena = "AB  CD";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraSinDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConGuionesSeguidosRetornaFalse()
        {
            string cadena = "AB--CD";
            int minimo = 1;
            int maximo = 5;

            bool resultado = Validador.ValidarStringConLetraSinDigitoYRango(cadena, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void SinCaracterEspecialDentroDelRangoRetornaTrue()
        {
            string cadena = "A BCD-E-F-GHI J - -";
            int minimo = 15;
            int maximo = 20;

            bool resultado = Validador.ValidarStringConLetraSinDigitoYRango(cadena, minimo, maximo);

            Assert.IsTrue(resultado);
        }
    }
}
