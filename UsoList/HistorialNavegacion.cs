using System;
using System.Collections.Generic;

public class HistorialNavegacion<T> : IHistorialNavegacion<T>
{
    private readonly List<T> historial = new();
    private int posicionActual = -1;

    public void Visitar(T pagina)
    {
        // Elimina el "futuro" si retrocediste antes de visitar algo nuevo
        if (posicionActual < historial.Count - 1)
        {
            historial.RemoveRange(posicionActual + 1, historial.Count - posicionActual - 1);
        }

        historial.Add(pagina);
        posicionActual++;
    }

    public bool PuedeRetroceder() => posicionActual > 0;

    public void Retroceder()
    {
        if (PuedeRetroceder())
        {
            posicionActual--;
        }
    }

    public bool PuedeAvanzar() => posicionActual < historial.Count - 1;

    public void Avanzar()
    {
        if (PuedeAvanzar())
        {
            posicionActual++;
        }
    }

    public T ObtenerPaginaActual()
    {
        if (posicionActual >= 0 && posicionActual < historial.Count)
            return historial[posicionActual];
        else
            return default!;
    }

    public void Limpiar()
    {
        historial.Clear();
        posicionActual = -1;
    }
}
