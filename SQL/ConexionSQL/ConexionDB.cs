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
    public abstract class ConexionDB
    {
        private SqlConnection? _connection; //Lo usamos para conectarnos o desconectarnos a la DB
        //private static SqlCommand _command; //Lo usamos para realizar consultas a la DB
        private string _connectionString;

        public SqlConnection? Connection { get => _connection ; }

        public ConexionDB(string connectionString)
        {
            _connectionString = connectionString;
            //_connection = new SqlConnection(connectionString);
        }

        protected void Abrir()
        {
            _connection = new SqlConnection(_connectionString);

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
