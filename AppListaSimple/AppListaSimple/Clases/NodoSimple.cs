using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple.Clases
{
    internal class NodoSimple<T>
    {
        public T Valor { get; set; }
        public NodoSimple<T> Siguiente;

        public NodoSimple(T valor)
        {
            this.Valor = valor;
            this.Siguiente = null;
        }
    }
}
