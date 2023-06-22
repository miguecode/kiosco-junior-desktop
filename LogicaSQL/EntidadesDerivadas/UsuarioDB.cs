using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSQL.EntidadesDerivadas
{
    public class UsuarioDB : EntidadDB<Usuario>
    {
        private const string auxTabla = "usuarios";

        private const string auxColumnas = "nombre, apellido, dni, nombre_usuario, contrasenia, rol";

        private const string auxValores = "@nombre, @apellido, @dni, @nombre_usuario, @contrasenia, @rol";

        private const string auxId = "dni"; 
        
        private const string auxAsignacion = "nombre = @nombre, apellido = @apellido, dni = @dni," +
                " nombre_usuario = @nombre_usuario, contrasenia = @contrasenia, rol = @rol";

        public UsuarioDB() : base(auxTabla, auxColumnas, auxValores, auxId, auxAsignacion) { }

        protected override Usuario CrearEntidadDesdeDataTable(DataRow row)
        {
            string nombre = row["nombre"].ToString() ?? "";
            string apellido = row["apellido"].ToString() ?? "";
            int dni = Convert.ToInt32(row["dni"].ToString());
            string nombreUsuario = row["nombre_usuario"].ToString() ?? "";
            string contrasenia = row["contrasenia"].ToString() ?? "";
            _ = Enum.TryParse(row["rol"].ToString() ?? "", out ERol rol);

            Usuario usuarioCreado = new Usuario(nombre, apellido, dni, nombreUsuario, contrasenia, rol);

            return usuarioCreado;
        }
    }
}
