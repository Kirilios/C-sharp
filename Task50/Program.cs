/*Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента
  или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();

int[,] Get2DArray(int cols, int rows, int min, int max)
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

void PrintElementFrom2DArray(int[,] array)
{
    Console.WriteLine("Позиция первого элемента: ");
    Console.Write("Строка: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столб: ");
    int col = Convert.ToInt32(Console.ReadLine());

    if (line < array.GetLength(0)
    && col < array.GetLength(1)) Console.WriteLine(array[line, col]);
    else Console.WriteLine("Такого элемента нет");
}
void PrintNumberFrom2DArray(int[,] array2DForFindNumber)
{
    Console.Write("Введи искомое число: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    bool checkNumber = true;

    for (int i = 0; i < array2DForFindNumber.GetLength(0); i++)
    {
        for (int j = 0; j < array2DForFindNumber.GetLength(1); j++)
        {
            if (array2DForFindNumber[i, j] == userNumber)
            {
                Console.WriteLine($"Число {userNumber} находится на {i} строке, {j} столбце");
                checkNumber = false;
            }
        }

    }

    if (checkNumber) Console.WriteLine($"Числа {userNumber} нет в массиве");
}
int[,] userArray = Get2DArray(3,4,0,10);
Print2DArray(userArray);
PrintElementFrom2DArray(userArray);
PrintNumberFrom2DArray(userArray);
