// Implementación para círculos
public class Circulo : Figura, IDibujable
{
    public double Radio { get; set; }

    public Circulo(string nombre, double radio) : base(nombre)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public void Dibujar()
    {
        Console.WriteLine($"Dibujando círculo {Nombre}");
    }
}