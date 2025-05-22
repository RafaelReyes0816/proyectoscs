using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple.Clases
{
    internal class NodoCircular<T>
    {
        public T Valor { get; set; }
        public NodoCircular<T> Siguiente;

        public NodoCircular(T valor)
        {
            this.Valor = valor;
            this.Siguiente = this;
        }
    }
}
