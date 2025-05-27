internal interface IArbolAVL<T> where T : IComparable<T>
{
    void Insertar(T valor);
    NodoAVL<T> Insertar(NodoAVL<T> nodo, T valor);
    int Altura(NodoAVL<T> nodo);
    int Balance(NodoAVL<T> nodo);
    void Mostrar();
    void Inorden();
}