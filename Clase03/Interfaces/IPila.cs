internal interface IPila<T>
{
    //Agregar elemento a la pila
    void Push (T elemento);

    //Quitar elemento de la pila
    T Pop();

    //Retorna elemento tope o cima
    T Peek();

    //Tamaño de la pila
    int Size();

    //La pila esta vacía
    bool IsEmpty();

    //La pila esta llena
    bool IsFull();
}