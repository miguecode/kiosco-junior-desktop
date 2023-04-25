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

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string NombreCompleto { get => $"{Nombre} {Apellido}"; }

        public Usuario(string nombre, string apellido, int dni, string nombreUsuario, string contrasenia)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }
    }
}
