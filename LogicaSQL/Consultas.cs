using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSQL
{
    public class Consultas : Conexion
    {
        public Consultas(string connectionString) : base(connectionString) { }
        public Consultas() : base("Server=.;Database=UTN_DB;Trusted_Connection=True;") { }

        protected DataTable EjecutarConsulta(string consulta)
        {
            Abrir();

            SqlCommand command = new SqlCommand(consulta, Connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            Cerrar();

            return dataTable;
        }

        protected void EjecutarConsultaNonQuery(SqlCommand command)
        {
            Abrir();

            command.ExecuteNonQuery();

            Cerrar();
        }
    }
}
