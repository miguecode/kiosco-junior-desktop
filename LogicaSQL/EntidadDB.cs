using Entidades;
using LogicaSQL.EntidadesDerivadas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSQL
{
    public abstract class EntidadDB<T> : Consultas
    {
        private Dictionary<string, string> consultas = new Dictionary<string, string>();
        private string tabla;
        private string columnas;
        private string valores;
        private string identificador;
        private string asignacion;

        public EntidadDB(string tabla, string columnas, string valores, string identificador, string asignacion)
        {
            this.tabla = tabla;
            this.columnas = columnas;
            this.valores = valores;
            this.identificador = identificador;
            this.asignacion = asignacion;
            EscribirConsultas();
        }

        /// <summary>
        /// Crea una consulta para Agregar registro y se la pasa a un comando SQL.
        /// Parametriza valores y ejecuta la consulta con el comando creado.
        /// Si esto lanza una excepción, la atrapa y y la lanza con un mensaje.
        /// </summary>
        /// <param name="entidad"></param>
        /// <exception cref="Exception"></exception>
        public void Agregar(T entidad)
        {
            try
            {
                string consulta = consultas["Agregar registro"];

                SqlCommand command = new SqlCommand(consulta, Connection);

                Parametrizar(command, entidad);

                EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo agregar la entidad a la DB.");
            }
        }

        /// <summary>
        /// Crea una consulta para Eliminar registro y se la pasa a un comando SQL.
        /// Verifica si la entidad recibida es un usuario. Si lo es, el identificador será 'dni'.
        /// Parametriza al comando con el valor del identificador y lo ejecuta.
        /// Si esto lanza una excepción, la atrapa y y la lanza con un mensaje.
        /// </summary>
        /// <param name="entidad"></param>
        /// <param name="identificacion"></param>
        /// <exception cref="Exception"></exception>
        public void Eliminar(T entidad, string identificacion)
        {
            try
            {
                string consulta = consultas["Eliminar registro"];

                if (entidad is Usuario)
                    identificador = "dni";

                SqlCommand command = new SqlCommand(consulta, Connection);

                command.Parameters.AddWithValue($"@{identificador}", $"{identificacion}");

                EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo eliminar la entidad de la DB");
            }
        }

        /// <summary>
        /// Crea una consulta para Modificar registro y se la pasa a un comando SQL.
        /// Parametriza valores y ejecuta la consulta con el comando creado.
        /// Si esto lanza una excepción, la atrapa y y la lanza con un mensaje.
        /// </summary>
        /// <param name="entidad"></param>
        /// <exception cref="Exception"></exception>
        public void Modificar(T entidad)
        {
            try
            {
                string consulta = consultas["Modificar registro"];

                SqlCommand command = new SqlCommand(consulta, Connection);

                Parametrizar(command, entidad);

                EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo modificar la entidad en la DB");
            }
        }

        /// <summary>
        /// Crea una consulta para Traer todos los registros y se la pasa a un comando SQL.
        /// Crea una DataTable y le carga el valor que devuelva la ejecución del a consulta.
        /// Recorre cada una de sus filas, y por cada una crea una entidad la cual agrega a una lista.
        /// </summary>
        /// <returns>Retorna la lista de registros creada</returns>
        public List<T> TraerTodosLosRegistros()
        {
            string consulta = consultas["Traer todos los registros"];

            List<T> registros = new List<T>();

            using (var dataTable = EjecutarConsulta(consulta))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    T entidad = CrearEntidadDesdeDataTable(row);
                    registros.Add(entidad);
                }
            }

            return registros;
        }

        /// <summary>
        /// Crea una consulta para Eliminar todos los registros y se la pasa a un comando SQL.
        /// Ejecuta el comando con la consulta.
        /// Si esto lanza una excepción, la atrapa y y la lanza con un mensaje.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void EliminarTodos()
        {
            try
            {
                string consulta = consultas["Eliminar todos los registros"];

                SqlCommand command = new SqlCommand(consulta, Connection);

                EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudieron eliminar los registros de la DB");
            }
        }

        /// <summary>
        /// Le agrega elementos al diccionario consultas. Las keys son el nombre de la
        /// acción a realizar por la consulta, y los values son el código SQL que debe ejecutar.
        /// Reutiliza los valores de las tablas, columnas, identificadores y asignaciones.
        /// </summary>
        private void EscribirConsultas()
        {
            consultas.Add("Agregar registro",
                $"INSERT INTO {tabla} ({columnas}) VALUES ({valores})");

            consultas.Add("Eliminar registro",
                $"DELETE FROM {tabla} WHERE {identificador} = @{identificador}");

            consultas.Add("Modificar registro",
                $"UPDATE {tabla} SET {asignacion} WHERE {identificador} = @{identificador}");

            consultas.Add("Traer todos los registros",
                $"SELECT * FROM {tabla}");

            consultas.Add("Eliminar todos los registros",
                $"DELETE FROM {tabla} " +
                $"DBCC CHECKIDENT ('productos', RESEED, 1000) " +
                $"DBCC CHECKIDENT ('ventas', RESEED, 1000)");
        }

        /// <summary>
        /// Guarda el tipo de la entidad que recibe para saber con qué clase se está trabajando.
        /// Toma todas las propiedades de esa entidad y las guarda en un array propiedades.
        /// Recorre cada propiedad del array; toma cada columna en base a la propiedad
        /// usando el CustomAttribute para la columna (el nombre que le corresponde a la DB).
        /// Si esta columna no es nula, toma como parámetro su nombre, y como valor, el valor
        /// propio de la entidad en esa propiedad. Después, agrega el parámetro con estos valores.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="entidad"></param>
        private static void Parametrizar(SqlCommand command, T entidad)
        {
            Type tipoEntidad = typeof(T);
            PropertyInfo[] propiedades = tipoEntidad.GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                ColumnAttribute? columna = propiedad.GetCustomAttribute<ColumnAttribute>();

                if (columna is not null)
                {
                    string? parametro = columna.Name;
                    object? valor = propiedad.GetValue(entidad);

                    command.Parameters.AddWithValue(parametro, valor);
                }
            }
        }

        protected abstract T CrearEntidadDesdeDataTable(DataRow row);
    }
}
