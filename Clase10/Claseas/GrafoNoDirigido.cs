internal class GrafoNoDirigido<T> : IGrafo<T> where T : IComparable<T>
{
    private readonly Dictionary<T, List<Arista<T>>> listaDeADJ;
    private readonly Enumeradores.TipoGrafo tipo;

    public GrafoNoDirigido(Enumeradores.TipoGrafo tipo)
    {
        listaDeADJ = new Dictionary<T, List<Arista<T>>>();
        this.tipo = tipo;
    }

    public void AgregarArista(T verticeA, T verticeB, double peso = 1)
    {
        AgregarVertice(verticeA);
        AgregarVertice(verticeB);

        switch (this.tipo)
        {
            case Enumeradores.TipoGrafo.Dirigido:
                AgregarAristaDirigida(verticeA, verticeB, peso);
                break;
            case Enumeradores.TipoGrafo.NoDirigido:
                AgregarAristaNoDirigida(verticeA, verticeB, peso);
                break;
        }
    }

    private void AgregarAristaDirigida(T origen, T destino, double peso)
    {
        listaDeADJ[origen].Add(new Arista<T>(destino, peso));
    }

    private void AgregarAristaNoDirigida(T verticeA, T verticeB, double peso)
    {
        listaDeADJ[verticeA].Add(new Arista<T>(verticeB, peso));
        listaDeADJ[verticeB].Add(new Arista<T>(verticeA, peso));
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
        return listaDeADJ.ContainsKey(vertice) ? listaDeADJ[vertice].Select(e => e.Destino) : Enumerable.Empty<T>();
    }

    public List<T> RecorridoBFS(T vertice)
    {
        HashSet<T> visitados = new HashSet<T>();
        Queue<T> cola = new Queue<T>();
        List<T> resultado = new List<T>();

        cola.Enqueue(vertice);
        visitados.Add(vertice);

        while (cola.Count > 0)
        {
            T actual = cola.Dequeue();
            resultado.Add(actual);

            foreach (T vecino in listaDeADJ[actual].Select(e => e.Destino))
            {
                if (!visitados.Contains(vecino))
                {
                    visitados.Add(vecino);
                    cola.Enqueue(vecino);
                }
            }
        }
        return resultado;
    }

    public List<T> RecorridoDFS(T vertice)
    {
        HashSet<T> visitados = new HashSet<T>();
        List<T> resultado = new List<T>();

        DFS(vertice, visitados, resultado);
        return resultado;
    }

    private void DFS(T actual, HashSet<T> visitados, List<T> resultado)
    {
        if (visitados.Contains(actual))
        {
            return;
        }
        visitados.Add(actual);
        resultado.Add(actual);

        foreach (T vecino in listaDeADJ[actual].Select(e => e.Destino))
        {
            DFS(vecino, visitados, resultado);
        }
    }

    public IEnumerable<T> ObtenerVecinos(T vertice)
    {
        if (listaDeADJ.ContainsKey(vertice))
        {
            return listaDeADJ[vertice].Select(e => e.Destino);
        }
        return Enumerable.Empty<T>();
    }

    public void MostrarGrafo()
    {
        foreach (var vertice in listaDeADJ)
        {
            Console.Write($"{vertice.Key}: ");
            foreach (var arista in vertice.Value)
            {
                Console.Write($"{arista.Destino}({arista.Peso}) ");
            }
            Console.WriteLine();
        }
    }
}