/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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
int[] SumRowsIn2DArray(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows[i] += array[i, j];
        }
    }

    return sumRows;
}
void PrintSmallestElement(int[] array)
{
    int smallestSum = array[0];
    int rowFrom2DArray = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (smallestSum > array[i])
        {
            smallestSum = array[i];
            rowFrom2DArray = i;
        }
    }

    Console.WriteLine($"Наименьшая сумма элементов будет в {rowFrom2DArray} строке и она равна {smallestSum}");
}
/*void FindStringMinSum(int[,] array)
{
    int minSum = array[0,0]; // Инициализируем переменную минимальной суммы значением первого элемента массива
    int index = 0; // Инициализируем переменную индекса значением 0
    for (int i = 0; i < array.GetLength(0); i++)
    { // Цикл по строкам массива
        int currentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        { // Вложенный цикл по элементам строки
            currentSum += array[i, j]; // Находим текущую сумму элементов строки
        }
        if (currentSum < minSum)
        { // Если сумма элементов меньше минимальной
            minSum = currentSum; // Обновляем значение минимальной суммы
            index = i; // Обновляем индекс строки с минимальной суммой
        }
    }
    Console.WriteLine("Строка с минимальной суммой: " + index);
}  */

int[,] userArray = Get2DArray(3, 4, 0, 7);
Print2DArray(userArray);
int [] userArrayOriginal =SumRowsIn2DArray(Get2DArray(3, 4, 0, 7));
PrintSmallestElement(SumRowsIn2DArray(userArray));
  /*  string result = String.Empty;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            result = $"{i} - строка";
        }
    }
    return result;
}

int[,] userArray = Get2DArray(4, 5, 0, 10);
Print2DArray(FindStringMinSum(userArray));*/

/*int[] SumRowsIn2DArray(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows[i] += array[i, j];
        }
    }

    return sumRows;
}

/*void PrintSmallestElement(int[] array)
{
    int smallestSum = array[0];
    int rowFrom2DArray = 0; // Номер элементна будет соответствовать строке в двумерном массиве.

    for (int i = 1; i < array.Length; i++)
    {
        if (smallestSum > array[i])
        {
            smallestSum = array[i];
            rowFrom2DArray = i;
        }
    }

    Console.WriteLine($"Наименьшая сумма элементов будет в {rowFrom2DArray} строке и она равна {smallestSum}");
}
*/