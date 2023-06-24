using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private string marca;
        private string descripcion;
        private float precio;
        private ETipo tipo;
        private int stock;
        private int id;
        private int cantidadEnCarrito;

        public Producto()
        {
            nombre = string.Empty;
            tipo = ETipo.Otros;
            marca = string.Empty;
            descripcion = string.Empty;
            precio = 1;
            stock = 1;
            id = 0000;
            cantidadEnCarrito = 0;
        }

        public Producto(string nombre, ETipo tipo, string marca, string descripcion,
                        float precio, int stock)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.marca = marca;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            id = 0000;
            cantidadEnCarrito = 0;
        }

        public Producto(int id, string nombre, ETipo tipo, string marca, string descripcion,float precio, int stock)
                                 : this(nombre, tipo, marca, descripcion, precio, stock)
        {
            this.id = id;
        }

        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Column("tipo")]
        public ETipo Tipo { get => tipo; set => tipo = value; }
        [Column("marca")]
        public string Marca { get => marca; set => marca = value; }
        [Column("descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        [Column("precio")]
        public float Precio { get => precio; set => precio = value; }
        [Column("stock")]
        public int Stock { get => stock; set => stock = value; }
        public int CantidadEnCarrito { get => cantidadEnCarrito; set => cantidadEnCarrito = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"ID: {Id} NOMBRE: {Nombre} - PRECIO: {Precio}");

            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.Id == p2.Id;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.Id == p2.Id);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || this is null)
                return false;

            return this == (Producto)obj;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}