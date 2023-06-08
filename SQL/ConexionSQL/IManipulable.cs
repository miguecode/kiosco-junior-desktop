using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSQL
{
    public interface IManipulable<T>
    {
        protected string NombreTabla { get; }
        protected string Identificador { get; }
        protected string Atributos { get; }
        protected string Valores { get; }
        public int Agregar(T objeto);
        public int Modificar(T objeto);
        public int Eliminar(T identificacion);
        protected void EstablecerParametros(SqlCommand command, T objeto);
        public List<T> TraerTodosLosRegistros();
        public List<T> TraerUnRegistro(string id);
    }
}
