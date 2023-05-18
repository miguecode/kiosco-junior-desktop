using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Autenticacion
    {
        public static Usuario ConfirmarIngreso(string nick, string contrasenia)
        {
            if (!String.IsNullOrEmpty(nick) && !String.IsNullOrEmpty(contrasenia))
            {
                var usuarioExistente = ValidarUsuarioExistente(nick, contrasenia);

                if (usuarioExistente is not null)
                    return usuarioExistente;

                else
                    throw new Exception("Usuario o contraseña incorrectos");
            }

            throw new Exception(String.Empty);
        }

        private static Usuario? ValidarUsuarioExistente(string nick, string contrasenia)
        {
            foreach (Usuario usuario in Sistema.ListaDeUsuarios)
            {
                if (usuario.NombreUsuario == nick && usuario.Contrasenia == contrasenia)
                    return usuario;
            }

            return null;
        }
    }
}
