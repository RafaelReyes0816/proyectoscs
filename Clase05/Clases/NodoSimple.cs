internal class NodoSimple<T>
{
    public T Valor { get; set; }
    public NodoSimple<T> Siguiente;

    public NodoSimple(T valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}