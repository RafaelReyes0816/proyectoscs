internal class ListaSimple<T> : IListaEnlazada<T>
{
    private NodoSimple<T>? Inicio;
    private int cantidad;
    public ListaSimple()
    {
        this.Inicio = null;
        this.cantidad = 0;
    }
    public int BuscarElemento(T elemento)
    {
        int indice = -1;
        NodoSimple<T> temp = this.Inicio;
        for (int i = 0; i < this.cantidad; i++)
        {
            if (elemento.Equals(temp.Valor))
            {
                indice = i;
                break;
            }
            else
            {
                temp = temp.Siguiente;
            }
        }
        return indice;
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
        if (EsVacio() || indice < 0 || indice > cantidad - 1)
        {
            throw new Exception("Indice fuera de rango");
        }
        else
        {
            NodoSimple<T> Temp = this.Inicio;
            for (int i = 0; i < indice; i++)
            {
                Temp = Temp.Siguiente;
            }
            Temp.Valor = elemento;
        }
    }

    public void VaciarLista()
    {
        this.Inicio = null;
    }
    public T EliminarElemento(int indice)
    {
        // Validar índice y lista vacía
        if (EsVacio() || indice < 0 || indice >= this.cantidad)
            throw new Exception("No se puede realizar la eliminación");

        T valorEliminado;

        if (indice == 0)
        {
            // Elimina el primer nodo
            if (this.Inicio == null)
                throw new Exception("La lista está vacía");
            valorEliminado = this.Inicio.Valor;
            this.Inicio = this.Inicio.Siguiente;
        }
        else
        {
            // Elimina un nodo que no es el primero (puede ser del medio o final)
            NodoSimple<T>? anterior = this.Inicio;
            for (int i = 0; i < indice - 1; i++)
            {
                if (anterior == null)
                    throw new Exception("Nodo anterior inesperadamente nulo");
                anterior = anterior.Siguiente;
            }
            if (anterior?.Siguiente == null)
                throw new Exception("Nodo a eliminar inesperadamente nulo");
            NodoSimple<T> nodoAEliminar = anterior.Siguiente;
            valorEliminado = nodoAEliminar.Valor;
            anterior.Siguiente = nodoAEliminar.Siguiente;
        }

        this.cantidad--;
        return valorEliminado;
    }

    public T ObtenerElemento(int indice)
    {
        // Validación de índice para evitar errores
        if (indice < 0 || indice >= this.cantidad)
            throw new IndexOutOfRangeException("Índice fuera de rango");

        NodoSimple<T>? actual = this.Inicio;
        for (int i = 0; i < indice; i++)
        {
            // Validación para evitar referencias nulas
            if (actual == null)
                throw new Exception("Nodo inesperadamente nulo");
            actual = actual.Siguiente;
        }
        if (actual == null)
            throw new Exception("Nodo inesperadamente nulo");
        return actual.Valor;
    }
}