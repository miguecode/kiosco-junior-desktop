using Entidades;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Helper
{
    public class Serializacion<T>
    {
        private string path;

        public Serializacion(string path)
        {
            this.path = path;
        }

        public void SerializarCSV(List<T> objetos)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                PropertyInfo[] propiedades = typeof(T).GetProperties();

                string encabezado = string.Join(",", Array.ConvertAll(propiedades, p => p.Name));

                sw.WriteLine(encabezado);

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
        }

        public List<T> DeserializarCSV()
        {
            List<T> listaDeObjetos = new List<T>();

            using (StreamReader sr = new StreamReader(path))
            {
                string[]? columnas = sr.ReadLine()?.Split(',');
                CrearYAgregarEntidad(listaDeObjetos, sr, columnas);
            }

            return listaDeObjetos;
        }

        private void CrearYAgregarEntidad(List<T> objetos, StreamReader sr, string[]? columnas)
        {
            string? linea;

            while ((linea = sr.ReadLine()) != null)
            {
                string[] valores = linea.Split(',');

                T objeto = Activator.CreateInstance<T>();

                for (int i = 0; i < columnas?.Length; i++)
                {
                    PropertyInfo? propiedad = typeof(T).GetProperty(columnas[i]);

                    if (propiedad != null && propiedad.CanWrite)
                    {
                        if (!propiedad.PropertyType.IsEnum)
                        {
                            var valor = Convert.ChangeType(valores[i], propiedad.PropertyType);
                            propiedad.SetValue(objeto, valor);
                        }
                        else
                        {
                            Type enumerado = propiedad.PropertyType;
                            //var enumerado = Nullable.GetUnderlyingType(propiedad.PropertyType) ?? propiedad.PropertyType;
                            var valor = Enum.Parse(enumerado, valores[i]);
                            propiedad.SetValue(objeto, valor);
                        }
                    }
                }

                objetos.Add(objeto);
            }
        }

        



    }
}
