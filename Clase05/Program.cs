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
        Console.WriteLine(listaEnteros.MostrarElementos());
        Console.WriteLine($"Eliminando: {listaEnteros.EliminarElemento(0)}");
        Console.WriteLine(listaEnteros.MostrarElementos());
    }
}