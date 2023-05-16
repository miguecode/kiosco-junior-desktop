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
        private float valorTotal;
        private static int idActual;

        public int Id { get => id; set => id = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }

        public Venta()
        {
            this.id = 0000;
            this.nombreCliente = String.Empty;
            this.valorTotal = 0;
        }

        public Venta(string nombreCliente, float valorTotal)
        {
            id = idActual;
            this.nombreCliente = nombreCliente;
            this.valorTotal = valorTotal;
            idActual++;
        }

        static Venta()
        {
            idActual = 1000;
        }

        public override string GetParser()
        {
            return $"{Id};{NombreCliente};{ValorTotal}";
        }

        public override Dato CrearEntidadPorLista(List<string> dato)
        {
            string nombre = dato[1];
            float valor = float.Parse(dato[2]);

            Venta ventaCreada = new Venta(nombre, valor);

            return ventaCreada;
        }
    }
}
