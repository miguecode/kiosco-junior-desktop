using System;
using System.Collections.Generic;
using System.Linq;
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

        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public int Dni { get => dni; }
        public string NombreUsuario { get => nombreUsuario;}
        public string Contrasenia { get => contrasenia;}
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
    }
}
