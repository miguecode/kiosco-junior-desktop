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

        public void SerializarJSON(List<T> objetos)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(objetos, opciones);

            if (!string.IsNullOrWhiteSpace(jsonString))
                File.WriteAllText(pathJSON, jsonString);
        }

        public List<T> DeserializarJSON()
        {
            string jsonString = File.ReadAllText(pathJSON);

            List<T>? listaDeserializada = JsonSerializer.Deserialize<List<T>>(jsonString);

            if (listaDeserializada is not null && listaDeserializada.Count > 0)
                return listaDeserializada;

            else
                return _ = new List<T>();
        }

        public void SerializarCSV(List<T> objetos)
        {
            using (StreamWriter sw = new StreamWriter(pathCSV))
            {
                PropertyInfo[] propiedades = typeof(T).GetProperties();

                EscribirEncabezadoCSV(propiedades, sw);
                EscribirRegistrosCSV(objetos, propiedades, sw);
            }
        }

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

        private void EscribirEncabezadoCSV(PropertyInfo[] propiedades, StreamWriter sw)
        {
            string encabezado = string.Join(",", Array.ConvertAll(propiedades, p => p.Name));
            sw.WriteLine(encabezado);
        }

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

        private void AgregarEntidades(List<T> objetos, StreamReader sr, string[]? columnas)
        {
            string? linea;

            while ((linea = sr.ReadLine()) != null)
            {
                T objeto = Activator.CreateInstance<T>();

                string[] valores = linea.Split(',');

                SetearPropiedades(objeto, columnas, valores);

                objetos.Add(objeto);
            }
        }

        private void SetearPropiedades(T objeto, string[]? columnas, string[] valores)
        {
            for (int i = 0; i < columnas?.Length; i++)
            {
                PropertyInfo? propiedad = typeof(T).GetProperty(columnas[i]);

                if (propiedad != null && propiedad.CanWrite)
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
