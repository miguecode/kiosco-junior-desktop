using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestValidaciones
{
    [TestClass]
    public class ValidarFloatRango
    {
        [TestMethod]
        public void FloatMenorAlMinimoRetornaFalse()
        {
            float cantidad = 1;
            float minimo = 1;
            float maximo = 5;

            bool resultado = Validador.ValidarFloatRango(cantidad, minimo, maximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void FloatMayorAlMaximoRetornaFalse()
        {
            float cantidad = 5;
            float minimo = 1;
            float maximo = 5;

            bool resultado = Validador.ValidarFloatRango(cantidad, minimo, maximo);

            Assert.IsFalse(resultado);
        }
        
        [TestMethod]
        public void FloatDentroDelRangoRetornaTrue()
        {
            float cantidad = 2;
            float minimo = 1.9f;
            float maximo = 2.1f;

            bool resultado = Validador.ValidarFloatRango(cantidad, minimo, maximo);

            Assert.IsTrue(resultado);
        }
    }
}
