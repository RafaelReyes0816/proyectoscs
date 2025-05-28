internal interface IGrafo<T> where T : IComparable<T>
{
    void AgregarVertice(T vertice);
    void AgregarArista(T verticeA, T verticeB, double peso = 1);
    IEnumerable<T> ObtenerVertices(T vertice);
    void MostrarGrafo();
    List<T> RecorridoDFS(T vertice);
    List<T> RecorridoBFS(T vertice);
}