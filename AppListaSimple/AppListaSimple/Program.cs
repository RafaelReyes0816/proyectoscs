using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AppListaSimple.Clases;

namespace AppListaSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila<int> pila = new Pila<int>();
            pila.Push(12);
            pila.Push(22);
            pila.Push(32);
            pila.Push(42);
            Console.WriteLine($"Cima: {pila.peek()}");
            Console.WriteLine($"Cantidad actual { pila.Tamano()}");
            Console.WriteLine($"Eliminando elemento: {pila.pop()}");
            Console.WriteLine($"Cima: {pila.peek()}");
            Console.WriteLine($"Cantidad actual { pila.Tamano()}");
            Console.WriteLine($"Eliminando elemento: {pila.pop()}");
            Console.WriteLine($"Cima: {pila.peek()}");
            Console.WriteLine($"Cantidad actual { pila.Tamano()}");
        }
    }
}
