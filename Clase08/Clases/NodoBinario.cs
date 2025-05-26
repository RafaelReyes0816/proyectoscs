internal class NodoBinario<T> where T : IComparable<T>
{
    public T Valor;
    public NodoBinario<T> Izquierdo;
    public NodoBinario<T> Derecho;

    public NodoBinario(T valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}