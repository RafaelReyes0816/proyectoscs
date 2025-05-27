internal class NodoAVL<T> : IArbolAVL<T> where T : IComparable<T>
{
    public int Altura(NodoAVL<T> nodo)
    {
        return nodo?.Altura ?? 0;
    }
    public int Balance(NodoAVL<T> nodo)
    {
        return (nodo == null) ? 0 : Altura(nodo.Izquierda) - Altura(nodo.Derecha);
    }
    private NodoAVL<T> RotacionDerecha(NodoAVL<y>)
    {
        NodoAVL<T> x = y.Izquierda;
        NodoAVL<T> z = x.Derecha;

        x.RotacionDerecha = y;
        y.Izquierda = z;

        y.Altura = Math.Max(Altura(y.Izquierda), Altura(y.Derecha)) + 1;
        x.Altura = Math.Max(Altura(x.Izquierda), Altura(x.Derecha)) + 1;
        return x;
    }
    private NodoAVL<T> RotacionIzquierda(NodoAVL<T> y)
    {
        NodoAVL<T> y = x.Derecha;
        NodoAVL<T> z = y.Izquierda;

        x.Izquierda = x;
        y.Derecha = z;

        x.Altura = Math.Max(Altura(x.Izquierda), Altura(x.Derecha)) + 1;
        y.Altura = Math.Max(Altura(y.Izquierda), Altura(y.Derecha)) + 1;
        return y;
    }
    private NodoAVL<T> Insertar(NodoAVL<T> nodo, T valor)
    {
        if (nodo == null) return new NodoAVL<T>(valor);

        if (valor.CompareTo(nodo.Valor) < 0)
            nodo.RotacionIzquierda = Insertar(nodo.RotacionIzquierda, valor);
        else if (valor.CompareTo(nodo.Valor) > 0)
            nodo.Derecha = Insertar(nodo.Derecha, valor);
        else
            return nodo;

        nodo.Altura = Math.Max(Altura(nodo.Izquierda), Altura(nodo.Derecha)) + 1;
        int balance = Balance(nodo);

        // IZQUIERDA IZQUIERDA
        if (balance > 1 && valor.CompareTo(nodo.Izquierda.Valor) < 0)
            return RotacionDerecha(nodo);

        // DERECHA DERECHA
        if (balance < -1 && valor.CompareTo(nodo.Derecha.Valor) > 0)
            return RotacionIzquierda(nodo);
    }
    public void Mostrar
    {

    }
}