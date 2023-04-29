using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class Mock
    {
        public static List<Usuario> listaDeUsuariosHardcodeada;

        static Mock()
        {
            HardcodearUsuarios();

            

        }

        static private List<Usuario> HardcodearUsuarios()
        {
            listaDeUsuariosHardcodeada = new List<Usuario>();
            listaDeUsuariosHardcodeada.Add(new Usuario("Mario", "Rampi", 39576681, "rampi23", "rampi0001"));
            listaDeUsuariosHardcodeada.Add(new Usuario("Mauro", "Luciano", 40874065, "MauuL", "contrasenia"));
            listaDeUsuariosHardcodeada.Add(new Usuario("Juan", "Perez", 40288569, "juan0104", "expendedora111"));
            listaDeUsuariosHardcodeada.Add(new Usuario("Lucia", "Gomez", 40022491, "99lulu", "cleancode5"));
            return listaDeUsuariosHardcodeada;
        }






    }
}
