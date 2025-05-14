class Program
{
    static void Main()
    {
        IHistorialNavegacion<string> navegador = new HistorialNavegacion<string>();

        navegador.Visitar("inicio.com");
        navegador.Visitar("servicios.com");
        navegador.Visitar("contacto.com");

        navegador.Retroceder(); // debería estar en servicios.com
        Console.WriteLine("Actual: " + navegador.ObtenerPaginaActual());

        navegador.Retroceder(); // debería estar en inicio.com
        navegador.Avanzar();    // volver a servicios.com
        navegador.Visitar("blog.com"); // rompe el "camino" hacia adelante

        Console.WriteLine("Actual: " + navegador.ObtenerPaginaActual());
    }
}