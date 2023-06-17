using ConexionSQL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDB
{
    public class UsuarioDB : ConsultasSQL, IManipulable<Usuario>
    {
        Dictionary<string, string> consultas = new Dictionary<string, string>();

        public UsuarioDB() : base() { EscribirConsultas(); }

        public int Agregar(Usuario usuario)
        {
            try
            {
                string consulta = consultas["Agregar usuario"];

                SqlCommand command = new SqlCommand(consulta, Connection);

                EstablecerParametros(command, usuario);

                return EjecutarConsultaNonQuery(command);
            }
            catch(Exception)
            {
                throw new Exception("No se pudo agregar el usuario a la DB");
            }
        }

        public int Eliminar(Usuario usuario)
        {
            try
            {
                string consulta = consultas["Eliminar usuario"];

                SqlCommand command = new SqlCommand(consulta, Connection);
                command.Parameters.AddWithValue("@dni", usuario.Dni);

                return EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo eliminar el usuario de la DB");
            }
        }

        public int Modificar(Usuario usuario)
        {
            try
            {
                string consulta = consultas["Modificar usuario"];

                SqlCommand command = new SqlCommand(consulta, Connection);

                EstablecerParametros(command, usuario);

                return EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudo modificar el usuario en la DB");
            }
        }

        public List<Usuario> TraerTodosLosRegistros()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string consulta = consultas["Traer todos los usuarios"];

            using (var dataTable = EjecutarConsulta(consulta))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Usuario nuevoUsuario = new Usuario();
                    nuevoUsuario = nuevoUsuario.CrearEntidadPorBaseDeDatos(row);

                    listaUsuarios.Add(nuevoUsuario);
                }
            }

            return listaUsuarios;
        }

        public List<Usuario> TraerUnRegistro(string dni)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string consulta = $"SELECT * FROM usuarios WHERE dni = {dni}";

            using (var dataTable = EjecutarConsulta(consulta))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Usuario nuevoUsuario = new Usuario();
                    nuevoUsuario = nuevoUsuario.CrearEntidadPorBaseDeDatos(row);

                    listaUsuarios.Add(nuevoUsuario);
                }
            }

            return listaUsuarios;
        }

        public int EliminarTodos()
        {
            try
            {
                string consulta = consultas["Eliminar todos los usuarios"];

                SqlCommand command = new SqlCommand(consulta, Connection);

                return EjecutarConsultaNonQuery(command);
            }
            catch (Exception)
            {
                throw new Exception("No se pudieron eliminar los usuarios de la DB");
            }
        }

        private void EscribirConsultas()
        {
            consultas.Add("Agregar usuario",
                "INSERT INTO usuarios (nombre, apellido, dni, nombre_usuario, contrasenia, rol )" +
                "VALUES (@nombre, @apellido, @dni, @nombre_usuario, @contrasenia, @rol)");

            consultas.Add("Eliminar usuario",
                "DELETE FROM usuarios WHERE dni = @dni");

            consultas.Add("Modificar usuario",
                "UPDATE usuarios SET nombre = @nombre, apellido = @apellido, dni = @dni," +
                "nombre_usuario = @nombre_usuario, contrasenia = @contrasenia, rol = @rol " +
                "WHERE dni = @dni");

            consultas.Add("Eliminar todos los usuarios", "DELETE FROM usuarios");

            consultas.Add("Traer todos los usuarios", "SELECT * FROM usuarios");
            //consultas.Add("Traer usuario que coincida", "");
        }

        private void EstablecerParametros(SqlCommand command, Usuario u)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nombre", u.Nombre);
            command.Parameters.AddWithValue("@apellido", u.Apellido);
            command.Parameters.AddWithValue("@dni", u.Dni);
            command.Parameters.AddWithValue("@nombre_usuario", u.NombreUsuario);
            command.Parameters.AddWithValue("@contrasenia", u.Contrasenia);
            command.Parameters.AddWithValue("@rol", u.Rol);
        }
    }
}