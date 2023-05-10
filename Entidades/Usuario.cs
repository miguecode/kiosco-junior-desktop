using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Parser
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
        public ERol Rol { get => rol; }
        public Usuario()
        {
            nombre = "No cargado";
            apellido = "No cargado";
            dni = 00000000;
            nombreUsuario = "No cargado";
            contrasenia = "No cargada";
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
            return $"{Rol},{NombreUsuario},{Contrasenia},{Dni},{Nombre},{Apellido}";
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
            return u1.NombreUsuario == u2.NombreUsuario;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1.NombreUsuario == u2.NombreUsuario);
        }
    }
}
