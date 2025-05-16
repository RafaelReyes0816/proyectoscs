using System;
using Clase04.Clases; // Agrega este using

namespace Clase04
{
    // Clase principal del programa
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola<string> colaLibros = new Cola<string>(0); // Usa Cola con mayúscula
            Console.WriteLine("Agregando Matemáticas");
            colaLibros.Enqueue("Matemáticas");

            Console.WriteLine("Agregando Química");
            colaLibros.Enqueue("Química");

            Console.WriteLine("Agregando Música");
            colaLibros.Enqueue("Música");

            Console.WriteLine("Cantidad de elementos; " + colaLibros.size());
            Console.WriteLine("Quitando libro " + colaLibros.Dequeue());
            Console.WriteLine("Cantidad de elementos; " + colaLibros.size());
        }
    }
}