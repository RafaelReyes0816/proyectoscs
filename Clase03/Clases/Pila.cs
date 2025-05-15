internal class Pila<T> : IPila<T>
{

    private T [] elementos;
    private int tope;
    private int tamano;

    public Pila (int tamano = 10)
    {
        this.tamano = tamano;
        this.tope = -1;
        this.elementos = new T[this.tamano];
    }

    public bool IsEmpty()
    {
        return this.tope == this.tamano -1;
    }
    public bool IsFull()
    {
        return this.tope -1 == this.tamano;
    }

    //Validar peek
    public T Peek()
    {
        if (this.tope == -1)
        {
            throw new Exception("La pila esta vacía, no se puede obtener el elemento");
        }
        return this.elementos[this.tope];

    }
    //Validación
    public T Pop()
    {
        if (IsEmpty)
        {
            throw new Exception("La pila esta vacía, no se puede obtener elemento");
        }
        return this.elementos[this.tope];
    }

    public void Push(T elemento)
    {
        if (IsFull)
        {
            throw new Exception("La pila esta llena, no se puede agregar más elementos");
        }
        return.elementos[++tope] = elemento;
    }
    public int Size()
    {
        return this.tope + 1;
    }
}