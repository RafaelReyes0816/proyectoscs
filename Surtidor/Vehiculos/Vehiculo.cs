namespace Vehiculos
{
    // Enumeración para los tipos de combustible y vehículos
    public enum TipoCombustible { Gasolina, Diesel }
    public enum TipoVehiculo { Moto, Auto, Camion }


    // Representa un vehículo con su tipo, combustible y cantidad actual
    public class Vehiculo
    {
        public TipoVehiculo Tipo { get; set; }
        public TipoCombustible Combustible { get; set; }
        public int CombustibleActual { get; set; }

        // Capacidad máxima del tanque según el tipo de vehículo
        public int CapacidadTanque
        {
            get
            {
                return Tipo switch
                {
                    TipoVehiculo.Moto => 10,
                    TipoVehiculo.Auto => 50,
                    TipoVehiculo.Camion => 120,
                    _ => 0
                };
            }
        }

        public Vehiculo(TipoVehiculo tipo, TipoCombustible combustible, int combustibleActual)
        {
            Tipo = tipo;
            Combustible = combustible;
            CombustibleActual = combustibleActual;
        }
    }
}