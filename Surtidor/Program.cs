using System;
using Vehiculos;
using Surtidores;
using Gestores;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Surtidor surtidor = new Surtidor();
        GestorCola gestor = new GestorCola();
        bool salir = false;

        // ====== Bucle principal del menú ======
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("      SISTEMA DE SURTIDOR DE COLAS     ");
            Console.WriteLine("=======================================");
            Console.WriteLine("1. Agregar vehículo a la cola");
            Console.WriteLine("2. Atender colas y cargar combustible");
            Console.WriteLine("3. Ver estado del surtidor");
            Console.WriteLine("4. Ver combustible de vehículos en cola");
            Console.WriteLine("5. Salir");
            Console.WriteLine("=======================================");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarVehiculoMenu(gestor);
                    break;
                case "2":
                    AtenderColas(gestor, surtidor);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("------ Estado del surtidor ------");
                    Console.WriteLine($"Gasolina disponible: {surtidor.GasolinaDisponible} litros");
                    Console.WriteLine($"Diesel disponible: {surtidor.DieselDisponible} litros");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "4":
                    MostrarCombustibleVehiculos(gestor);
                    break;
                case "5":
                    Console.WriteLine("Saliendo del sistema. ¡Hasta luego!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // ====== Menú para agregar vehículo con validaciones y restricciones ======
    static void AgregarVehiculoMenu(GestorCola gestor)
    {
        Console.Clear();
        Console.WriteLine("------ Agregar Vehículo ------");

        // Validar tipo de vehículo
        int tipo = 0;
        while (tipo < 1 || tipo > 3)
        {
            Console.WriteLine("Tipo de vehículo: 1. Moto  2. Auto  3. Camion");
            string inputTipo = Console.ReadLine();
            if (!int.TryParse(inputTipo, out tipo) || tipo < 1 || tipo > 3)
            {
                Console.WriteLine("Ingrese una opción válida (1, 2 o 3).");
            }
        }
        TipoVehiculo tipoVehiculo = tipo switch
        {
            1 => TipoVehiculo.Moto,
            2 => TipoVehiculo.Auto,
            3 => TipoVehiculo.Camion,
            _ => TipoVehiculo.Moto
        };

        // --- Restricción de tipo de combustible según vehículo ---
        TipoCombustible tipoCombustible = TipoCombustible.Gasolina;
        if (tipoVehiculo == TipoVehiculo.Camion)
        {
            tipoCombustible = TipoCombustible.Diesel;
            Console.WriteLine("El camión solo puede cargar Diesel.");
        }
        else
        {
            tipoCombustible = TipoCombustible.Gasolina;
            Console.WriteLine("Las motos y autos solo pueden cargar Gasolina.");
        }

        // --- Asignar cantidad de combustible aleatoria y permitir modificarla ---
        int capacidad = tipoVehiculo switch
        {
            TipoVehiculo.Moto => 10,
            TipoVehiculo.Auto => 50,
            TipoVehiculo.Camion => 120,
            _ => 10
        };
        int aleatorio = random.Next(0, capacidad);
        int espacioDisponible = capacidad - aleatorio;
        Console.WriteLine($"Usted tiene {aleatorio} litros en el tanque de {capacidad}.");
        Console.WriteLine($"Faltan {espacioDisponible} litros para llenar el tanque.");
        Console.Write("¿Desea llenar el tanque con el resto? (S/N): ");
        string resp = Console.ReadLine()?.Trim().ToUpper();
        int actual = aleatorio;
        if (resp != "S")
        {
            int litrosACargar = -1;
            while (litrosACargar < 0 || litrosACargar > espacioDisponible)
            {
                Console.Write($"¿Cuántos litros desea cargar? (0 a {espacioDisponible}): ");
                string inputCarga = Console.ReadLine();
                if (!int.TryParse(inputCarga, out litrosACargar) || litrosACargar < 0 || litrosACargar > espacioDisponible)
                {
                    Console.WriteLine("Ingrese un número válido dentro del rango.");
                    litrosACargar = -1;
                }
            }
            // NO sumes aquí, solo informa lo que va a pasar
            Console.WriteLine($"El tanque tendrá {aleatorio + litrosACargar} litros después de cargar.");
            // El vehículo entra a la cola con el litraje ACTUAL, no sumado
        }
        else
        {
            Console.WriteLine($"El tanque se llenará con {espacioDisponible} litros al atender la cola.");
        }

        // --- Intentar agregar el vehículo a la cola ---
        bool agregado = gestor.AgregarVehiculo(new Vehiculo(tipoVehiculo, tipoCombustible, actual));
        if (agregado)
            Console.WriteLine("Vehículo agregado a la cola correctamente.");
        else
            Console.WriteLine("La cola para ese tipo de combustible está llena.");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }

    // ====== Atender colas y cargar combustible ======
    static void AtenderColas(GestorCola gestor, Surtidor surtidor)
    {
        Console.Clear();
        Console.WriteLine("------ Atendiendo colas ------");
        bool atendio = false;

        // --- Atender la cola de gasolina ---
        while (gestor.ColaGasolina.Count > 0)
        {
            var vehiculo = gestor.ColaGasolina.Peek();
            if (surtidor.PuedeCargar(vehiculo))
            {
                surtidor.CargarCombustible(vehiculo);
                Console.WriteLine($"Vehículo {vehiculo.Tipo} cargado con gasolina. Gasolina restante: {surtidor.GasolinaDisponible} litros.");
                gestor.ColaGasolina.Dequeue();
                atendio = true;
            }
            else
            {
                Console.WriteLine("No hay suficiente gasolina para cargar el siguiente vehículo.");
                break;
            }
        }

        // --- Atender la cola de diesel ---
        while (gestor.ColaDiesel.Count > 0)
        {
            var vehiculo = gestor.ColaDiesel.Peek();
            if (surtidor.PuedeCargar(vehiculo))
            {
                surtidor.CargarCombustible(vehiculo);
                Console.WriteLine($"Vehículo {vehiculo.Tipo} cargado con diesel. Diesel restante: {surtidor.DieselDisponible} litros.");
                gestor.ColaDiesel.Dequeue();
                atendio = true;
            }
            else
            {
                Console.WriteLine("No hay suficiente diesel para cargar el siguiente vehículo.");
                break;
            }
        }

        if (!atendio)
            Console.WriteLine("No hay vehículos en las colas o no hay suficiente combustible para atenderlos.");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Combustible disponible - Gasolina: {surtidor.GasolinaDisponible} litros, Diesel: {surtidor.DieselDisponible} litros.");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }

    // ====== Mostrar combustible de vehículos en cola ======
    static void MostrarCombustibleVehiculos(GestorCola gestor)
    {
        Console.Clear();
        Console.WriteLine("------ Combustible de vehículos en cola ------");
        if (gestor.ColaGasolina.Count == 0 && gestor.ColaDiesel.Count == 0)
        {
            Console.WriteLine("No hay vehículos en las colas.");
        }
        else
        {
            if (gestor.ColaGasolina.Count > 0)
            {
                Console.WriteLine("Cola Gasolina:");
                foreach (var v in gestor.ColaGasolina)
                {
                    Console.WriteLine($"- {v.Tipo}: {v.CombustibleActual} / {v.CapacidadTanque} litros");
                }
            }
            if (gestor.ColaDiesel.Count > 0)
            {
                Console.WriteLine("Cola Diesel:");
                foreach (var v in gestor.ColaDiesel)
                {
                    Console.WriteLine($"- {v.Tipo}: {v.CombustibleActual} / {v.CapacidadTanque} litros");
                }
            }
        }
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}