using System;
using System.Collections.Generic;
public class Program
{
    static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
    static void Main()
    {
        int opcion = -1;
        do
        {
            Console.WriteLine(@"SISTEMA DE GESTIÓN DE VEHÍCULOS 
            Ingrese una opción:
            1. Agregar Auto
            2. Agregar Moto
            3. Listar todos los vehículos
            0. Salir");
            switch (opcion)
            {
                case 1:
                    AgregarAuto();
                    break;
                case 2:
                    AgregarMoto();
                    break;
                case 3:
                    ListarVehiculos();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del sistema");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (opcion != 0);
    }
    
}

