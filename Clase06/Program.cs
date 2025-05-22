internal class Program
{
    static void Main(string[] args)
    {
        ListaDoble<int> lista = new ListaDoble<int>();
        lista.AgregarFinal(1);
        lista.AgregarFinal(2);
        lista.AgregarFinal(3);
        lista.AgregarInicio(4);
        lista.AgregarInicio(5);

        lista.MostrarAdelante();
        lista.MostrarAtras();

        
    }
}