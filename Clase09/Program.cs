class Program
{
    static void Main(string[] args)
    {
        ArbolAVL<int> arbol = new ArbolAVL<int>();

        // Inserciones al árbol
        int[] valores = { 7, 9, 5, 10, 8, 6, 1, 15, 0, 4, -2, 50, 12, 3, -8, -1, 14, -10 };
        foreach (var valor in valores)
        {
            arbol.Insertar(valor);
        }

        // Mostrar árbol estructurado
        Console.WriteLine("Árbol AVL:");
        arbol.Mostrar();

        // Recorrido Inorden
        Console.WriteLine("\nRecorrido Inorden:");
        arbol.Inorden();
    }
}
