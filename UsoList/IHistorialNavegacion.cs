public interface IHistorialNavegacion<T>
{
    void Visitar(T pagina);
    bool PuedeRetroceder();
    void Retroceder();
    bool PuedeAvanzar();
    void Avanzar();
    T ObtenerPaginaActual();
    void Limpiar();
}
