using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple.Clases
{
    public class Pila<T>
    {
        private ListaSimple<T> elementos;
        private int tope;
        private int capacidad;

        public Pila(int capacidad = 25)
        {
            this.capacidad = capacidad;
            elementos = new ListaSimple<T>();
            tope = -1;
        }

        public bool EstaVacia()
        {
            return tope == -1;
        }


        public bool EstaLlena()
        {
            return tope == capacidad - 1;
        }

        public void Push(T elemento)
        {
            if (EstaLlena())
            {
                throw new Exception("la pila esta llena, no se puede agregar mas elementos");

            }
            elementos.InsertarElementoFinal(elemento);
            this.tope++;
        }

        public T pop()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("la pila esta vacia, no se puede sacar mas elementos");
            }
            T valor = elementos.EliminarElemento(tope);
            this.tope--;
            return valor;
        }

        public T peek()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("la pila esta vacia, no se puede sacar mas elementos");
            }
            return elementos.BuscarPorIndice(tope);
        }

        public int Tamano()
        {
            return tope + 1;
        }
    }
}
