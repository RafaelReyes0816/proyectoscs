using System.Collections.Generic;
using Vehiculos;

namespace Gestores
{
    // Administra las colas de vehículos para cada tipo de combustible
    public class GestorCola
    {
        public Queue<Vehiculo> ColaGasolina = new Queue<Vehiculo>();
        public Queue<Vehiculo> ColaDiesel = new Queue<Vehiculo>();
        public int MaxCola = 5;

        // Agrega un vehículo a la cola correspondiente si hay espacio
        public bool AgregarVehiculo(Vehiculo v)
        {
            if (v.Combustible == TipoCombustible.Gasolina && ColaGasolina.Count < MaxCola)
            {
                ColaGasolina.Enqueue(v);
                return true;
            }
            else if (v.Combustible == TipoCombustible.Diesel && ColaDiesel.Count < MaxCola)
            {
                ColaDiesel.Enqueue(v);
                return true;
            }
            return false;
        }
    }
}