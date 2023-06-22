using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
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
        private int idDB;

        [Column("id")]
        public int IdDB { get => idDB; set => idDB = value; }
        [Column("nombre_cliente")]
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        [Column("valor_total")]
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
        [Column("cantidad_productos")]
        public int CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }
        [Column("cantidad_cigarrillos")]
        public int CantidadCigarrillos { get => cantidadCigarrillos; set => cantidadCigarrillos = value; }
        [Column("cantidad_bebidas")]
        public int CantidadBebidas { get => cantidadBebidas; set => cantidadBebidas = value; }
        [Column("cantidad_snacks")]
        public int CantidadSnacks { get => cantidadSnacks; set => cantidadSnacks = value; }
        [Column("cantidad_galletitas")]
        public int CantidadGalletitas { get => cantidadGalletitas; set => cantidadGalletitas = value; }
        [Column("cantidad_dulces")]
        public int CantidadDulces { get => cantidadDulces; set => cantidadDulces = value; }
        [Column("cantidad_comidas")]
        public int CantidadComidas { get => cantidadComidas; set => cantidadComidas = value; }
        [Column("cantidad_otros")]
        public int CantidadOtros { get => cantidadOtros; set => cantidadOtros = value; }

        public Venta()
        {
            this.nombreCliente = String.Empty;
            this.valorTotal = 0;
            this.idDB = 0000;
        }

        public Venta(string nombreCliente, float valorTotal, int cantidadProductos,
            int cantidadCigarrillos, int cantidadBebidas, int cantidadSnacks,
            int cantidadGalletitas, int cantidadDulces, int cantidadComidas, int cantidadOtros)
        {
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

        public Venta CrearEntidadPorBaseDeDatos(DataRow row)
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
