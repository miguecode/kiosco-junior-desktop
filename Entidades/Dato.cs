using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Dato
    {
        public abstract string GetParser();
        public abstract Dato CrearEntidadPorLista(List<string> listaDatos);
        public static void VerificarSiExisteEntidad(List<Producto> lista, Producto productoRecibido)
        {
            foreach (Producto producto in lista)
            {
                if (producto == productoRecibido)
                    throw new Exception("Ese producto ya existe");
            }
        }

        public static void VerificarSiExisteEntidad(List<Usuario> lista, Usuario usuarioRecibido)
        {
            foreach (Usuario usuario in lista)
            {
                if (usuario == usuarioRecibido)
                    throw new Exception("Ya existe un usuario con ese nombre de usuario");
            }
        }
    }
}
