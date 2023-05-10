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
        private static List<Producto> listaDeProductos;
        public static List<Usuario> ListaDeUsuarios { get => listaDeUsuarios; }
        public static List<Producto> ListaDeProductos { get => listaDeProductos; }

        static Sistema()
        {
            listaDeUsuarios = new List<Usuario>();
            listaDeProductos = new List<Producto>();

            //listaDeUsuarios = Mock.listaDeUsuariosHardcodeada;
            //listaDeProductos = Mock.listaDeProductosHardcodeada;
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
