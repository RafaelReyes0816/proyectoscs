// Implementación para triángulos con método recursivo
public class Triangulo : Figura, IDibujable
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(string nombre, double @base, double altura) : base(nombre)
    {
        Base = @base;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }

    // Versión recursiva del cálculo de área
    public double CalcularAreaRecursivo(double baseTriangulo, double alturaTriangulo, int iteraciones = 1)
    {
        if (iteraciones == 1)
            return (baseTriangulo * alturaTriangulo) / 2;
        
        double areaParcial = (baseTriangulo * alturaTriangulo / iteraciones) / 2;
        return areaParcial + CalcularAreaRecursivo(baseTriangulo, alturaTriangulo, iteraciones - 1);
    }

    public void Dibujar()
    {
        Console.WriteLine($"Dibujando triángulo {Nombre}");
    }
}