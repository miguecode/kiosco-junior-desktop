using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        private int id;
        private string nombreCliente;
        private List<Producto> listaProductos;
        private float valorTotal;
        private static int idActual;

        public int Id { get => id; set => id = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
        public int CantidadProductos { get => listaProductos.Count; }

        public Venta()
        {
            this.id = 0000;
            this.nombreCliente = "NO CARGADO";
            this.listaProductos = new List<Producto>();
            this.valorTotal = 0;
        }

        public Venta(string nombreCliente, List<Producto> listaProductos, float valorTotal)
        {
            this.id = idActual;
            this.nombreCliente = nombreCliente;
            this.listaProductos = listaProductos;
            this.valorTotal = valorTotal;
            idActual++;
        }

        static Venta()
        {
            idActual = 1000;
        }
    }
}
