using ConexionSQL;
using Entidades;
using EntidadesDB;
using Helper;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serializacion<Usuario>.SerializarJSON(Sistema.ListaDeUsuarios, "usuarios.json");

            /*UsuarioDB entidadUsuarioDB = new UsuarioDB();
            ProductoDB entidadProductoDB = new ProductoDB();
            VentaDB entidadVentaDB = new VentaDB();
            //Creo las entidades de tipo EntidadesDB. Genera todo el proceso de conexión y 
            //creación de la consulta.

            List<Usuario> usuarios = entidadUsuarioDB.TraerTodosLosRegistros();
            List<Producto> productos = entidadProductoDB.TraerTodosLosRegistros();
            List<Venta> ventas = entidadVentaDB.TraerTodosLosRegistros();
            //Creo listas y las cargo usando este método el cual ejecuta el comando que le corresponde.

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.ToString());
            }

            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto.ToString());
            }

            foreach (Venta venta in ventas)
            {
                Console.WriteLine(venta.ToString());
            }

            List<Usuario> usuarios = entidadUsuarioDB.TraerTodosLosRegistros();
            //Agregar
            Usuario usuarioNuevo = new Usuario("Mario", "Rampi", 40576681, "Rampi23", "rampi0001", ERol.SuperUsuario);

            entidadUsuarioDB.Agregar(usuarioNuevo);

            usuarios = entidadUsuarioDB.TraerTodosLosRegistros();

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.ToString());
            }

            //Eliminar
            int filasAfectadas = entidadUsuarioDB.Eliminar(usuarioNuevo);
            Console.WriteLine($"Filas afectadas: {filasAfectadas}");

            usuarios = entidadUsuarioDB.TraerTodosLosRegistros();

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.ToString());
            }

            //Modificar
            int filasAfectadas = entidadUsuarioDB.Modificar(usuarioNuevo);

            Console.WriteLine($"Filas afectadas: {filasAfectadas}");

            usuarios = entidadUsuarioDB.TraerTodosLosRegistros();

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.ToString());
            }

            //Aca, muestro lo que cargue en cada lista de Sistema (lo hice en su clase)
            foreach (Usuario usuario in Sistema.ListaDeUsuarios)
            {
                Console.WriteLine(usuario.ToString());
            }

            foreach (Producto producto in Sistema.ListaDeProductos)
            {
                Console.WriteLine(producto.ToString());
            }

            foreach (Venta venta in Sistema.ListaDeVentas)
            {
                Console.WriteLine(venta.ToString());
            }*/
        }
    }
}