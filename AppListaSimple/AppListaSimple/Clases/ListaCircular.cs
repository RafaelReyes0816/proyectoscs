using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using AppListaSimple.Interfaces;

namespace AppListaSimple.Clases
{
    internal class ListaCircular<T> : IListaCircular<T>
    {
        private NodoCircular<T> ultimo;
        public int Cantidad;

        public ListaCircular()
        {
            this.ultimo = null;
            this.Cantidad = 0;
        }
        public void AgregarFinal(T elemento)
        {
            NodoCircular<T> NuevoNodo = new NodoCircular<T>(elemento);
            if(EsVacio())
            {
                this.ultimo = NuevoNodo;
                this.ultimo.Siguiente = this.ultimo;
                this.Cantidad++;
            } else
            {
                NuevoNodo.Siguiente = this.ultimo.Siguiente;
                this.ultimo.Siguiente = NuevoNodo;
                this.ultimo = NuevoNodo;
                this.Cantidad++;
            }
        }

        public void AgregarInicio(T elemento)
        {
            NodoCircular<T> NuevoNodo = new NodoCircular<T>(elemento);
            if(EsVacio())
            {
                this.ultimo = NuevoNodo;
                this.ultimo.Siguiente = this.ultimo;
                this.Cantidad++;
            } else
            {
                NuevoNodo.Siguiente = this.ultimo.Siguiente;
                this.ultimo.Siguiente = NuevoNodo;
                this.Cantidad++;
            }
        }

        public bool EliminarElemento(T elemento)
        {
            throw new NotImplementedException();
        }

        public bool EsVacio()
        {
            return this.ultimo == null;
        }

        public void RecorrerLista()
        {
            if (EsVacio())
            {
                throw new Exception("La lista esta vacia");
            }

            NodoCircular<T> NodoActual = this.ultimo.Siguiente;
            do
            {
                Console.Write($"({NodoActual.Valor})->");
                NodoActual = NodoActual.Siguiente;
            }
            while (NodoActual != ultimo.Siguiente);
            Console.WriteLine();
        }
    }
}
