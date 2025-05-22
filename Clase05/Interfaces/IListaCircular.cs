    internal interface IListaCircular<T>
    {
        bool EsVacio();
        void AgregarFinal(T elemento);
        void AgregarInicio(T elemento);
        void RecorrerLista();
        bool EliminarElemento(T elemento);
    }
