// Clase base abstracta para todas las figuras geométricas
public abstract class Figura
{
    public string Nombre { get; set; }

    public Figura(string nombre)
    {
        Nombre = nombre;
    }

    // Método que cada figura debe implementar
    public abstract double CalcularArea();
}