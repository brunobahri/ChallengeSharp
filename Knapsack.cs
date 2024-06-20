using System;

class Knapsack
{
    // Método para resolver o Problema da Mochila
    public static int KnapsackProblem(int[] weights, int[] values, int capacity)
    {
        int n = weights.Length;
        int[,] dp = new int[n + 1, capacity + 1];

        for (int i = 0; i <= n; i++)
        {
            for (int w = 0; w <= capacity; w++)
            {
                if (i == 0 || w == 0)
                    dp[i, w] = 0;
                else if (weights[i - 1] <= w)
                    dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                else
                    dp[i, w] = dp[i - 1, w];
            }
        }

        return dp[n, capacity];
    }

    static void Main()
    {
        int[] weights = { 10, 20, 30 };
        int[] values = { 60, 100, 120 };
        int capacity = 50;

        int result = KnapsackProblem(weights, values, capacity);
        Console.WriteLine("Valor máximo na mochila: " + result);
    }
}
