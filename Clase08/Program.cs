internal class Program
{
    static void Main(string[] args)
    {
        IArbolBinario<int> arbol = new ArbolBinario<int>();
        arbol.insertar(7);
        arbol.insertar(9);
        arbol.insertar(5);
        arbol.insertar(10);
        arbol.insertar(8);
        arbol.insertar(6);
        arbol.insertar(1);
        arbol.insertar(15);
        arbol.insertar(0);
        arbol.insertar(-2);
        arbol.insertar(50);
        arbol.insertar(12);
        arbol.insertar(3);
        arbol.insertar(-8);
        arbol.insertar(-1);
        arbol.insertar(14);
        arbol.insertar(-10);

        arbol.Inorden(((ArbolBinario<int>)arbol).Raiz);
        Console.WriteLine();
        arbol.Preorden(((ArbolBinario<int>)arbol).Raiz);
        Console.WriteLine("recorrido preorden");
        arbol.Postorden(((ArbolBinario<int>)arbol).Raiz);
        Console.WriteLine("recorrido postorden");
    }
}