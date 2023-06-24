using Entidades;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Helper
{
    public class Serializacion<T>
    {
        private string pathCSV;
        private string pathJSON;

        public Serializacion(string pathCSV, string pathJSON)
        {
            this.pathCSV = pathCSV;
            this.pathJSON = pathJSON;
        }

        /// <summary>
        /// Recibe una lista de objetos y la escribe en un archivo JSON
        /// </summary>
        /// <param name="objetos"></param>
        public void SerializarJSON(List<T> objetos)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(objetos, opciones);

            if (!string.IsNullOrWhiteSpace(jsonString))
                File.WriteAllText(pathJSON, jsonString);
        }

        /// <summary>
        /// Lee un archivo JSON y lo escribe en una lista de objetos
        /// </summary>
        /// <returns>Retorna la lista de objetos deserializada</returns>
        public List<T> DeserializarJSON()
        {
            string jsonString = File.ReadAllText(pathJSON);

            List<T>? listaDeserializada = JsonSerializer.Deserialize<List<T>>(jsonString);

            if (listaDeserializada is not null && listaDeserializada.Count > 0)
                return listaDeserializada;

            else
                return _ = new List<T>();
        }

        /// <summary>
        /// Recibe una lista de objetos y la escribe en un archivo CSV
        /// </summary>
        /// <param name="objetos"></param>
        public void SerializarCSV(List<T> objetos)
        {
            using (StreamWriter sw = new StreamWriter(pathCSV))
            {
                PropertyInfo[] propiedades = typeof(T).GetProperties();

                EscribirEncabezadoCSV(propiedades, sw);
                EscribirRegistrosCSV(objetos, propiedades, sw);
            }
        }

        /// <summary>
        ///  Lee un archivo CSV y lo escribe en una lista de objetos
        /// </summary>
        /// <returns>Retorna la lista de objetos deserializada</returns>
        public List<T> DeserializarCSV()
        {
            List<T> listaDeserializada = new List<T>();

            using (StreamReader sr = new StreamReader(pathCSV))
            {
                string[]? columnas = sr.ReadLine()?.Split(',');
                AgregarEntidades(listaDeserializada, sr, columnas);
            }

            return listaDeserializada;
        }

        /// <summary>
        /// Escribe una línea que simula ser el encabezado de un archivo CSV.
        /// Está compuesto por los nombres de las propiedades que recibe.
        /// </summary>
        /// <param name="propiedades"></param>
        /// <param name="sw"></param>
        private void EscribirEncabezadoCSV(PropertyInfo[] propiedades, StreamWriter sw)
        {
            string encabezado = string.Join(",", Array.ConvertAll(propiedades, p => p.Name));
            sw.WriteLine(encabezado);
        }

        /// <summary>
        /// Escribe una línea por cada objeto que tiene la lista de objetos.
        /// Cada línea está compuesta por el valor de la propiedad que le corresponde a cada objeto.
        /// Recorre la lista de objetos, de cada objeto recorre las propiedades; obtiene el valor
        /// del objeto en esa propiedad y lo agrega a una lista de valores. Después, las escribe en la línea.
        /// </summary>
        /// <param name="objetos"></param>
        /// <param name="propiedades"></param>
        /// <param name="sw"></param>
        private void EscribirRegistrosCSV(List<T> objetos, PropertyInfo[] propiedades, StreamWriter sw)
        {
            foreach (T objeto in objetos)
            {
                List<string> valores = new List<string>();

                foreach (PropertyInfo propiedad in propiedades)
                {
                    var valor = propiedad.GetValue(objeto)?.ToString() ?? string.Empty;
                    valores.Add(valor);
                }

                sw.WriteLine(string.Join(",", valores));
            }
        }

        /// <summary>
        /// Recorre las líneas del StreamReader, crea la instancia de un objeto,
        /// y le establece los valores de las propiedades. Después, lo agrega a la lista de objetos.
        /// </summary>
        /// <param name="objetos"></param>
        /// <param name="sr"></param>
        /// <param name="columnas"></param>
        private void AgregarEntidades(List<T> objetos, StreamReader sr, string[]? columnas)
        {
            string? linea;

            while ((linea = sr.ReadLine()) is not null)
            {
                T objeto = Activator.CreateInstance<T>();

                string[] valores = linea.Split(',');

                SetearPropiedades(objeto, columnas, valores);

                objetos.Add(objeto);
            }
        }

        /// <summary>
        /// Itera por la cantidad de columnas que recibe. Toma una propiedad por cada columna.
        /// Si esa propiedad no es nula tiene un set, y no es enumerado, se toma su valor
        /// y se lo setea al objeto recibido. Si es enumerado, se hace lo mismo pero con un parseo previo.
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="columnas"></param>
        /// <param name="valores"></param>
        private void SetearPropiedades(T objeto, string[]? columnas, string[] valores)
        {
            for (int i = 0; i < columnas?.Length; i++)
            {
                PropertyInfo? propiedad = typeof(T).GetProperty(columnas[i]);

                if (propiedad is not null && propiedad.CanWrite)
                {
                    if (!propiedad.PropertyType.IsEnum)
                    {
                        var valor = Convert.ChangeType(valores[i], propiedad.PropertyType);
                        propiedad.SetValue(objeto, valor);
                    }else
                    {
                        Type enumerado = propiedad.PropertyType;
                        var valor = Enum.Parse(enumerado, valores[i]);
                        propiedad.SetValue(objeto, valor);
                    }
                }
            }
        }
    }
}
