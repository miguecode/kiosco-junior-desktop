using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string nombreUsuario;
        private string contrasenia;
        private ERol rol;

        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("apellido")]
        public string Apellido { get => apellido; set => apellido = value; }
        [Column("dni")]
        public int Dni { get => dni; set => dni = value; }
        [Column("nombre_usuario")]
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        [Column("contrasenia")]
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string NombreCompleto { get => $"{Nombre} {Apellido}"; }
        [Column("rol")]
        public ERol Rol { get => rol; set => rol = value; }

        public Usuario()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            dni = 00000000;
            nombreUsuario = string.Empty;
            contrasenia = string.Empty;
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
