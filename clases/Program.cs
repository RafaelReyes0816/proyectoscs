class Program
{
    static void Main(string[] args)
    {
        // Creación de figuras
        var figuras = new List<Figura>
        {
            new Cuadrado("Cuadrado1", 5),
            new Circulo("Circulo1", 3),
            new Triangulo("Triangulo1", 4, 6)
        };

        // Cálculo y muestra de áreas
        Console.WriteLine("Áreas calculadas:");
        foreach (var figura in figuras)
        {
            Console.WriteLine($"{figura.Nombre}: {figura.CalcularArea():F2}");
            
            // Dibujar cada figura
            if (figura is IDibujable dibujable)
                dibujable.Dibujar();
        }

        // Demostración del método recursivo
        var triangulo = (Triangulo)figuras[2];
        Console.WriteLine($"\nÁrea recursiva del triángulo: {triangulo.CalcularAreaRecursivo(triangulo.Base, triangulo.Altura, 10):F2}");

        Console.ReadKey();
    }
}