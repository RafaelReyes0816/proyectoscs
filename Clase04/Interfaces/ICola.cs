namespace Clase04.Interfaces
{
    public interface ICola<T>
    {
        void Enqueue(T elemento); //Agregar Elementos
        T Dequeue(); //Eliminar Elementos

        bool IsEmpty(); //Verificar si la cola está vacía

        bool IsFull(); //Verificar si la cola está llena

        int size(); //Tamaño de la cola


    }
}