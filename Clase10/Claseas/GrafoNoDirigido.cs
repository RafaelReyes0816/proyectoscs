internal class GrafoNoDirigido<T> : IGrafo<T> where T : IComparable<T>
{
    private readonly Dictionary<T, List<Arista<T>>> listaDeADJ;
    public GrafoNoDirigido()
    {
        listaDeADJ = new Dictionary<T, List<Arista<T>>>();
    }
    public void AgregarArista(T verticeA, T verticeB, double peso = 1)
    {

    }
    public void AgregarVertice(T vertice)
    {
        if (!listaDeADJ.ContainsKey(vertice))
        {
            listaDeADJ[vertice] = new List<Arista<T>>();
        }
    }
    public IEnumerable<T> ObtenerVertices(T vertice)
    {

    }
    public void RecorridoBFS(T vertice)
    {

    }
    public List<T> RecorridoDFS(T vertice)
    {
        
    }
}