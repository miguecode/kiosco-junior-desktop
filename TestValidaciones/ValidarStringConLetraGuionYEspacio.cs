using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestValidaciones
{
    [TestClass]
    public class ValidarStringConLetraGuionYEspacio
    {
        [TestMethod]
        public void CadenaConNumeroRetornaFalse()
        {
            string cadena = "Hola 5";

            bool resultado = Validador.ValidarStringConLetraGuionYEspacio(cadena);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConCaracterEspecialRetornaFalse1()
        {
            string cadena = "Hola ?";

            bool resultado = Validador.ValidarStringConLetraGuionYEspacio(cadena);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConCaracterEspecialRetornaFalse2()
        {
            string cadena = "Hola _";

            bool resultado = Validador.ValidarStringConLetraGuionYEspacio(cadena);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void CadenaConLetrasEspaciosOGuionesRetornaTrue()
        {
            string cadena = "  H-  ---  O--L AA A --   ";

            bool resultado = Validador.ValidarStringConLetraGuionYEspacio(cadena);

            Assert.IsTrue(resultado);
        }

        public void CadenaVaciaRetornaTrue()
        {
            string cadena = string.Empty;

            bool resultado = Validador.ValidarStringConLetraGuionYEspacio(cadena);

            Assert.IsTrue(resultado);
        }
    }
}
