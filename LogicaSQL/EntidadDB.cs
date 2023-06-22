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
        private string tabla;
        private string columnas;
        private string valores;
        private string identificador;
        private string asignacion;
        private Dictionary<string, string> consultas = new Dictionary<string, string>();

        public EntidadDB(string tabla, string columnas, string valores, string identificador, string asignacion)
        {
            this.tabla = tabla;
            this.columnas = columnas;
            this.valores = valores;
            this.identificador = identificador;
            this.asignacion = asignacion;
            EscribirConsultas();
        }

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
