internal interface IArista<T> where T : IComparable<T>
{
    T Destino { get; }
    double Peso { get; }
}