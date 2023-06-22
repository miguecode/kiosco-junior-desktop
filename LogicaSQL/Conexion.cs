using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSQL
{
    public abstract class Conexion
    {
        private SqlConnection _connection;
        public SqlConnection Connection { get => _connection; }

        public Conexion(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        protected void Abrir()
        {
            if (_connection is not null)
                _connection.Open();
        }

        protected void Cerrar()
        {
            if (_connection is not null)
                _connection.Close();
        }
    }
}