using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSQL
{
    public class ConsultasSQL : ConexionDB
    {
        protected static string TodosLosRegistrosDe { get => "SELECT * FROM"; }

        public ConsultasSQL(string connectionString) : base(connectionString) {}
        public ConsultasSQL() : base("Server=.;Database=UTN_DB;Trusted_Connection=True;") {}

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

        protected int EjecutarConsultaNonQuery(SqlCommand command)
        {
            Abrir();

            //SqlCommand command = new SqlCommand(consulta, Connection);
            
            int filasAfectadas = command.ExecuteNonQuery();

            Cerrar();

            return filasAfectadas;
        }
    }
}
