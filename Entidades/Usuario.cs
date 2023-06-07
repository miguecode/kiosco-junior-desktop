using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Dato
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string nombreUsuario;
        private string contrasenia;
        private ERol rol;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string NombreCompleto { get => $"{Nombre} {Apellido}"; }
        public ERol Rol { get => rol; set => rol = value; }

        public Usuario()
        {
            nombre = String.Empty;
            apellido = String.Empty;
            dni = 00000000;
            nombreUsuario = String.Empty;
            contrasenia = String.Empty;
            rol = ERol.Cliente;
        }
        
        public Usuario(string nombre, string apellido, int dni, string nombreUsuario, string contrasenia, ERol rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.rol = rol;
        }

        public override string GetParser()
        {
            return $"{Rol};{NombreUsuario};{Contrasenia};{Dni};{Nombre};{Apellido}";
        }

        public override Usuario CrearEntidadPorLista(List<string> dato)
        {
            _ = Enum.TryParse(dato[0], out ERol rol);
            string nombreUsuario = dato[1];
            string contrasenia = dato[2];
            int dni = int.Parse(dato[3]);
            string nombre = dato[4];
            string apellido = dato[5];

            Usuario usuarioCreado = new Usuario(nombre, apellido, dni, nombreUsuario, contrasenia, rol);

            return usuarioCreado;
        }

        public override Usuario CrearEntidadPorBaseDeDatos(DataRow row)
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {Nombre}");
            sb.AppendLine($"APELLIDO: {Apellido}");
            sb.AppendLine($"DNI: {Dni}");
            sb.AppendLine($"NOMBRE USUARIO: {NombreUsuario}");
            sb.AppendLine($"CONTRASEÑA: {Contrasenia}");
            sb.AppendLine($"ROL: {Rol.ToString()}");

            return sb.ToString();
        }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1.NombreUsuario == u2.NombreUsuario || u1.Dni == u2.Dni;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1.NombreUsuario == u2.NombreUsuario || u1.Dni == u2.Dni);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || this is null)
                return false;

            return this == (Usuario)obj;
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
