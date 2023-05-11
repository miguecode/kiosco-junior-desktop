using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : Parser
    {
        private string nombre;
        private string marca;
        private string descripcion;
        private float precio;
        private ETipo tipo;
        private int stock;
        private int id;
        private static int idActual;
        public Producto()
        {
            this.nombre = String.Empty;
            this.tipo = ETipo.Otros;
            this.marca = String.Empty;
            this.descripcion = String.Empty;
            this.precio = 0;
            this.stock = 0;
            this.id = 0000;
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
            this.id = idActual;
            idActual++;
        }
        static Producto()
        {
            idActual = 1000;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Id { get => id; set => id = value; }

        public override string GetParser()
        {
            return $"{Id},{Nombre},{Tipo},{Descripcion},{Marca},{Precio},{Stock}";
        }

        public override Producto CrearEntidadPorLista(List<string> dato)
        {
            int id = int.Parse(dato[0]);
            string nombre = dato[1];
            _ = Enum.TryParse(dato[2], out ETipo tipo);
            string descripcion = dato[3];
            string marca = dato[4];
            float precio = float.Parse(dato[5]);
            int stock = int.Parse(dato[6]);

            Producto productoCreado = new Producto(nombre, tipo, marca, descripcion, precio, stock);

            return productoCreado;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {Nombre}");
            sb.AppendLine($"TIPO: {Tipo.ToString()}");
            sb.AppendLine($"MARCA: {Marca}");
            sb.AppendLine($"PRECIO: {Precio}");
            sb.AppendLine($"STOCK: {Stock}");
            sb.AppendLine($"DESCRIPCIÓN: {Descripcion}");
            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.Id == p2.Id && p1.Nombre == p2.Nombre && p1.Marca == p2.Marca;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.Id == p2.Id && p1.Nombre == p2.Nombre && p1.Marca == p2.Marca);
        }
    }
}
