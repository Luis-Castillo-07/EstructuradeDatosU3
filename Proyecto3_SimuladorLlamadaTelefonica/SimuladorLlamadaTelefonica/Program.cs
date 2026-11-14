using System;
namespace SimuladorLlamadaTelefonica
{
    internal class Program
    {
        static Pila llamdas = new Pila();
        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== Simulador de Llamadas Telefónicas =====");
                Console.WriteLine("1. Registrar llamada");
                Console.WriteLine("2. Atender llamada");
                Console.WriteLine("3. Mostrar historial");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                    Console.Write("Nombre o número de la llamada: ");
                    string llamada = Console.ReadLine();

                    llamdas.Apilar(llamada);
                    Console.WriteLine("Llamada registrada");
                    break;

                    case 2:
                    string atendida = llamdas.Desapilar();
                    if (atendida == null)
                    Console.WriteLine("No hay llamadas pendientes");
                    else
                    Console.WriteLine($"Llamada atendida: {atendida}");
                    break;

                    case 3:
                
                    Console.WriteLine("\nLlamadas pendientes:");
                    llamdas.Mostrar();
                    break;

                    case 4:
                    Console.WriteLine("Saliendo del simulador...");
                    break;

                    default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 4);
        }
    }
}