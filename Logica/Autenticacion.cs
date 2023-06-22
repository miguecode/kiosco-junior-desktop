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
        /// <summary>
        /// Valida si el usuario ingresado existe usando el método ValidarUsuarioExistente.
        /// Si existe, retorna al usuario ingresado, y sino, lanza una excepción controlada.
        /// </summary>
        /// <param name="nick"></param>
        /// <param name="contrasenia"></param>
        /// <returns>Retorna al usuario ingresado si es que existe</returns>
        /// <exception cref="Exception"></exception>
        public static Usuario ConfirmarIngresoOrThrow(string nick, string contrasenia)
        {
            if (!string.IsNullOrEmpty(nick) && !string.IsNullOrEmpty(contrasenia))
            {
                Usuario? usuarioExistente = ValidarUsuarioExistente(nick, contrasenia);

                if (usuarioExistente is not null)
                    return usuarioExistente;

                else
                    throw new Exception("Usuario o contraseña incorrectos");
            }

            throw new Exception(string.Empty);
        }
        
        /// <summary>
        /// Es el método encargado de revisar todos los usuarios de la lista de usuarios,
        /// y verificar si sus datos de nombre y contraseña coinciden con los ingresados.
        /// </summary>
        /// <param name="nick"></param>
        /// <param name="contrasenia"></param>
        /// <returns>Si coinciden, retorna al usuario. Sino, retorna null</returns>
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
