public class NodoDobleCircular<T>
{
    public T Valor;
    public NodoDobleCircular<T>? Siguiente;
    public NodoDobleCircular<T>? Anterior;

    public NodoDobleCircular(T valor)
    {
        Valor = valor;
        Siguiente = null;
        Anterior = null;
    }
}