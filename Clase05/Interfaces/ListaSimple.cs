internal class ListaSimple<T> : IListaEnlazada<T>
{
    private NodoSimple<T> Inicio;
    private int cantidad;
    public ListaSimple()
    {
        this.Inicio = null;
        this.cantidad = 0;
    }
    public int BuscarElemento(T elemento)
    {
        throw new NotImplementedException();
    }

    public int Cantidad()
    {
        return this.cantidad;
    }

    public bool EsVacio()
    {
        return this.Inicio == null;
    }

    public void InsertarElementoFinal(T elemento)
    {
        NodoSimple<T> NuevoNodo = new NodoSimple<T>(elemento);
        if (EsVacio())
        {
            this.Inicio = NuevoNodo;
        }
        else
        {
            NodoSimple<T> temp = this.Inicio;
            while (temp.Siguiente != null)
            {
                temp = temp.Siguiente;
            }
            temp.Siguiente = NuevoNodo;
        }
        this.cantidad++;
    }

    public void InsertarElementoInicio(T elemento)
    {
        NodoSimple<T> nuevoNodo = new NodoSimple<T>(elemento);
        nuevoNodo.Siguiente = this.Inicio;
        this.Inicio = nuevoNodo;
        this.cantidad++;
    }

    public string MostrarElementos()
    {
        string resultado = "";
        NodoSimple<T> temp = this.Inicio;
        if (!EsVacio())
        {
            while (temp != null)
            {
                resultado += $"[{temp.Valor}]-->";
                temp = temp.Siguiente;
            }
        }
        return resultado + "null";
    }
    public void ReemplazarValor(int indice, T elemento)
    {
        throw new NotImplementedException();
    }

    public void VaciarLista()
    {
        throw new NotImplementedException();
    }
    public T EliminarElemento(int indice)
    {
        if (EsVacio() || indice < 0 || indice >= this.cantidad)
            throw new Exception("No se puede realizar la eliminación");

        T valorEliminado;

        if (indice == 0)
        {
            // Eliminar el primer nodo
            valorEliminado = this.Inicio.Valor;
            this.Inicio = this.Inicio.Siguiente;
        }
        else
        {
            NodoSimple<T> anterior = this.Inicio;
            for (int i = 0; i < indice - 1; i++)
            {
                anterior = anterior.Siguiente;
            }
            NodoSimple<T> nodoAEliminar = anterior.Siguiente;
            valorEliminado = nodoAEliminar.Valor;
            anterior.Siguiente = nodoAEliminar.Siguiente;
        }

        this.cantidad--;
        return valorEliminado;
    }
}