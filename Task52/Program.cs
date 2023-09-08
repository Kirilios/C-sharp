/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.Clear();

int[,] Get2DArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
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
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void AverageArithmetic(int[,] arrayToSum)
{
    double sum = 0;
    for (int col = 0; col < arrayToSum.GetLength(1); col++)
    {
        for (int row = 0; row < arrayToSum.GetLength(0); row++)
        {
            sum += arrayToSum[row, col];
        }
        Console.WriteLine();
        Console.Write($"{Math.Round(sum / arrayToSum.GetLength(0), 2)}\t");
        sum = 0;
    }
}

int[,] array = Get2DArray(4, 4, 1, 10);
Print2DArray(array);
AverageArithmetic(array);