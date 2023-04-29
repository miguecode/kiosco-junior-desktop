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
        public static List<Usuario> ListaDeUsuarios { get => listaDeUsuarios; }

        static Sistema()
        {
            listaDeUsuarios = Mock.listaDeUsuariosHardcodeada;
        }

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
        //Si existe el usuario, lo devuelvo. Si no, devuelvo la excepción correspondiente

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
