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
        public static List<Producto> listaDeProductosHardcodeada;

        static Mock()
        {
            HardcodearUsuarios();
            HardcodearProductos();
            

        }

        static private List<Usuario> HardcodearUsuarios()
        {
            listaDeUsuariosHardcodeada = new List<Usuario>();
            listaDeUsuariosHardcodeada.Add(new Usuario("Mario", "Rampi", 39576681, "rampi23", "rampi0001", ERol.Empleado));
            listaDeUsuariosHardcodeada.Add(new Usuario("Mauro", "Luciano", 40874065, "MauuL", "contrasenia", ERol.Empleado));
            listaDeUsuariosHardcodeada.Add(new Usuario("Juan", "Perez", 40288569, "juan0104", "expendedora111", ERol.Empleado));
            listaDeUsuariosHardcodeada.Add(new Usuario("Lucia", "Gomez", 40022491, "99lulu", "cleancode5", ERol.Empleado));
            return listaDeUsuariosHardcodeada;
        }

        static private List<Producto> HardcodearProductos()
        {
            listaDeProductosHardcodeada = new List<Producto>();
            listaDeProductosHardcodeada.Add(new Producto("Alfajor negro", ETipo.Alfajor, "Jorgito", "Alfajor negro simple con dulce de leche.", 150, 100));
            listaDeProductosHardcodeada.Add(new Producto("Gaseosa chica", ETipo.Bebida, "Coca Cola", "Coca Cola sabor original de 600ml.", 200, 50));
            listaDeProductosHardcodeada.Add(new Producto("Agua chica", ETipo.Bebida, "Villavicencio", "Agua sin gas de 600ml.", 170, 20));
            listaDeProductosHardcodeada.Add(new Producto("Papitas chicas", ETipo.Snack, "Lays", "Papitas clásicas chicas.", 100, 80));
            return listaDeProductosHardcodeada;
        }




    }
}
