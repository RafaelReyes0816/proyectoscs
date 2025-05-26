internal class ArbolBinario<T> : IArbolBinario<T> where T : IComparable<T>
{
    public NodoBinario<T> Raiz;
    public ArbolBinario()
    {
        this.Raiz = null;
    }
    public NodoBinario<T> InsertarRecursivo(NodoBinario<T> nodo, T valor)
    {
        if (nodo == null) return new NodoBinario<T>(valor);

        if (valor.CompareTo(nodo.Valor) < 0)
        {
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
        }
        else if (valor.CompareTo(nodo.Valor) > 0)
        {
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);
        }
        return nodo;
    }
    public void insertar(T valor)
    {
        this.Raiz = InsertarRecursivo(this.Raiz, valor);
    }
    public bool BuscarRecursivo(NodoBinario<T> nodo, T valor)
    {
        if (nodo == null) return false;

        if (valor.CompareTo(nodo.Valor) == 0)
        {
            return true;
        }
        else if (valor.CompareTo(nodo.Valor) < 0)
        {
            return BuscarRecursivo(nodo.Izquierdo, valor);
        }
        else
        {
            return BuscarRecursivo(nodo.Derecho, valor);
        }
    }
    public void Inorden(NodoBinario<T> nodo)
    {
        if (nodo != null)

        {
            Inorden(nodo.Izquierdo);
            Console.WriteLine(nodo.Valor + "->");
            Inorden(nodo.Derecho);
        }
    }
    public void Preorden(NodoBinario<T> nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + "->");
            Preorden(nodo.Izquierdo);
            Preorden(nodo.Derecho);
        }
    }

    public void Postorden(NodoBinario<T> nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izquierdo);
            Postorden(nodo.Derecho);
            Console.Write(nodo.Valor + "->");
        }
    }
}