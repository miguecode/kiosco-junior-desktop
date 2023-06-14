using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        private int idDB;

        //public int Id { get => id; }
        public int IdDB { get => idDB; set => idDB = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
        public int CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }
        public int CantidadCigarrillos { get => cantidadCigarrillos; set => cantidadCigarrillos = value; }
        public int CantidadBebidas { get => cantidadBebidas; set => cantidadBebidas = value; }
        public int CantidadSnacks { get => cantidadSnacks; set => cantidadSnacks = value; }
        public int CantidadGalletitas { get => cantidadGalletitas; set => cantidadGalletitas = value; }
        public int CantidadDulces { get => cantidadDulces; set => cantidadDulces = value; }
        public int CantidadComidas { get => cantidadComidas; set => cantidadComidas = value; }
        public int CantidadOtros { get => cantidadOtros; set => cantidadOtros = value; }


        public Venta()
        {
            this.id = 0000;
            this.nombreCliente = String.Empty;
            this.valorTotal = 0;
            this.idDB = 0000;
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
            this.idDB = 0000;
        }

        public Venta(int idDB, string nombreCliente, float valorTotal, int cantidadProductos,
            int cantidadCigarrillos, int cantidadBebidas, int cantidadSnacks,
            int cantidadGalletitas, int cantidadDulces, int cantidadComidas, int cantidadOtros) : this(nombreCliente,
                valorTotal, cantidadProductos, cantidadCigarrillos, cantidadBebidas ,cantidadSnacks,
                cantidadGalletitas, cantidadDulces, cantidadComidas, cantidadOtros)
        {
            this.idDB = idDB;
        }

        static Venta()
        {
            idActual = 1000;
        }

        public override string GetParser()
        {
            return $"{IdDB};{NombreCliente};{ValorTotal};{cantidadProductos};{cantidadCigarrillos};" +
                $"{cantidadBebidas};{cantidadSnacks};{cantidadGalletitas};{cantidadDulces};{cantidadComidas};{cantidadOtros}";
        }

        public override Dato CrearEntidadPorLista(List<string> dato)
        {
            string nombreCliente = dato[1];
            float valor = float.Parse(dato[2]);
            int cantidadProductos = int.Parse(dato[3]);
            int cantidadCigarrillos = int.Parse(dato[4]);
            int cantidadBebidas = int.Parse(dato[5]);
            int cantidadSnacks = int.Parse(dato[6]);
            int cantidadGalletitas = int.Parse(dato[7]);
            int cantidadDulces = int.Parse(dato[8]);
            int cantidadComidas = int.Parse(dato[9]);
            int cantidadOtros = int.Parse(dato[10]);

            Venta ventaCreada = new Venta(nombreCliente, valor, cantidadProductos, cantidadCigarrillos,
                cantidadBebidas, cantidadSnacks, cantidadGalletitas, cantidadDulces, cantidadComidas, cantidadOtros);

            return ventaCreada;
        }

        public override Venta CrearEntidadPorBaseDeDatos(DataRow row)
        {
            int id = Convert.ToInt32(row["id"].ToString());
            string nombreCliente = row["nombre_cliente"].ToString() ?? "";
            float valor = Convert.ToSingle(row["valor_total"].ToString());
            int cantidadProductos = Convert.ToInt32(row["cantidad_productos"].ToString());
            int cantidadCigarrillos = Convert.ToInt32(row["cantidad_cigarrillos"].ToString());
            int cantidadBebidas = Convert.ToInt32(row["cantidad_bebidas"].ToString());
            int cantidadSnacks = Convert.ToInt32(row["cantidad_snacks"].ToString());
            int cantidadGalletitas = Convert.ToInt32(row["cantidad_galletitas"].ToString());
            int cantidadDulces = Convert.ToInt32(row["cantidad_dulces"].ToString());
            int cantidadComidas = Convert.ToInt32(row["cantidad_comidas"].ToString());
            int cantidadOtros = Convert.ToInt32(row["cantidad_otros"].ToString());

            Venta ventaCreada = new Venta(id, nombreCliente, valor, cantidadProductos, cantidadCigarrillos,
                            cantidadBebidas, cantidadSnacks, cantidadGalletitas, cantidadDulces, cantidadComidas, cantidadOtros);

            return ventaCreada;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {IdDB}");
            sb.AppendLine($"COMPRADOR: {NombreCliente}");
            sb.AppendLine($"VALOR TOTAL: {ValorTotal}");
            sb.AppendLine($"CANTIDAD PRODUCTOS: {CantidadProductos}");

            return sb.ToString();
        }
    }
}
