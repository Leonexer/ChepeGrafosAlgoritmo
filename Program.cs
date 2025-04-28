using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeGrafosAlgoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia del grafo
            Graphs grafo = new Graphs();
            int opcion = -1;

            // Menú principal
            do
            {
                // Mostrar las opciones disponibles
                Console.WriteLine("\n*** Menú de Opciones ***");
                Console.WriteLine("1. Agregar vértice");
                Console.WriteLine("2. Agregar arista");
                Console.WriteLine("3. Eliminar vértice");
                Console.WriteLine("4. Eliminar arista");
                Console.WriteLine("5. Imprimir grafo");
                Console.WriteLine("6. Ejecutar Dijkstra");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");

                // Leer opción del usuario
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue;
                }

                // Ejecutar acción dependiendo de la opción
                switch (opcion)
                {
                    case 1: // Agregar un vértice
                        Console.Write("Introduce el número del vértice: ");
                        int vertice = int.Parse(Console.ReadLine());
                        grafo.AddVertex(vertice);
                        Console.WriteLine($"Vértice {vertice} agregado.");
                        break;

                    case 2: // Agregar una arista
                        Console.Write("Introduce el origen: ");
                        int origen = int.Parse(Console.ReadLine());
                        Console.Write("Introduce el destino: ");
                        int destino = int.Parse(Console.ReadLine());
                        Console.Write("Introduce el peso de la arista: ");
                        int peso = int.Parse(Console.ReadLine());
                        grafo.AddEdge(origen, destino, peso);
                        Console.WriteLine($"Arista de {origen} a {destino} agregada con peso {peso}.");
                        break;

                    case 3: // Eliminar un vértice
                        Console.Write("Introduce el vértice a eliminar: ");
                        int verticeEliminar = int.Parse(Console.ReadLine());
                        grafo.DeleteVertex(verticeEliminar);
                        Console.WriteLine($"Vértice {verticeEliminar} eliminado.");
                        break;

                    case 4: // Eliminar una arista
                        Console.Write("Introduce el origen de la arista a eliminar: ");
                        int origenEliminar = int.Parse(Console.ReadLine());
                        Console.Write("Introduce el destino de la arista a eliminar: ");
                        int destinoEliminar = int.Parse(Console.ReadLine());
                        grafo.DeleteEdge(origenEliminar, destinoEliminar);
                        Console.WriteLine($"Arista de {origenEliminar} a {destinoEliminar} eliminada.");
                        break;

                    case 5: // Imprimir el grafo
                        Console.WriteLine("\nLista de adyacencia del grafo:");
                        grafo.Print();
                        break;

                    case 6: // Ejecutar algoritmo de Dijkstra
                        Console.Write("Introduce el nodo de inicio para Dijkstra: ");
                        int inicio = int.Parse(Console.ReadLine());
                        grafo.Dijkstra(inicio);
                        break;

                    case 0: // Salir
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default: // Opción inválida
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }
            } while (opcion != 0); // Repetir hasta que el usuario elija salir
        }
    }
}
