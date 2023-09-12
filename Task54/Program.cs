/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] Get2DArray(int cols, int rows, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
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

int[,] SortMin(int[,] arrayToSort)
{
    int temp = 0;
    for (int cols = 0; cols < arrayToSort.GetLength(1); cols++)
    {
        for (int rows = 0; rows < arrayToSort.GetLength(0); rows++)
        {
            for (int i = 0; i < arrayToSort.GetLength(0) - 1; i++)
            {
                if (arrayToSort[cols, i] < arrayToSort[cols, i + 1])
                {
                    temp = arrayToSort[cols, i];
                    arrayToSort[cols, i] = arrayToSort[cols, i + 1];
                    arrayToSort[cols, i + 1] = temp;

                }
            }
        }
    }
    return arrayToSort;
}
int[,] originalArray = Get2DArray(6, 6, 0, 10);
Print2DArray(originalArray);
Console.WriteLine();
Print2DArray(SortMin(originalArray));