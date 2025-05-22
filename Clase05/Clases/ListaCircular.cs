    internal class ListaCircular<T> : IListaCircular<T>
    {
        private NodoCircular<T> ultimo;
        public int Cantidad;

        public ListaCircular()
        {
            this.ultimo = null;
            this.Cantidad = 0;
        }

        public void AgregarFinal(T elemento)
        {
            NodoCircular<T> NuevoNodo = new NodoCircular<T>(elemento);
            if (EsVacio())
            {
                this.ultimo = NuevoNodo;
                this.ultimo.Siguiente = this.ultimo;
                this.Cantidad++;
            }
            else
            {
                NuevoNodo.Siguiente = this.ultimo.Siguiente;
                this.ultimo.Siguiente = NuevoNodo;
                this.ultimo = NuevoNodo;
                this.Cantidad++;
            }
        }

        public void AgregarInicio(T elemento)
        {
            NodoCircular<T> NuevoNodo = new NodoCircular<T>(elemento);
            if (EsVacio())
            {
                this.ultimo = NuevoNodo;
                this.ultimo.Siguiente = this.ultimo;
                this.Cantidad++;
            }
            else
            {
                NuevoNodo.Siguiente = this.ultimo.Siguiente;
                this.ultimo.Siguiente = NuevoNodo;
                this.Cantidad++;
            }
        }

        public bool EliminarElemento(T elemento)
        {
            if (EsVacio())
            {
                Console.WriteLine("La lista esta vacia");
                return false;
            }
            NodoCircular<T> NodoActual = this.ultimo.Siguiente;
            NodoCircular<T> NodoAnterior = this.ultimo;

            do
            {
                if (NodoActual.Valor.Equals(elemento))
                {
                    //Eliminar
                    if (NodoActual == this.ultimo && NodoActual == this.ultimo.Siguiente)
                    {
                        this.ultimo = null;
                    }
                    else
                    {
                        NodoAnterior.Siguiente = NodoActual.Siguiente;
                        if (NodoActual == this.ultimo)
                        {
                            this.ultimo = NodoAnterior;
                        }
                    }
                    this.Cantidad--;
                    return true;
                }
                NodoAnterior = NodoActual;
                NodoActual = NodoActual.Siguiente;
            }
            while (NodoActual != this.ultimo.Siguiente);
            return false;
        }

        public bool EsVacio()
        {
            return this.ultimo == null;
        }

        public void RecorrerLista()
        {
            if (EsVacio())
            {
                throw new Exception("La lista esta vacia");
            }

            NodoCircular<T> NodoActual = this.ultimo.Siguiente;
            do
            {
                Console.Write($"({NodoActual.Valor})->");
                NodoActual = NodoActual.Siguiente;
            }
            while (NodoActual != ultimo.Siguiente);
            Console.WriteLine();
        }
    }
