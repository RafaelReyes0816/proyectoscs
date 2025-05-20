interface IListaEnlazada<T>
{
    void InsertarElementoInicio(T elemento);
    void InsertarElementoFinal(T elemento);
    bool EsVacio();
    int BuscarElemento(T elemento);
    int Cantidad();
    string MostrarElementos();
    void ReemplazarValor(int indice, T elemento);
    void VaciarLista();
    T EliminarElemento(int indice);
}