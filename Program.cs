/*Mergesort (Ordenamiento)
El Mergesort es un algoritmo clásico que utiliza el paradigma "Divide y Vencerás". Divide la lista en dos mitades, ordena cada mitad y luego combina las dos listas ordenadas. */

using System;

class Program
{
    static void Main()
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        array = MergeSort(array);
        Console.WriteLine(string.Join(", ", array));
    }

    static int[] MergeSort(int[] array)
    {
        if (array.Length <= 1)
            return array;

        int mid = array.Length / 2;
        int[] left = MergeSort(array[..mid]);
        int[] right = MergeSort(array[mid..]);

        return Merge(left, right);
    }

    static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                result[k++] = left[i++];
            else
                result[k++] = right[j++];
        }

        while (i < left.Length)
            result[k++] = left[i++];

        while (j < right.Length)
            result[k++] = right[j++];

        return result;
    }
}

