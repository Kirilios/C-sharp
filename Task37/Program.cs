﻿//Произведение пар чисел в массиве. Пара это первый и последний элемент, второй и предпоследний...

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int [] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (start, end);
    }
     return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]},");
    }
    Console.WriteLine("]");
}

int[] ProdOfElements(int[] array)
{
    int[] array1 = new int[(array.Length)/2];
    for (int i = 0; i < array.Length/2; i++)
    {
        array1[i] = array [i]* array[array.Length -i-1];
    }
    return array1;

}

Console.WriteLine("Введите число:");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] UserArray = GetRandomArray(arrayL, min, max);
PrintArray(UserArray);
Console.WriteLine();
int [] newArray = ProdOfElements(UserArray);
PrintArray(newArray);