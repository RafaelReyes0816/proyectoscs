internal class NodoDoble<T>
{
    public T Valor { get; set; }
    public NodoDoble<T> Siguiente;
    public NodoDoble<T> Anterior;

    public NodoDoble(T valor)
    {
        this.Valor = valor;
        this.Anterior = null;
        this.Siguiente = null;
    }
}