using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Dato
    {
        /// <summary>
        /// Su función es retornar un string con todos los datos de una entidad
        /// separados por ';'. Las clases derivadas de ésta lo usarán como corresponde.
        /// </summary>
        /// <returns>Retorna el string</returns>
        public abstract string GetParser();

        /// <summary>
        /// Su función es instanciar una entidad basandose en los valores de una lista string de datos.
        /// </summary>
        /// <param name="listaDatos"></param>
        /// <returns>Retorna la entidad creada</returns>
        public abstract Dato CrearEntidadPorLista(List<string> listaDatos);

        public static void VerificarSiExisteEntidadOrThrow(List<Producto> lista, Producto productoRecibido)
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
