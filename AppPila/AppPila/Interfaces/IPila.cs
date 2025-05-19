using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPila.Interfaces
{
    internal interface IPila<T>
    {
        // Agregar elemento a la Pila
        void Push(T elemento);

        // Quitar elemento de la Pila
        T Pop();

        // Retorna elemento tope o cima
        T Peek();

        // Tamano de la Pila
        int Size();

        // La Pila esta vacia
        bool IsEmpty();

        // La Pila esta llena
        bool IsFull();
    }
}
