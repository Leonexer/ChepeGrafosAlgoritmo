# Proyecto: Grafo dirigido ponderado + Algoritmo de Dijkstra en C#

## Descripción

Este proyecto consiste en la implementación de una estructura de *grafo dirigido* donde cada arista tiene un peso asociado, utilizando *listas de adyacencia* en C#.  
También se implementa el *algoritmo de Dijkstra* para encontrar la ruta más corta desde un vértice inicial a los demás nodos.

Además, se desarrolló un *menú interactivo de consola* para facilitar la manipulación del grafo.

---

## Contenido del Proyecto

- *Clase Graphs*: 
  - Agrega/elimina vértices.
  - Agrega/elimina aristas con pesos.
  - Implementa Dijkstra para encontrar caminos mínimos.
  - Imprime la representación del grafo.

- *Clase Program*:
  - Proporciona un menú interactivo de consola para:
    - Agregar vértices.
    - Agregar aristas.
    - Eliminar vértices o aristas.
    - Imprimir la lista de adyacencia.
    - Ejecutar Dijkstra.
    - Salir del programa.

---

## Funcionalidades principales

-  Agregar vértices individualmente.
-  Agregar aristas entre nodos con peso.
-  Eliminar vértices (y todas sus conexiones).
-  Eliminar aristas específicas.
-  Visualizar el grafo actual.
-  Calcular caminos mínimos usando Dijkstra.
-  Menú interactivo simple y claro.

---

## Cómo ejecutar el programa

1. Crea un nuevo proyecto de consola en C# (.NET).
2. Copia y pega el contenido de las clases Graphs y Program.
3. Compila el proyecto.
4. Ejecuta la aplicación.
5. Usa el menú para interactuar con el grafo.

---

## Ejemplo de Ejecución

```text
* Menú de Opciones *
1. Agregar vértice
2. Agregar arista
3. Eliminar vértice
4. Eliminar arista
5. Imprimir grafo
6. Ejecutar Dijkstra
0. Salir
Selecciona una opción: 1
Introduce el número del vértice: 0
Vértice 0 agregado.

Selecciona una opción: 2
Introduce el origen: 0
Introduce el destino: 1
Introduce el peso de la arista: 4
Arista agregada de 0 a 1 con peso 4.

Selecciona una opción: 5
0 = { 1 }
1 = { }

Selecciona una opción: 6
Introduce el nodo de inicio para Dijkstra: 0
Nodo    Distancia
0       0
1       4
