using System;

class Program
{
    // Método que implementa el algoritmo de búsqueda binaria
    static int BinarySearch(int[] array, int target, int left, int right)
    {
        // Caso base: Si el rango está vacío, el elemento no está en el array
        if (left > right)
        {
            return -1; // No se encontró el elemento
        }

        // Encuentra el índice del elemento medio
        int mid = (left + right) / 2;

        // Si el elemento del medio es el objetivo, retorna su índice
        if (array[mid] == target)
        {
            return mid;
        }
        // Si el elemento objetivo es menor que el elemento del medio,
        // busca en la mitad izquierda
        else if (target < array[mid])
        {
            return BinarySearch(array, target, left, mid - 1);
        }
        // Si el elemento objetivo es mayor, busca en la mitad derecha
        else
        {
            return BinarySearch(array, target, mid + 1, right);
        }
    }

    static void Main(string[] args)
    {
        
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15 };

        
        int target = 7;

       
        int result = BinarySearch(array, target, 0, array.Length - 1);

       
        if (result != -1)
        {
            Console.WriteLine($"El elemento {target} se encuentra en el índice {result}.");
        }
        else
        {
            Console.WriteLine($"El elemento {target} no está en el array.");
        }
    }
}
