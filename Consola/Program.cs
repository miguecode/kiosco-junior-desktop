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
            //Conexion.Leer();

            UsuarioDB entidadUsuarioDB = new UsuarioDB();
            //Creo una entidad de tipo UsuarioDB. Genera todo el proceso de conexión y 
            //creación de la consulta.

            List<Usuario> usuarios = entidadUsuarioDB.TraerTodosLosRegistros();
            //Creo una lista de usuarios. Con el método Traer de la entidad, ejecuto el comando
            //que le corresponde y devuelvo una lista con los datos cargados.


            //Aca, muestro lo que me devolvio cada lista que acabo de crear
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario.ToString());
            }

            ProductoDB entidadProductoDB = new ProductoDB();
            List<Producto> productos = entidadProductoDB.TraerTodosLosRegistros();

            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto.ToString());
            }

            VentaDB entidadVentaDB = new VentaDB();
            List<Venta> ventas = entidadVentaDB.TraerTodosLosRegistros();

            foreach (Venta venta in ventas)
            {
                Console.WriteLine(venta.ToString());
            }

            //Aca, muestro lo que cargue en cada lista de Sistema (lo hice en su clase)
            /*foreach (Usuario usuario in Sistema.ListaDeUsuarios)
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
            
            


            //Todo esto lo hice usando el CargadorDeDatosDB. No me convence.
            //Es una clase que hice dentro de la carpeta de EntidadesDB que le manda todo
            //directamente a las listas de Sistema.
            /*var cargadorDB = new CargadorDeDatosDB();
            cargadorDB.CargarDatosAlSistema();

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