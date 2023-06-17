using ConexionSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Eventos
    {
        public event Action<string>? SeConfirmoLaCompra;
        public static event Action? SeImportaronDatos;


        public void NotificarCompraExitosa(string mensaje)
        {
            SeConfirmoLaCompra?.Invoke(mensaje);
        }

        public static void ActualizarTodasLasListas()
        {
            SeImportaronDatos?.Invoke();
        }
    }
}
