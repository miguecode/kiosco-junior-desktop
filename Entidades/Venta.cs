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
        private int cantidadProductos;
        private int cantidadCigarrillos;
        private int cantidadBebidas;
        private int cantidadSnacks;
        private int cantidadGalletitas;
        private int cantidadDulces;
        private int cantidadComidas;
        private int cantidadOtros;
        private static int idActual;

        public int Id { get => id; }
        public string NombreCliente { get => nombreCliente; }
        public float ValorTotal { get => valorTotal; }
        public int CantidadProductos { get => cantidadProductos; }
        public int CantidadCigarrillos { get => cantidadCigarrillos; }
        public int CantidadBebidas { get => cantidadBebidas; }
        public int CantidadSnacks { get => cantidadSnacks; }
        public int CantidadGalletitas { get => cantidadGalletitas; }
        public int CantidadDulces { get => cantidadDulces; }
        public int CantidadComidas { get => cantidadComidas; }
        public int CantidadOtros { get => cantidadOtros; }

        public Venta()
        {
            this.id = 0000;
            this.nombreCliente = String.Empty;
            this.valorTotal = 0;
        }

        public Venta(string nombreCliente, float valorTotal, int cantidadProductos,
            int cantidadCigarrillos, int cantidadBebidas, int cantidadSnacks,
            int cantidadGalletitas, int cantidadDulces, int cantidadComidas, int cantidadOtros)
        {
            id = idActual;
            this.nombreCliente = nombreCliente;
            this.valorTotal = valorTotal;
            this.cantidadProductos = cantidadProductos;
            this.cantidadCigarrillos = cantidadCigarrillos;
            this.cantidadBebidas = cantidadBebidas;
            this.cantidadSnacks = cantidadSnacks ;
            this.cantidadGalletitas = cantidadGalletitas;
            this.cantidadDulces = cantidadDulces;
            this.cantidadComidas = cantidadComidas;
            this.cantidadOtros = cantidadOtros;
            idActual++;
        }

        static Venta()
        {
            idActual = 1000;
        }

        public override string GetParser()
        {
            return $"{Id};{NombreCliente};{ValorTotal};{cantidadProductos};{cantidadCigarrillos};" +
                $"{cantidadBebidas};{cantidadSnacks};{cantidadGalletitas};{cantidadDulces};{cantidadComidas};{cantidadOtros}";
        }

        public override Dato CrearEntidadPorLista(List<string> dato)
        {
            string nombre = dato[1];
            float valor = float.Parse(dato[2]);
            int cantidadProductos = int.Parse(dato[3]);
            int cantidadCigarrillos = int.Parse(dato[4]);
            int cantidadBebidas = int.Parse(dato[5]);
            int cantidadSnacks = int.Parse(dato[6]);
            int cantidadGalletitas = int.Parse(dato[7]);
            int cantidadDulces = int.Parse(dato[8]);
            int cantidadComidas = int.Parse(dato[9]);
            int cantidadOtros = int.Parse(dato[10]);

            Venta ventaCreada = new Venta(nombre, valor, cantidadProductos, cantidadCigarrillos,
                cantidadBebidas, cantidadSnacks, cantidadGalletitas, cantidadDulces, cantidadComidas, cantidadOtros);

            return ventaCreada;
        }
    }
}
