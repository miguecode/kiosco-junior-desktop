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
        private int idDB;
        private int cantidadEnCarrito;

        public Producto()
        {
            this.nombre = String.Empty;
            this.tipo = ETipo.Otros;
            this.marca = String.Empty;
            this.descripcion = String.Empty;
            this.precio = 1;
            this.stock = 1;
            this.idDB = 0000;
            this.cantidadEnCarrito = 0;
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
            this.idDB = 0000;
            this.cantidadEnCarrito = 0;
        }

        public Producto(int idDB, string nombre, ETipo tipo, string marca, string descripcion,float precio, int stock)
                                 : this(nombre, tipo, marca, descripcion, precio, stock)
        {
            this.idDB = idDB;
        }

        [Column("id")]
        public int IdDB { get => idDB; set => idDB = value; }
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

            sb.Append($"ID: {IdDB} NOMBRE: {Nombre} - PRECIO: {Precio}");

            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.IdDB == p2.IdDB;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.IdDB == p2.IdDB);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || this is null)
                return false;

            return this == (Producto)obj;
        }

        public override int GetHashCode()
        {
            return IdDB;
        }
    }
}