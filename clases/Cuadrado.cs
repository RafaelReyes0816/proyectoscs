// Implementación para cuadrados
public class Cuadrado : Figura, IDibujable
{
    public double Lado { get; set; }

    public Cuadrado(string nombre, double lado) : base(nombre)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public void Dibujar()
    {
        Console.WriteLine($"Dibujando cuadrado {Nombre}");
    }
}