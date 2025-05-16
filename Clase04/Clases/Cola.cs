using System;
using System.Collections.Generic;
using Clase04.Interfaces;

namespace Clase04.Clases
{
    public class Cola<T> : ICola<T>
    {
        private Queue<T> elementos;
        private int capacidad;

        public Cola(int capacidad)
        {
            this.capacidad = capacidad;
            elementos = new Queue<T>();
        }

        public void Enqueue(T item)
        {
            if (!IsFull())
                elementos.Enqueue(item);
        }

        public T Dequeue()
        {
            return elementos.Dequeue();
        }

        public int size()
        {
            return elementos.Count;
        }

        public bool IsEmpty()
        {
            return elementos.Count == 0;
        }

        public bool IsFull()
        {
            // Si capacidad es 0, la cola es "infinita"
            if (capacidad == 0) return false;
            return elementos.Count >= capacidad;
        }
    }
}