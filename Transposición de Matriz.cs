// Nombre del estudiante: Nombre Completo
// Grupo: Grupo #
// Programa: Transposición de Matriz
// Código Fuente: autoría propia

using System;

class Program
{
    static void Main()
    {
        // Captura de dimensiones de la matriz
        Console.Write("Ingrese el número de filas: ");
        int filas = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el número de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        // Arreglos para la matriz original y la transpuesta
        int[,] matriz = new int[filas, columnas];
        int[,] matrizTranspuesta = new int[columnas, filas];

        // Captura de elementos de la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Ingrese el elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Cálculo de la matriz transpuesta
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matrizTranspuesta[j, i] = matriz[i, j];
            }
        }

        // Mostrar matriz transpuesta
        Console.WriteLine("Matriz transpuesta:");
        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < filas; j++)
            {
                Console.Write(matrizTranspuesta[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
