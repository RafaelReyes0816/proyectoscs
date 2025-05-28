internal class Arista<T> : IArista<T> where T : IComparable<T>
{
    public T Destino; { get; }
    public double Peso; {get; }

    public Arista(T destino, double peso)
    {
        Destino = destino;
        Peso = peso;
    }
}