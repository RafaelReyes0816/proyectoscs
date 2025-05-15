using system;
internal class Program
{
    static void Main(string[] args)
    {
        Pila<int> listaEnteros = new Pila<int>();

        listaEnteros.Push(2);
        listaEnteros.Push(4);
        listaEnteros.Push(6);
        listaEnteros.Push(8);

        // Ejemplo de cómo mostrar los elementos
        Console.WriteLine("Elementos en la pila:");
        while (!listaEnteros.IsEmpty())
        {
            Console.WriteLine(listaEnteros.Pop());
        }
    }
}