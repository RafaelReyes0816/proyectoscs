internal class NodoAVL<T> where T : IComparable<T>
{
    public T Valor;
    public NodoAVL<T> Izquierda;
    public NodoAVL<T> Derecha;
    public int Altura;

    public NodoAVL(T valor)
    {
        this.Valor = valor;
        this.Izquierda = null;
        this.Derecha = null;
        this.Altura = 1;
    }
}