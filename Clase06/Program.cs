internal class Program
{
    static void Main(string[] args)
    {


        ListaDobleCircular<int> lista = new ListaDobleCircular<int>();
        lista.AgregarFinal(1);
        lista.AgregarFinal(2);
        lista.AgregarFinal(3);
        lista.AgregarFinal(4);
        lista.AgregarInicio(5);
        lista.AgregarInicio(6);

        lista.MostrarAdelante();
        lista.MostrarAtras();



        lista.RecorrerAdelante();
        lista.RecorrerAtras();
        Console.WriteLine("Eliminando posicion 3");
        lista.EliminarPosicion(3);
        lista.MostrarAdelante();
        lista.MostrarAtras();
    }
}