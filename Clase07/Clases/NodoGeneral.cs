internal class NodoGeneral<T>
{
    public T Valor { get; set; }
    public List<NodoGeneral<T>> Hijos { get; set; }

    public NodoGeneral(T valor)
    {
        this.Valor = valor;
        this.Hijos = new List<NodoGeneral<T>>();
    }
}