using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : Dato
    {
        private string nombre;
        private string marca;
        private string descripcion;
        private float precio;
        private ETipo tipo;
        private int stock;
        //private int id;
        private int idDB;
        //private static int idActual;
        private int cantidadEnCarrito;

        public Producto()
        {
            this.nombre = String.Empty;
            this.tipo = ETipo.Otros;
            this.marca = String.Empty;
            this.descripcion = String.Empty;
            this.precio = 1;
            this.stock = 1;
            //this.id = 0000;
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
            //this.id = idActual;
            this.idDB = 0000;
            //idActual++;
            this.cantidadEnCarrito = 0;
        }

        public Producto(int idDB, string nombre, ETipo tipo, string marca, string descripcion,float precio, int stock)
                                 : this(nombre, tipo, marca, descripcion, precio, stock)
        {
            this.idDB = idDB;
        }

        /*static Producto()
        {
            idActual = 1000;
        }*/

        public string Nombre { get => nombre; set => nombre = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        //public int Id { get => id; }
        public int IdDB { get => idDB; }
        public int CantidadEnCarrito { get => cantidadEnCarrito; set => cantidadEnCarrito = value; }

        public override string GetParser()
        {
            return $"{IdDB};{Nombre};{Tipo};{Descripcion};{Marca};{Precio};{Stock}";
        }

        public override Producto CrearEntidadPorLista(List<string> dato)
        {
            string nombre = dato[1];
            _ = Enum.TryParse(dato[2], out ETipo tipo);
            string descripcion = dato[3];
            string marca = dato[4];
            float precio = float.Parse(dato[5]);
            int stock = int.Parse(dato[6]);

            Producto productoCreado = new Producto(nombre, tipo, marca, descripcion, precio, stock);

            return productoCreado;
        }

        public override Producto CrearEntidadPorBaseDeDatos(DataRow row)
        {
            int id = Convert.ToInt32(row["id"].ToString());
            string nombre = row["nombre"].ToString() ?? "";
            string marca = row["marca"].ToString() ?? "";
            string descripcion = row["descripcion"].ToString() ?? "";
            float precio = Convert.ToSingle(row["precio"].ToString());
            _ = Enum.TryParse(row["tipo"].ToString() ?? "", out ETipo tipo);
            int stock = Convert.ToInt32(row["stock"].ToString());

            Producto productoCreado = new Producto(id, nombre, tipo, marca, descripcion, precio, stock);

            return productoCreado;
        }

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