using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPila.Clases
{
    internal class Pila<T> : Interfaces.IPila<T>
    {
        private T[] elementos;
        private int tope;
        private int tamano;

        public Pila(int tamano = 10)
        {
            this.tamano = tamano;
            this.tope = -1;
            this.elementos = new T[this.tamano];
        }

        public bool IsEmpty()
        {
            return this.tope == -1;
        }

        public bool IsFull()
        {
            return this.tope == this.tamano - 1;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("La pila esta vacia, no se puede obtener e elemento");
            }
            return this.elementos[this.tope];
        }

        public T Pop()
        {
            if(IsEmpty())
            {
                throw new Exception("La pila esta vacia, no hay nada que eliminar");
            }
            return this.elementos[tope--];
        }

        public void Push(T elemento)
        {
            if(IsFull())
            {
                throw new Exception("La pila esta llena, no se pueden agregar elementos.");
            }
            this.elementos[++tope] = elemento;
        }

        public int Size()
        {
            return this.tope + 1;
        }
    }
}
