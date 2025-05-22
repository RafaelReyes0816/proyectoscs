
    internal class NodoCircular<T>
    {
        public T Valor { get; set; }
        public NodoCircular<T> Siguiente;

        public NodoCircular(T valor)
        {
            this.Valor = valor;
            this.Siguiente = this;
        }
    }