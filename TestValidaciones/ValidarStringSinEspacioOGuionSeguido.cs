using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestValidaciones
{
    [TestClass]
    public class ValidarStringSinEspacioOGuionSeguido
    {
        [TestMethod]
        public void CadenaConEspaciosSeguidosRetornaFalse()
        {
            string cadena = "AB  CD";

            bool resultado = Validador.ValidarStringSinEspacioOGuionSeguido(cadena);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConGuionesSeguidosRetornaFalse()
        {
            string cadena = "AB--CD";

            bool resultado = Validador.ValidarStringSinEspacioOGuionSeguido(cadena);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaSinEspaciosOGuionesSeguidosRetornaTrue()
        {
            string cadena = " AB-CD- E F G- - -";

            bool resultado = Validador.ValidarStringSinEspacioOGuionSeguido(cadena);

            Assert.IsTrue(resultado);
        }
    }
}
