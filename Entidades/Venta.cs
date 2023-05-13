using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta : Dato
    {
        private int id;
        private string nombreCliente;
        //private List<Producto> listaProductos;
        private float valorTotal;
        //private string factura;
        private static int idActual;

        public int Id { get => id; set => id = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        //public List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
        //public int CantidadProductos { get => listaProductos.Count; }
        //public string FacturaProductos { get => factura; set => factura = value; }

        public Venta()
        {
            this.id = 0000;
            this.nombreCliente = "NO CARGADO";
            //this.factura = "NO CARGADO";
            //this.listaProductos = new List<Producto>();
            this.valorTotal = 0;
        }
        /*public Venta(string nombreCliente, List<Producto> listaProductos, float valorTotal)
        {
            this.id = idActual;
            this.nombreCliente = nombreCliente;
            this.listaProductos = listaProductos;
            this.valorTotal = valorTotal;
            idActual++;
        }*/

        public Venta(string nombreCliente, float valorTotal)
        {
            this.id = idActual;
            this.nombreCliente = nombreCliente;
            //this.factura = factura;
            this.valorTotal = valorTotal;
            idActual++;
        }

        static Venta()
        {
            idActual = 1000;
        }

        public string EscribirLista(List<Producto> listaProductos)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto producto in listaProductos)
            {
                sb.Append($"{producto.ToString()},");
            }

            return sb.ToString();
        }

        public override string GetParser()
        {
            return $"{Id};{NombreCliente};{ValorTotal}";
        }

        public override Dato CrearEntidadPorLista(List<string> dato)
        {
            //int id = int.Parse(dato[0]);
            string nombre = dato[1];
            float valor = float.Parse(dato[2]);
            //string factura = dato[3];

            Venta ventaCreada = new Venta(nombre, valor);

            //Venta ventaCreada = new Venta(nombre, factura, valor);

            return ventaCreada;
        }

    }
}
