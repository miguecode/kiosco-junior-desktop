using ConexionSQL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDB
{
    public class VentaDB : ConsultasSQL, IManipulable<Venta>
    {
        public VentaDB() : base() {}

        public string NombreTabla { get => "ventas"; }
        public string Identificador { get => "id"; }

        public int Agregar(Venta objeto)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(Venta identificacion)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Venta objeto)
        {
            throw new NotImplementedException();
        }

        public List<Venta> TraerTodosLosRegistros()
        {
            List<Venta> listaDeVentas = new List<Venta>();

            using (var dataTable = EjecutarConsulta($"{TodosLosRegistrosDe} {NombreTabla}"))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Venta nuevaVenta = new Venta();
                    nuevaVenta = nuevaVenta.CrearEntidadPorBaseDeDatos(row);

                    listaDeVentas.Add(nuevaVenta);
                }
            }

            return listaDeVentas;
        }

        public List<Venta> TraerUnRegistro(string id)
        {
            List<Venta> listaDeVentas = new List<Venta>();
            string consulta = $"{TodosLosRegistrosDe} {NombreTabla} WHERE {Identificador} = {id}";

            using (var dataTable = EjecutarConsulta(consulta))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Venta nuevaVenta = new Venta();
                    nuevaVenta = nuevaVenta.CrearEntidadPorBaseDeDatos(row);

                    listaDeVentas.Add(nuevaVenta);
                }
            }

            return listaDeVentas;
        }
    }
}
