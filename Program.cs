using System;
using System.Collections.Generic;
using FlotaVehicular.Models;

class Program
{
    static void Main(string[] args)
    {
        Vehiculo auto = new Automovil(litrosCombustible: 50, numeroPuertas: 4);
        Vehiculo camion = new Camion(litrosCombustible: 50, capacidadCargaTon: 10);
        List<Vehiculo> flota = new List<Vehiculo> { auto, camion };
        Console.WriteLine("=== CÁLCULO DE AUTONOMÍA DE FLOTA VEHICULAR ===");

        foreach (Vehiculo v in flota)
        {
            double autonomia = v.CalcularAutonomiaKm();

            Console.WriteLine($"Vehículo tipo [{v.GetType().Name}] con {v.LitrosCombustible}L de combustible.");
            Console.WriteLine($"-> Autonomía estimada: {autonomia:F2} Km\n");
        }
    }
}