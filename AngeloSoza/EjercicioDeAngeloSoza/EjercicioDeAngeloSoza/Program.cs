/*Programa que permite contar cuántas veces aparece un número en un array*/

using System;

class Program
{
    //Función para contar las ocurrencias utilizando divide y vencerás

    public static int ContOcurrencias(int[] arr, int izq, int derecha, int objetivo)
    {

        if (izq == derecha)
        {
            return arr[izq] == objetivo ? 1 : 0;
        }

        int mitad = (izq + derecha) / 2;

        int izqCont = ContOcurrencias(arr, izq, mitad, objetivo);
        int derechaCont = ContOcurrencias(arr, mitad + 1, derecha, objetivo);

        return izqCont + derechaCont;
    }

    static void Main()
    {
        //Solictamos al usuario el tamaño del array
        Console.Write("Cuántos números deseas ingresar?: ");
        int nums = int.Parse(Console.ReadLine());

        //Creamos el array
        int[] arr = new int[nums];
        Console.WriteLine("---------------------------");
        Console.WriteLine("Ingresa los números: ");
        for (int i = 0; i < nums; i++)
        {
            Console.WriteLine();
            Console.Write($"Número # {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        //Solicitamos al usuario el número a buscar
        Console.WriteLine("---------------------------");
        Console.Write("Qué número deseas buscar?: ");
        int objetivo = int.Parse(Console.ReadLine());

        //Llamamos a la función para contar las ocurrencias
        int ocurrencias = ContOcurrencias(arr, 0, arr.Length - 1, objetivo);

        //Mostramos el resultado
        Console.WriteLine($"El número {objetivo} aparece {ocurrencias} veces en el array");
    }
}
