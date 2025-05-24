internal class Program
{
    static void Main(string[] args)
    {
        ArbolGeneral<string> arbol = new ArbolGeneral<string>("Raiz");
        arbol.AgregarNodo("Raiz", "A");
        arbol.AgregarNodo("Raiz", "B");
        arbol.AgregarNodo("A", "D");
        arbol.AgregarNodo("A", "E");
        arbol.AgregarNodo("B", "F");

        Console.WriteLine("Árbol original:");
        arbol.Mostrar(arbol.Raiz);

        Console.WriteLine("\nIntentando eliminar el nodo 'A'...");
        bool eliminado = arbol.EliminarNodo("A");
        if (eliminado)
            Console.WriteLine("Nodo 'A' eliminado correctamente.\n");
        else
            Console.WriteLine("No se pudo eliminar el nodo 'A'.\n");

        Console.WriteLine("Árbol después de la eliminación:");
        arbol.Mostrar(arbol.Raiz);
    }
}