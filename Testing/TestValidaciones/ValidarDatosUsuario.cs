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
    public class ValidarDatosUsuario
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RolNoValidoLanzaExcepcion()
        {
            Object? rol = null;
            string nombre = "Juan";
            string apellido = "Ramirez";
            string dni = "50388176";
            string nombreUsuario = "JuuanR12";
            string contrasenia = "130802jnr";

            Validador.ValidarDatosUsuario(rol, nombre, apellido, dni, nombreUsuario, contrasenia);   
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NombreNoValidoLanzaExcepcion()
        {
            Object? rol = ERol.SuperUsuario;
            string nombre = "12345??";
            string apellido = "Ramirez";
            string dni = "50388176";
            string nombreUsuario = "JuuanR12";
            string contrasenia = "130802jnr";

            Validador.ValidarDatosUsuario(rol, nombre, apellido, dni, nombreUsuario, contrasenia);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ApellidoNoValidoLanzaExcepcion()
        {
            Object? rol = ERol.Cliente;
            string nombre = "Juan";
            string apellido = String.Empty;
            string dni = "50388176";
            string nombreUsuario = "JuuanR12";
            string contrasenia = "130802jnr";

            Validador.ValidarDatosUsuario(rol, nombre, apellido, dni, nombreUsuario, contrasenia);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DniNoValidoLanzaExcepcion()
        {
            Object? rol = ERol.Empleado;
            string nombre = "Juan";
            string apellido = "Ramirez";
            string dni = "ABCDEFGHI";
            string nombreUsuario = "JuuanR12";
            string contrasenia = "130802jnr";

            Validador.ValidarDatosUsuario(rol, nombre, apellido, dni, nombreUsuario, contrasenia);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NombreUsuarioNoValidoLanzaExcepcion()
        {
            Object? rol = ERol.Cliente;
            string nombre = "Juan";
            string apellido = "Ramirez";
            string dni = "50388176";
            string nombreUsuario = "Juan$";
            string contrasenia = "130802jnr";

            Validador.ValidarDatosUsuario(rol, nombre, apellido, dni, nombreUsuario, contrasenia);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ContraseniaNoValidaLanzaExcepcion()
        {
            Object? rol = ERol.SuperUsuario;
            string nombre = "Juan";
            string apellido = "Ramirez";
            string dni = "50388176";
            string nombreUsuario = "JuuanR12";
            string contrasenia = String.Empty;

            Validador.ValidarDatosUsuario(rol, nombre, apellido, dni, nombreUsuario, contrasenia);
        }
    }
}
