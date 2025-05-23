internal interface IListaDobleCircular<T>
{
    void AgregarInicio(T elemento);
    void AgregarFinal(T elemento);
    void EliminarPosicion(int indice);
    void RecorrerAdelante();
    void RecorrerAtras();
    void EsVacio();
}