using System;

class BinarySearchClass
{
    // Método de Pesquisa Binária
    public static int BinarySearch(int[] array, int value)
    {
        int left = 0, right = array.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Verifica se o valor está presente no meio
            if (array[mid] == value)
                return mid;

            // Se o valor é maior, ignore a metade esquerda
            if (array[mid] < value)
                left = mid + 1;
            // Se o valor é menor, ignore a metade direita
            else
                right = mid - 1;
        }

        // Valor não encontrado
        return -1;
    }

    static void Main()
    {
        int[] array = { 2, 3, 4, 10, 40 };
        int value = 10;
        int result = BinarySearch(array, value);

        if (result == -1)
            Console.WriteLine("Elemento não encontrado.");
        else
            Console.WriteLine("Elemento encontrado no índice: " + result);
    }
}
