/*
internal class ListaDoble<T> : IListaDoble<T>
{
    private NodoDoble<T> Inicio;
    private NodoDoble<T> Final;
    public int Longitud;

    public ListaDoble()
    {
        this.Inicio = null;
        this.Final = null;
        this.Longitud = 0;
    }
    public void AgregarFinal(T elemento)
    {
        NodoDoble<T> nuevoNodo = new NodoDoble<T>(elemento);
        if (EsVacio())
        {
            this.Inicio = nuevoNodo;
            this.Final = nuevoNodo;
        }
        else
        {
            this.Final.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = this.Final;
            this.Final = nuevoNodo;
        }
        this.Longitud++;
    }
    public void AgregarInicio(T elemento)
    {
        NodoDoble<T> NuevoNodo = new NodoDoble<T>(elemento);
        if (EsVacio())
        {
            this.Inicio = NuevoNodo;
            this.Final = NuevoNodo;
        }
        else
        {
            NuevoNodo.Siguiente = this.Inicio;
            this.Inicio.Anterior = NuevoNodo;
            this.Inicio = NuevoNodo;
        }

    }
    public bool EliminarNodo(T elemento)
    {
        NodoDoble<T> actual = this.Inicio;
        while (actual != null)
        {
            if (actual.valor.Equals(elemento))
            {
                if (actual.Anterior != null)
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                }
                else
                {
                    this.Inicio = actual.Siguiente;
                }
                if (actual.Siguiente != null)
                {
                    actual.Siguiente.Anterior = actual.Anterior;
                }
                else
                {
                    this.Final = actual.Anterior;
                }
                this.Longitud--;
            }
            actual = actual.Siguiente;
        }
    }
    public bool EsVacio()
    {
        return this.Inicio == null;
    }
    public void MostrarAdelante()
    {
        NodoDoble<T> actual = this.Inicio;
        while (actual != null)
        {
            Console.Write($"({actual.Valor})<->");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
    public void MostrarAtras()
    {
        NodoDoble<T> actual = this.Final;
        while (actual != null)
        {
            Console.Write($"[{actual.Valor}]<->");
            actual = actual.Anterior;
        }
        Console.WriteLine();
    }
}
*/