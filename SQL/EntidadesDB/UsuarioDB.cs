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
        public UsuarioDB() : base() {}

        public string NombreTabla { get => "usuarios"; }
        public string Identificador { get => "dni"; }
        public string Atributos { get => "nombre, apellido, dni, nombre_usuario, contrasenia, rol"; }

        public int Agregar(Usuario u)
        {
            string consulta = $"INSERT INTO {NombreTabla} {Atributos} VALUES (@nombre, @apellido, @dni, @nombre_usuario, @contrasenia, @rol)";

            SqlCommand command = new SqlCommand(consulta, Connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nombre", u.Nombre);
            command.Parameters.AddWithValue("@apellido", u.Apellido);
            command.Parameters.AddWithValue("@dni", u.Dni);
            command.Parameters.AddWithValue("@nombre_usuario", u.NombreUsuario);
            command.Parameters.AddWithValue("@contrasenia", u.Contrasenia);
            command.Parameters.AddWithValue("@rol", u.Rol);

            int filasAfectadas = EjecutarConsultaNonQuery(command);

            return filasAfectadas;
        }

        public int Eliminar(Usuario identificacion)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> TraerTodosLosRegistros()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string consulta = $"{TodosLosRegistrosDe} {NombreTabla}";

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
            string consulta = $"{TodosLosRegistrosDe} {NombreTabla} WHERE {Identificador} = {dni}";

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
    }
}