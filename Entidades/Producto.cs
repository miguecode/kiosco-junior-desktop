using System;
using System.Collections.Generic;
using System.Linq;
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
        //private tipo
        //private fechaDeVencimiento
        private int stock;
        private int id;
        private static int idActual;

        static Producto()
        {
            idActual = 1000;
        }

        //Constructor al que le paso solo los valores más importantes
        public Producto(string nombre, float precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Marca = "N/A";
            Descripcion = "N/A";
            Id = idActual;
        }
        //Constructor al que le paso todos los valores
        public Producto(string nombre, string marca, string descripcion, float precio, int stock) :this(nombre, precio, stock)
        {
            //Nombre = nombre;
            Marca = marca;
            Descripcion = descripcion;
            //Precio = precio;
            //Stock = stock;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Id { get => id; set => id = value; }
        //public static int Id { get => id; set => id = value; }
    }
}
