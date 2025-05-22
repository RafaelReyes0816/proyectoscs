internal interface IListaDoble<T>
{
    void AgregarFinal(T elemento);
    void AgregarInicio(T elemento);
    bool EliminarNodo(T elemento);
    bool EsVacio();
    void MostrarAdelante();
    void MostrarAtras();
}