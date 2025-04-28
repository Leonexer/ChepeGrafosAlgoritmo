using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeGrafosAlgoritmo
{
    internal class Graphs
    {
        // Diccionario que almacena los vertices y las relaciones entre ellos
        private Dictionary<int, Dictionary<int, int>> adjacencyList;

        // Variable que almacena el numero de nodos o vertices del grafo
        private int count;

        // Constructores de la clase Graphs
        public Graphs(int number)
        {
            adjacencyList = new Dictionary<int, Dictionary<int, int>>();
            AddVertices(number);
        }

        public Graphs()
        {
            adjacencyList = new Dictionary<int, Dictionary<int, int>>();
        }

        // Metodo que agrega un vertice al grafo
        public void AddVertex(int vertex)
        {
            if (adjacencyList.ContainsKey(vertex)) return;

            adjacencyList.Add(vertex, new Dictionary<int, int>());
            count++;
        }

        // Metodo que agrega una serie de vertices al grafo
        public void AddVertices(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (adjacencyList.ContainsKey(i)) continue;
                AddVertex(i);
            }
        }

        // Metodo que agrega una arista al grafo
        public void AddEdge(int origin, int destination, int weight)
        {
            if (ContainsEdge(origin, destination)) return;
            if (weight < 0) return;

            adjacencyList[origin].Add(destination, weight);
        }

        // Metodo que elimina un vertice del grafo
        public void DeleteVertex(int vertex)
        {
            if (!adjacencyList.ContainsKey(vertex)) return;

            for (int i = 0; i < adjacencyList.Count; i++)
            {
                adjacencyList[i].Remove(vertex);
            }

            adjacencyList.Remove(vertex);
        }

        // Metodo que elimina una arista del grafo
        public void DeleteEdge(int origin, int destination)
        {
            if (!ContainsEdge(origin, destination)) return;

            adjacencyList[origin].Remove(destination);
        }

        public void Dijkstra(int startingPoint)
        {
            int[] distance = new int[count];
            bool[] visited = new bool[count];

            for (int i = 0; i < count; i++)
            {
                distance[i] = int.MaxValue;
                visited[i] = false;
            }

            distance[startingPoint] = 0;

            for (int i = 0; i < count - 1; i++) // Repetimos count-1 veces
            {
                // Encontrar el nodo no visitado con la distancia más pequeña
                int u = MinDistance(distance, visited);

                if (u == -1) break; // No hay más nodos alcanzables

                visited[u] = true;

                // Actualizar las distancias de los vecinos de u
                foreach (var vecino in adjacencyList[u])
                {
                    int v = vecino.Key;
                    int peso = vecino.Value;

                    if (!visited[v] && distance[u] != int.MaxValue && distance[u] + peso < distance[v])
                    {
                        distance[v] = distance[u] + peso;
                    }
                }
            }

            // Imprimir resultados
            Console.WriteLine("Nodo\tDistancia");
            for (int i = 0; i < count; i++)
            {
                if (distance[i] == int.MaxValue)
                    Console.WriteLine($"{i}\t∞");
                else
                    Console.WriteLine($"{i}\t{distance[i]}");
            }

        }

        // Función auxiliar para encontrar el nodo no visitado con menor distancia
        private int MinDistance(int[] distance, bool[] visited)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int v = 0; v < count; v++)
            {
                if (!visited[v] && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        // Metodo que imprime la lista de adyacencia del grafo
        public void Print()
        {
            foreach (var node in adjacencyList)
            {
                Console.Write(node.Key + " = { ");
                foreach (var list in adjacencyList[node.Key])
                {
                    Console.Write(list.Key + "");
                }
                Console.WriteLine(" }");
            }
        }

        // Metodo que checa si una arista existe en el grafo
        private bool ContainsEdge(int origin, int destination)
        {
            if (adjacencyList[origin].ContainsKey(destination)) return true;
            return false;
        }
    }
}
