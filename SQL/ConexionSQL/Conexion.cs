using System.Data.SqlClient;

namespace ConexionSQL
{
    public static class Conexion
    {
        private static SqlConnection _connection; //Lo usamos para conectarnos o desconectarnos a la DB
        private static SqlCommand _command; //Lo usamos para realizar consultas a la DB
        private static string _connectionString; //Es el string que le pasamos al constructor de la conexion

        static Conexion()
        {
            //Especifico el string de conexion
            _connectionString = "Server=.;Database=UTN_DB;Trusted_Connection=True;";

            //Instancio la conexion
            _connection = new SqlConnection(_connectionString);

            //Instancio el comando (cualquiera de estas dos formas)
            _command = new SqlCommand();
            //_command = _connection.CreateCommand();

            //Le paso la conexion al comando
            _command.Connection = _connection;

            //Especifico de que tipo va a ser el comando
            _command.CommandType = System.Data.CommandType.Text;
        }

        public static void Leer() //Leo elementos de una DB
        {
            try
            {
                //Abrimos la DB
                _connection.Open();

                //En el CommandText (string) de nuestro comando, especifico la consulta
                _command.CommandText = "SELECT * FROM usuarios";
                //Esa sentencia que escribimos como string, es un código en lenguaje SQL. Son las Querys
                //que nosotros ejecutamos en el SQL Server Management Studio.

                //Ahora ejecutamos el comando. Hay distintas formas:
                //_command.ExecuteNonQuery(); //Ejecuta la Query y nos devuelve un entero que serán las filas afectadas

                //_command.ExecuteReader(); //Devuelve un SqlDataReader. Similar al de los archivos

                //Ese ExecuteReader lo vamos a usar con la directiva using. Esta directiva lo que hace es liberar recursos,
                //es decir, cuando finalice, va a hacerle Dispose a la variable 'dataReader' que creamos.
                using (SqlDataReader dataReader = _command.ExecuteReader())
                {
                    while(dataReader.Read()) //Mientras pueda leer filas (líneas)...
                    {
                        Console.WriteLine(dataReader["nombre"]); //Muestro el valor de la columna 'nombre'
                    }
                }
            }   
            catch
            {
                throw;
            }
            finally //El finally se ejecuta a pesar de haberse interrumpido el programa en una excepción
            {
                //Cerramos la DB
                _connection.Close();
            }
        }







    }
}