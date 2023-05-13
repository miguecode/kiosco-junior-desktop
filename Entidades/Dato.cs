using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Dato
    {
        public abstract string GetParser();

        public abstract Dato CrearEntidadPorLista(List<string> listaDatos);




    }
}
