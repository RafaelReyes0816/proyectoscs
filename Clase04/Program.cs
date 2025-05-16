using System;
using Clase04.Clases;

namespace Clase04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola<string> colaLibros = new Cola<string>(0);
            bool salir = false;

            while (!salir)
            {
                Console.Clear(); // Limpia la consola antes de mostrar el menú
                Console.WriteLine("--- Menú de Libros ---");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Quitar libro");
                Console.WriteLine("3. Ver cantidad de libros");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del libro: ");
                        string libro = Console.ReadLine();
                        colaLibros.Enqueue(libro);
                        Console.WriteLine($"Libro '{libro}' agregado.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "2":
                        if (!colaLibros.IsEmpty())
                        {
                            string quitado = colaLibros.Dequeue();
                            Console.WriteLine($"Libro '{quitado}' quitado.");
                        }
                        else
                        {
                            Console.WriteLine("La cola está vacía.");
                        }
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Cantidad de libros: " + colaLibros.size());
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Write("¿Está seguro que desea salir? (s/n): ");
                        string confirmacion = Console.ReadLine();
                        if (confirmacion.ToLower() == "s")
                        {
                            salir = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}