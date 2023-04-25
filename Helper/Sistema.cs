using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class Sistema
    {
        private static List<Usuario> listaDeUsuarios;

        static Sistema()
        {
            listaDeUsuarios = Mock.listaDeUsuariosHardcodeada;
        }

        public static bool ConfirmarIngreso(string nick, string contrasenia)
        {
            if (!String.IsNullOrEmpty(nick) && !String.IsNullOrEmpty(contrasenia))
            {
                Usuario? usuarioExistente = ValidarUsuarioExistente(nick, contrasenia);

                if (usuarioExistente is not null)
                {
                    return true;
                }
                //throw new Exception("Usuario o contraseña incorrectos");
            }
            //throw new Exception(String.Empty);
            return false;
        }
        //Las excepciones funcionan pero el método debería devolver un Usuario (o sino, la excep)

        private static Usuario? ValidarUsuarioExistente(string nick, string contrasenia)
        {
            foreach (Usuario itemUsuario in listaDeUsuarios)
            {
                if (itemUsuario.NombreUsuario == nick && itemUsuario.Contrasenia == contrasenia)
                {
                    return itemUsuario;
                }
            }

            return null;
        }









    }
}
