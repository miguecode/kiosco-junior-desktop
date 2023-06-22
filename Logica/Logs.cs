using Entidades;
using LogicaSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Logs : Consultas
    {
        private DateTime horaYFecha;
        private string? usuario;
        private string? accion;
        private static Action? DelegadoRegistrarAccion;

        public Logs() {}

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

            Eventos.ActualizarSeccionLogs();
        }

        public string GetLogs()
        {
            string consulta = "SELECT * FROM logs";

            StringBuilder sb = new StringBuilder();

            using (var dataTable = EjecutarConsulta(consulta))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime horaYFecha = Convert.ToDateTime(row["hora_y_fecha"]);
                    string usuario = row["usuario"].ToString() ?? "";
                    string accion = row["accion"].ToString() ?? "";

                    sb.AppendLine($"[{horaYFecha}] - Usuario: {usuario} - {accion}");
                }
            }

            return sb.ToString();
        }

        public void VaciarRegistros()
        {
            string consulta = "DELETE FROM logs";

            SqlCommand command = new SqlCommand(consulta, Connection);

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
