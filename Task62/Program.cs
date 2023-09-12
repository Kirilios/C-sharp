//Задача 62. Заполнить спиральный массив 4 на 4
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
int[,] FillSpirally2DArray(int[,] array)
{
    int value = 1;
    // создадим границы, которые будем сужать
    int left = 0, right = array.GetLength(1) - 1, top = 0, bottom = array.GetLength(0) - 1;

    while (left <= right && top <= bottom)
    {
        // Заполнение верхней строки
        for (int i = left; i <= right; i++)
            array[top, i] = value++;
        // Заполнение правого столбца
        for (int j = top + 1; j <= bottom; j++)
            array[j, right] = value++;
        // Заполнение нижней строки
        if (top < bottom)
        {
            for (int i = right - 1; i >= left; i--)
                array[bottom, i] = value++;
        }
        // Заполнение левого столбца
        if (left < right)
        {
            for (int i = bottom - 1; i > top; i--)
                array[i, left] = value++;
        }

        left++;
        right--;
        top++;
        bottom--;
    }

    return array;
}

int[,] userArray = Get2DArray(4,4,1,10);
FillSpirally2DArray(userArray);
Print2DArray(userArray);