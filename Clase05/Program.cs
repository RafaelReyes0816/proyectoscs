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

        Console.WriteLine($"Buscar 14: {listaEnteros.BuscarElemento(14)}");

        //ListaCricular
        ListaCircular<int> listaCircular = new ListaCircular<int>();
        listaCircular.AgregarFinal(10);
        listaCircular.AgregarFinal(20);
        listaCircular.AgregarFinal(30);
        listaCircular.AgregarInicio(40);

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

        // Mostrar elementos de la lista circular
        Console.WriteLine("Elementos de la lista circular:");
        listaCircular.RecorrerLista();

        // Eliminar un elemento de la lista circular
        Console.Write("¿Qué valor deseas eliminar de la lista circular? ");
        string? inputCircular = Console.ReadLine();
        if (int.TryParse(inputCircular, out int valorEliminar))
        {
            if (listaCircular.EliminarElemento(valorEliminar))
                Console.WriteLine($"Elemento {valorEliminar} eliminado.");
            else
                Console.WriteLine("Elemento no encontrado.");
        }
        else
        {
            Console.WriteLine("Valor inválido.");
        }

        // Mostrar la lista circular después de eliminar
        Console.WriteLine("Lista circular después de eliminar:");
        listaCircular.RecorrerLista();
    }
}