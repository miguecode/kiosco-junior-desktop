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
        public int Agregar(T objeto);
        public int Modificar(T objeto);
        public int Eliminar(T identificacion);
        public List<T> TraerTodosLosRegistros();
        public List<T> TraerUnRegistro(string id);
        public int EliminarTodos();
    }
}
