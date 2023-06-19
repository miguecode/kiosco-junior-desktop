using ConexionSQL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Logs : ConsultasSQL
    {
        private DateTime horaYFecha;
        private string usuario;
        private string accion;
        private static Action? DelegadoRegistrarAccion;

        public Logs(DateTime horaYFecha, string usuario, string accion)
        {
            this.horaYFecha = horaYFecha;
            this.usuario = usuario;
            this.accion = accion;
            DelegadoRegistrarAccion = RegistrarAccion;
        }

        public static void CrearRegistro(string usuario, string accion)
        {
            _ = new Logs(DateTime.Now, usuario, accion);
            DelegadoRegistrarAccion?.Invoke();
        }

        public void RegistrarAccion()
        {
            string consulta =
                $"INSERT INTO logs (hora_y_fecha, usuario, accion)" +
                $" VALUES (@hora_y_fecha, @usuario, @accion)";

            SqlCommand command = new SqlCommand(consulta, Connection);
            EstablecerParametros(command);

            EjecutarConsultaNonQuery(command);
        }

        private void EstablecerParametros(SqlCommand command)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@hora_y_fecha", horaYFecha);
            command.Parameters.AddWithValue("@usuario", usuario);
            command.Parameters.AddWithValue("@accion", accion);
        }
    }
}
