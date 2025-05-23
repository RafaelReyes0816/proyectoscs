public class ListaDobleCircular<T>
{
    private NodoDobleCircular<T>? Inicio;
    public int Longitud;

    public ListaDobleCircular()
    {
        Inicio = null;
        Longitud = 0;
    }

    public bool EsVacio()
    {
        return this.Inicio == null;
    }

    public void AgregarFinal(T valor)
    {
        NodoDobleCircular<T> nuevo = new NodoDobleCircular<T>(valor);
        if (EsVacio())
        {
            nuevo.Siguiente = nuevo;
            nuevo.Anterior = nuevo;
            this.Inicio = nuevo;
        }
        else
        {
            NodoDobleCircular<T> fin = this.Inicio!.Anterior!;
            fin.Siguiente = nuevo;
            nuevo.Anterior = fin;
            nuevo.Siguiente = this.Inicio;
            this.Inicio.Anterior = nuevo;
        }
        this.Longitud++;
    }

    public void AgregarInicio(T valor)
    {
        NodoDobleCircular<T> nuevo = new NodoDobleCircular<T>(valor);
        if (EsVacio())
        {
            nuevo.Siguiente = nuevo;
            nuevo.Anterior = nuevo;
            this.Inicio = nuevo;
        }
        else
        {
            NodoDobleCircular<T> fin = this.Inicio!.Anterior!;
            nuevo.Siguiente = this.Inicio;
            nuevo.Anterior = fin;
            fin.Siguiente = nuevo;
            this.Inicio.Anterior = nuevo;
            this.Inicio = nuevo;
        }
        this.Longitud++;
    }

    public void MostrarAdelante()
    {
        if (EsVacio())
        {
            Console.WriteLine("La Lista está vacía");
        }
        else
        {
            NodoDobleCircular<T> actual = this.Inicio!;
            do
            {
                Console.Write($"({actual.Valor}) <-> ");
                actual = actual.Siguiente!;
            }
            while (actual != this.Inicio);
            Console.Write("inicio\n");
        }
    }
    public void MostrarAtras()
    {
        if (EsVacio())
        {
            Console.WriteLine("La Lista está vacía");
        }
        else
        {
            NodoDobleCircular<T> final = this.Inicio!.Anterior;
            do
            {
                Console.Write($"({actual.Valor}) <-> ");
                actual = actual.Anterior!;
            }
            while (actual != this.Inicio.Anterior);
            Console.Write("final\n");
        }
    }
    public void EliminarPosicion(int indice)
    {
        if (EsVacio() || indice < 0 || indice >= this.Longitud)
        {
            Console.WriteLine("El indice esta fuera de rango");
            return;
        }
        if (this.Longitud == 1)
        {
            this.Inicio = null;
        }
        else
        {
            NodoDobleCircular<T> actual = this.Inicio!;
            for (int i = 0; i < indice; i++)
            {
                actual = actual.Siguiente!;
            }
            NodoDobleCircular<T> anterior = actual.Anterior!;
            NodoDobleCircular<T> siguiente = actual.Siguiente!;
            anterior.Siguiente = siguiente;
            siguiente.Anterior = anterior;
            if (this.Longitud == 1)
            {
                this.Inicio = null;
            }
            else
            {
                NodoDobleCircular<T> actual = this.Inicio;
                for (int i = 0; i < indice; i++)
                {
                    actual = actual.Siguiente;
                }

                actual.Anterior.Siguiente = actual.Siguiente;
                actual.Siguiente.Anterior = actual.Anterior;

                if (actual == this.Inicio)
                {
                    this.Inicio = actual.Siguiente;
                }
            }
            this.Longitud--;
        }
    }
}