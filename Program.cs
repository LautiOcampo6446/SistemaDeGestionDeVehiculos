using System;
using System.Collections.Generic;
public class Program
{
    static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
    static void Main()
    {
        int opcion;
        do
        {   //lo hago asi porque no me gusta como se ve en consola
            Console.WriteLine(@"SISTEMA DE GESTIÓN DE VEHÍCULOS
Ingrese una opción:
1. Agregar Auto
2. Agregar Moto
3. Mostrar los vehículos
4. Probar vehículos
0. Salir");  
            opcion = int.Parse(Console.ReadLine()!);
            
            switch (opcion)
            {
            case 1:
                    AgregarAuto(); 
                break;
            case 2:
                    AgregarMoto(); 
                break;
            case 3:
                    MostrarVehiculos(); 
                break;
            case 4:
                    ProbarVehiculos(); 
                break;
            case 0: 
                    Console.WriteLine("Saliendo..."); break;
            default:
                    Console.WriteLine("Opción no válida"); 
                break;
            }
                } while (opcion != 0);
        }
            static void AgregarAuto()
            {
                Console.Write("Ingrese marca: ");
                string marca = Console.ReadLine()!;
                Console.Write("Ingrese modelo: ");
                string modelo = Console.ReadLine()!;
                Auto auto = new Auto { Marca = marca, Modelo = modelo, VelocidadActual = 0 }; 

                listaVehiculos.Add(auto);
                Console.WriteLine("Auto añadido!");
            }
            static void AgregarMoto()
            {
                Console.Write("Ingrese marca: ");
                string marca = Console.ReadLine()!;
                Console.Write("Ingrese modelo: ");
                string modelo = Console.ReadLine()!;

                Moto moto = new Moto { Marca = marca, Modelo = modelo, VelocidadActual = 0 }; 
                listaVehiculos.Add(moto);
                Console.WriteLine("Moto añadida!");
            }
            static void MostrarVehiculos()
            {
                Console.WriteLine("===== SISTEMA DE VEHÍCULOS =====");
                if (listaVehiculos.Count == 0)
                {
                    Console.WriteLine("La lista está vacía");
                    return;
                }

                foreach (Vehiculo v in listaVehiculos)
                {
                    Console.WriteLine("Vehículo: " + v.Marca + " " + v.Modelo);
                    Console.WriteLine("Velocidad actual: " + v.VelocidadActual + " km/h");
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------");
                }
            }
            static void ProbarVehiculos()
            {
                foreach (Vehiculo v in listaVehiculos)
                {                       
                    Console.WriteLine("Vehículo: " + v.Marca + " " + v.Modelo);
                    Console.WriteLine("Velocidad actual: " + v.VelocidadActual + " km/h");
                    Console.WriteLine(""); 
        
                    v.Acelerar();
                    Console.WriteLine("Acelerando..");
                    Console.WriteLine("Velocidad actual: " + v.VelocidadActual + " km/h");
                    Console.WriteLine("");
        
                    v.Frenar();
                    Console.WriteLine("Frenando..");
                    Console.WriteLine("Velocidad actual: " + v.VelocidadActual + " km/h");
        
                    Console.WriteLine("----------------------------------------------");
                }
    }
}

