internal interface IArbolBinario<T> where T : IComparable<T>
{
    void insertar(T valor);
    NodoBinario<T> InsertarRecursivo(NodoBinario<T> nodo, T valor);
    bool BuscarRecursivo(NodoBinario<T> nodo, T valor);
    void Inorden(NodoBinario<T> nodo);
    void Preorden(NodoBinario<T> nodo);
    void Postorden(NodoBinario<T> nodo);
}