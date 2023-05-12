using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Parser
    {
        public abstract string GetParser();

        public abstract Parser CrearEntidadPorLista(List<string> listaDatos);
    }
}
