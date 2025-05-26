internal class ArbolGeneral<T>
{
    public NodoGeneral<T> Raiz;
    public ArbolGeneral(T raiz)
    {
        this.Raiz = new NodoGeneral<T>(raiz);
    }
    public bool AgregarNodo(T valorPadre, T nuevoValor)
    {
        // Implementación de agregar nodo
        NodoGeneral<T> Padre = BuscarNodo(this.Raiz, valorPadre);
        if (Padre == null)
            return false;
        Padre.Hijos.Add(new NodoGeneral<T>(nuevoValor));
        return true;
    }

    public NodoGeneral<T> BuscarNodo(NodoGeneral<T> nodo, T valor)
    {
        if (nodo == null) return null;

        if (nodo.Valor.Equals(valor))
            return nodo;

        foreach (NodoGeneral<T> hijo in nodo.Hijos)
        {
            NodoGeneral<T> encontrado = BuscarNodo(hijo, valor);

            if (encontrado != null)
                return encontrado;
        }
        return null;
    }

    public void Mostrar(NodoGeneral<T> nodo, string indent = "")
    {
        if (nodo == null) return;

        Console.WriteLine(indent + "- " + nodo.Valor);
        foreach (NodoGeneral<T> hijo in nodo.Hijos)
        {
            Mostrar(hijo, indent + "  ");
        }
    }

    public bool EliminarNodo(T valor)
    {
        if (this.Raiz == null) return false;
        if (this.Raiz.Valor.Equals(valor))
        {
            this.Raiz = null;
            return true;
        }
        return EliminarRecursivo(this.Raiz, valor);
    }

    public bool EliminarRecursivo(NodoGeneral<T> nodo, T valor)
    {
        foreach (NodoGeneral<T> hijo in nodo.Hijos)
        {
            if (hijo.Valor.Equals(valor))
            {
                nodo.Hijos.Remove(hijo);
                return true;
            }
            if (EliminarRecursivo(hijo, valor))
            {
                return true;
            }
        }
        return false;
    }
}