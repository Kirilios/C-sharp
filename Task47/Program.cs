/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GetRandom2DArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (minValue - maxValue) + minValue;
        }
    }
    return result;
}

void Print2DArray(double[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t"); //t - табуляция
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(arrayToPrint[i, j], 1) + "\t");
        }
        System.Console.WriteLine();
    }
}

double[,] array = GetRandom2DArray(3, 4, 3, 7);
Print2DArray(array);
