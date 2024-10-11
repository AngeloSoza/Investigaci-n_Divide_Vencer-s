namespace divide_y_venceras
{
    // suma de arreglos
    using System;

    class DivideYVenceras
    {

        // Calcula la suma de un arreglo dividiendo el problema en subproblemas
        public static int SumArray(int[] array, int left, int right)
        {
            if (left == right)
                return array[left];

            // Si no son iguales, entonces calculamos el punto medio
            // ejemplo: si left = 0 y right = 4, entonces mid = 2
            int mid = (left + right) / 2;

            // Estas dos lineas dividen el problema en dos subproblemas
            // y calculan la suma de cada subproblema
            int leftSum = SumArray(array, left, mid);
            int rightSum = SumArray(array, mid + 1, right);

            // Finalmente, sumamos las dos sumas y retornamos el valor
            return leftSum + rightSum;
        }

        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            // Llamamos a la funcion SumArray con el arreglo y los indices
            int totalSum = SumArray(array, 0, array.Length - 1);

            Console.WriteLine("La suma total es: " + totalSum);
        }
    }
}
