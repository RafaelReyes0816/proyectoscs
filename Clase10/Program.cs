internal class Program
{
    static void Main(string[] args)
    {
        var grafo = new GrafoNoDirigido<string>(Enumeradores.TipoGrafo.NoDirigido);

        grafo.AgregarArista("A", "B");
        grafo.AgregarArista("A", "C");
        grafo.AgregarArista("C", "E");
        grafo.AgregarArista("C", "D");
        grafo.AgregarArista("B", "D");

        grafo.AgregarArista("A", "B");
        grafo.AgregarArista("B", "D");
        grafo.AgregarArista("C", "D");
        grafo.AgregarArista("A", "C");
        grafo.AgregarArista("C", "E");


        Console.WriteLine("Vecinos de C:");
        foreach (var vecino in grafo.ObtenerVecinos("C"))
        {
            Console.WriteLine($" - {vecino}");
        }

        Console.WriteLine("Recorrido DFS:");
        foreach (var vertice in grafo.RecorridoDFS("A"))
        {
            Console.WriteLine($"DFS: {vertice}");
        }
        
        Console.WriteLine("Recorrido BFS:");
        foreach (var vertice in grafo.RecorridoBFS("A"))
        {
            Console.WriteLine($"BFS: {vertice}");
        }
        
    }
}
