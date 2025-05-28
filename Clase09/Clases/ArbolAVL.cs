internal class ArbolAVL<T> : IArbolAVL<T> where T : IComparable<T>
{
    private NodoAVL<T> Raiz;

    public ArbolAVL()
    {
        this.Raiz = null;
    }

    public int Altura(NodoAVL<T> nodo)
    {
        return nodo?.Altura ?? 0;
    }

    public int Balance(NodoAVL<T> nodo)
    {
        return (nodo == null) ? 0 : Altura(nodo.Izquierda) - Altura(nodo.Derecha);
    }

    private NodoAVL<T> RotacionDerecha(NodoAVL<T> y)
    {
        NodoAVL<T> x = y.Izquierda;
        NodoAVL<T> z = x.Derecha;

        x.Derecha = y;
        y.Izquierda = z;

        y.Altura = Math.Max(Altura(y.Izquierda), Altura(y.Derecha)) + 1;
        x.Altura = Math.Max(Altura(x.Izquierda), Altura(x.Derecha)) + 1;
        return x;
    }

    private NodoAVL<T> RotacionIzquierda(NodoAVL<T> x)
    {
        NodoAVL<T> y = x.Derecha;
        NodoAVL<T> z = y.Izquierda;

        x.Derecha = z;
        y.Izquierda = x;

        x.Altura = Math.Max(Altura(x.Izquierda), Altura(x.Derecha)) + 1;
        y.Altura = Math.Max(Altura(y.Izquierda), Altura(y.Derecha)) + 1;
        return y;
    }

    public NodoAVL<T> Insertar(NodoAVL<T> nodo, T valor)
    {
        if (nodo == null)
            return new NodoAVL<T>(valor);

        if (valor.CompareTo(nodo.Valor) < 0)
            nodo.Izquierda = Insertar(nodo.Izquierda, valor);
        else if (valor.CompareTo(nodo.Valor) > 0)
            nodo.Derecha = Insertar(nodo.Derecha, valor);
        else
            return nodo;

        nodo.Altura = Math.Max(Altura(nodo.Izquierda), Altura(nodo.Derecha)) + 1;
        int balance = Balance(nodo);

        if (balance > 1 && valor.CompareTo(nodo.Izquierda.Valor) < 0)
            return RotacionDerecha(nodo);

        if (balance < -1 && valor.CompareTo(nodo.Derecha.Valor) > 0)
            return RotacionIzquierda(nodo);

        if (balance > 1 && valor.CompareTo(nodo.Izquierda.Valor) > 0)
        {
            nodo.Izquierda = RotacionIzquierda(nodo.Izquierda);
            return RotacionDerecha(nodo);
        }

        if (balance < -1 && valor.CompareTo(nodo.Derecha.Valor) < 0)
        {
            nodo.Derecha = RotacionDerecha(nodo.Derecha);
            return RotacionIzquierda(nodo);
        }

        return nodo;
    }

    public void Insertar(T valor)
    {
        this.Raiz = Insertar(this.Raiz, valor);
    }

    public void Mostrar()
    {
        Mostrar(this.Raiz, "", true);
    }

    private void Mostrar(NodoAVL<T> nodo, string indent, bool esDerecha)
    {
        if (nodo == null)
        {
            Console.WriteLine(indent + (esDerecha ? "|- " : "|_ ") + "null");
            return;
        }

        Console.WriteLine(indent + (esDerecha ? "|- " : "|_ ") + nodo.Valor);
        string nuevaIndentacion = indent + (esDerecha ? "  " : "|   ");

        Mostrar(nodo.Izquierda, nuevaIndentacion, false);
        Mostrar(nodo.Derecha, nuevaIndentacion, true);
    }

    public void Inorden()
    {
        Inorden(this.Raiz);
        Console.WriteLine();
    }

    private void Inorden(NodoAVL<T> nodo)
    {
        if (nodo == null) return;
        Inorden(nodo.Izquierda);
        Console.Write(nodo.Valor + " ");
        Inorden(nodo.Derecha);
    }
}

