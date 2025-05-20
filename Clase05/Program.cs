class Program
{
    static void Main(string[] args)
    {
        ListaSimple<int> listaEnteros = new ListaSimple<int>();
        listaEnteros.InsertarElementoFinal(22);
        listaEnteros.InsertarElementoFinal(14);
        listaEnteros.InsertarElementoFinal(66);
        listaEnteros.InsertarElementoInicio(99);

        Console.WriteLine($"Cantidad: {listaEnteros.Cantidad()}");

        // Mostrar elementos con índices
        Console.WriteLine("Elementos con índices:");
        for (int i = 0; i < listaEnteros.Cantidad(); i++)
        {
            // Suponiendo que tienes un método ObtenerElemento(i)
            Console.WriteLine($"[{i}]: {listaEnteros.ObtenerElemento(i)}");
        }

        Console.Write("¿Qué índice deseas eliminar? ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int indice))
        {
            try
            {
                Console.WriteLine($"Eliminando: {listaEnteros.EliminarElemento(indice)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Índice inválido.");
        }

        Console.WriteLine(listaEnteros.MostrarElementos());
    }
}