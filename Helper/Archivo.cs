using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Archivo
    {
        public Archivo()
        {
        }

        public static void Auxiliares()
        {
            Console.WriteLine("Es Windows: {0}", OperatingSystem.IsWindows());
            Console.WriteLine("Es Linux: {0}", OperatingSystem.IsLinux());
            Console.WriteLine("Es MacOS: {0}", OperatingSystem.IsMacOS());
            Console.WriteLine("Es Android: {0}", OperatingSystem.IsAndroid());
            Console.WriteLine("Es IOS: {0}", OperatingSystem.IsIOS());
        }

        public static void EscribirEnArchivo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Estoy escribiendo mi primer archivo.");
            sb.AppendLine("En este caso uso un StringBuilder.");
            sb.AppendLine("Y lo voy a crear con File.WriteAllText");

            //File.WriteAllText("./mi_archivo.txt", sb.ToString());

            string[] texto =
            {
                "Estoy escribiendo mi primer archivo.",
                "En este caso uso un array de strings.",
                "Y lo voy a crear con File.WriteAllLines"
            };

            //File.WriteAllLines("./mi_archivo.txt", texto);
        }

        public static void Stream()
        {
            List<string> listaDeTexto = new List<string>();

            listaDeTexto.Add("Estoy escribiendo mi primer archivo.");
            listaDeTexto.Add("En este caso uso un StringBuilder.");
            listaDeTexto.Add("Y lo voy a crear con File.WriteAllText");

            StreamWriter streamWriter = new StreamWriter("mi_archivo_stream.txt", true);
            //Ese 'true' hace que funcione como un Append. Es decir, no va a sobreescribir nada.

            foreach (var linea in listaDeTexto)
            {
                //if()
                //{
                    streamWriter.WriteLine(linea);
                //}

            }

            streamWriter.Close(); //lo cierra
            streamWriter.Dispose(); //lo destruye
        }

    }
}
