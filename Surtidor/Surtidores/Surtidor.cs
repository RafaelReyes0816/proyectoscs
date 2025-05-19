using Vehiculos;

namespace Surtidores
{
    public class Surtidor
    {
        public int GasolinaDisponible { get; set; } = 500;
        public int DieselDisponible { get; set; } = 700;

        public bool PuedeCargar(Vehiculo v)
        {
            int cantidadNecesaria = v.CapacidadTanque - v.CombustibleActual;
            if (v.Combustible == TipoCombustible.Gasolina)
                return GasolinaDisponible >= cantidadNecesaria;
            else
                return DieselDisponible >= cantidadNecesaria;
        }

        public void CargarCombustible(Vehiculo v)
        {
            int cantidad = v.CapacidadTanque - v.CombustibleActual;
            if (cantidad > 0)
            {
                if (v.Combustible == TipoCombustible.Gasolina)
                    GasolinaDisponible -= cantidad;
                else
                    DieselDisponible -= cantidad;

                v.CombustibleActual += cantidad;
            }
        }
    }
}