using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Usuario
    {
        private Dictionary<Producto, float> carrito;

        public Cliente(string nombre, string apellido, int dni, string nombreUsuario, string contrasenia, ERol rol)                     
                                                                :base(nombre, apellido, dni, nombreUsuario, contrasenia, rol)
        {
            carrito = new Dictionary<Producto, float>();
        }

        public Dictionary<Producto, float> Carrito { get => carrito; set => carrito = value; }

        public override string GetParser()
        {
            return $"CLIENTE,{Rol},{NombreUsuario},{Contrasenia},{Dni},{Nombre},{Apellido}";
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


    }
}
