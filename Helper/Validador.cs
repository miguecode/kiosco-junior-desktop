using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class Validador
    {
        static Validador()
        {

        }

        public static void ValidarDatosEntidad()
        {
            //Creo que este método no debería ir aca o quiza si..?
        }

        public static bool ValidarStringConLetraSinDigitoYRango(string cadena, int minimo, int maximo)
        {
            if (!ValidarStringRango(cadena, minimo, maximo))
                return false;

            if (!ValidarStringConLetraGuionYEspacio(cadena))
                return false;

            if (!ValidarStringSinEspacioOGuionSeguido(cadena))
                return false;

            return true;
        }

        public static bool ValidarStringConLetraDigitoYRango(string cadena, int minimo, int maximo)
        {
            if (!ValidarStringRango(cadena, minimo, maximo))
                return false;

            if (!ValidarStringLetraODigito(cadena))
                return false;

            return true;
        }

        public static bool ValidarStringRango(string cadena, int minimo, int maximo)
        {
            return (!string.IsNullOrEmpty(cadena)) && cadena.Length > minimo && cadena.Length < maximo;
        }

        public static bool ValidarCantidadRango(float cantidad, float minimo, float maximo)
        {
            return cantidad > minimo && cantidad < maximo;
        }

        public static bool ValidarItemCombobox(Object itemSeleccionado)
        {
            return itemSeleccionado != null;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //Métodos encapsulados (Solo se usan en esta clase)
        private static bool ValidarStringConLetraGuionYEspacio(string cadena)
        {
            foreach (char caracter in cadena) 
            {
                if (!char.IsLetter(caracter) && caracter != ' ' && caracter != '-')
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ValidarStringSinEspacioOGuionSeguido(string cadena)
        {
            for (int i = 0; i < cadena.Length - 1; i++)
            {
                if ((cadena[i] == ' ' && cadena[i + 1] == ' ') || (cadena[i] == '-' && cadena[i + 1] == '-'))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ValidarStringLetraODigito(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!char.IsLetterOrDigit(caracter))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
