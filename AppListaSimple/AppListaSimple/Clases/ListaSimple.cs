using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppListaSimple.Interfaces;

namespace AppListaSimple.Clases
{
    internal class ListaSimple<T> : IListaSimple<T>
    {
        private NodoSimple<T> Inicio;
        private int cantidad;

        public ListaSimple()
        {
            this.Inicio = null;
            this.cantidad = 0;
        }
        public int BuscarElemento(T elemento)
        {
            int indice = -1;
            NodoSimple<T> temp = this.Inicio;
            for(int i = 0; i < cantidad; i++)
            {
                if (elemento.Equals(temp.Valor))
                {
                    indice = i;
                    break;
                } else
                {
                    temp = temp.Siguiente;
                }
            }
            return indice;
        }

        public T BuscarPorIndice(int indice)
        {
            NodoSimple<T> temp = this.Inicio;
            if(EsVacio() || indice < 0 || indice > cantidad - 1)
            {
                throw new Exception("Fuera de rango");
            } else
            {
                for (int i = 0; i < indice; i++)
                {
                    temp = temp.Siguiente;
                }
            }
            return temp.Valor;
        }

        public int Cantidad()
        {
            return this.cantidad;
        }

        public T EliminarElemento(int indice)
        {
            T valorEliminado;
            if (EsVacio() || indice < 0)
            {
                throw new Exception("Lista vacia o Posicion invalida");
            }
            if (indice == 0)
            {
                valorEliminado = this.Inicio.Valor;
                this.Inicio = this.Inicio.Siguiente;
                cantidad--; //decrementa la longitud de la lista
                return valorEliminado;
            }

            NodoSimple<T> actual = this.Inicio;
            for (int i = 0; i < indice - 1; i++)
            {
                if (actual.Siguiente == null)
                {
                    throw new Exception("Posicion fuera de rango");
                }
                actual = actual.Siguiente;
            }
            if (actual.Siguiente == null)
            {
                throw new Exception("Posicion fuera de rango");
            }
            valorEliminado = actual.Siguiente.Valor;
            actual.Siguiente = actual.Siguiente.Siguiente;
            cantidad--;
            return valorEliminado;
        }

        public bool EsVacio()
        {
            return this.Inicio == null;
        }

        public void InsertarElementoFinal(T elemento)
        {
            NodoSimple<T> NuevoNodo = new NodoSimple<T>(elemento);
            if (EsVacio())
            {
                this.Inicio = NuevoNodo;
            } else
            {
                NodoSimple<T> temp = this.Inicio;
                while(temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = NuevoNodo;
            }
            this.cantidad++;
        }

        public void InsertarElementoInicio(T elemento)
        {
            NodoSimple<T> NuevoNodo = new NodoSimple<T>(elemento);
            if(EsVacio())
            {
                this.Inicio = NuevoNodo;
            } else
            {
                NuevoNodo.Siguiente = this.Inicio;
                this.Inicio = NuevoNodo;
            }
            this.cantidad++;
        }

        public string MostrarElementos()
        {
            string resultado = "";
            NodoSimple<T> temp = this.Inicio;
            if(!EsVacio())
            {
                while(temp != null)
                {
                    resultado += $"[{temp.Valor}]-->";
                    temp = temp.Siguiente;
                }
            }
            return resultado + "null";
        }

        public void ReemplazarValor(int indice, T elemento)
        {
            if (EsVacio() || indice < 0 || indice > cantidad - 1)
            {
                throw new Exception("Indice fuera de rango");
            }
            else
            {
                NodoSimple<T> Temp = this.Inicio;
                for (int i = 0; i < indice; i++)
                {
                    Temp = Temp.Siguiente;
                }
                Temp.Valor = elemento;
            }
        }

        public void VaciarLista()
        {
            this.Inicio = null;
        }
    }
}
