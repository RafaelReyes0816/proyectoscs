// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Main(string[] args)
    {
        ListaGenerica<int> miLista = new ListaGenerica<int>();
        miLista.Agregar(10);
        miLista.Agregar(20);
        miLista.Agregar(30);
        miLista.Agregar(40);

        Console.WriteLine($"Cantidad: {miLista.cantidad()}");
        Console.WriteLine($"¿Existe 10? {miLista.Existe(10)}");
        Console.WriteLine($"¿Existe 35? {miLista.Existe(35)}");

        //Devuelve el valor si existe, o default si no
        int elemento = miLista.Obtener(30);
        Console.WriteLine($"Elemento obtenido: {elemento}");

        int elementoNoExistente = miLista.Obtener(55);
        Console.WriteLine($"Elemento no existente: {elementoNoExistente}");
    }

    public interface IListaGenerica<T>
    {
        void Agregar(T e);
        bool Existe(T e);
        T? Obtener(T e); //Método para obtener elemento
        void Eliminar(T e);
        int cantidad();
    }

    public class ListaGenerica<T> : IListaGenerica<T>
    {
        private HashSet<T> lista = new HashSet<T>();

        public void Agregar(T e)
        {
            lista.Add(e);
        }

        public bool Existe(T e)
        {
            return lista.Contains(e);
        }

        // Devuelve el elemento si existe, o default(T) si no está
        public T? Obtener(T e)
        {
            if (lista.Contains(e))
                return e;
            return default(T);
        }

        public void Eliminar(T e)
        {
            lista.Remove(e);
        }

        public int cantidad()
        {
            return lista.Count;
        }
    }
}