﻿/*Напишите программу, которая принимает на вход три числа
 и проверяет, может ли существовать треугольник с сторонами такой длины.*/
Console.Clear();
Console.Write("Длины");

int[] FillUserArray()
{
    int[] array = new int[3];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

bool TriangleExistance(int[] array)
{
    if (array[0] < array[1] + array[2]
    && array[1] < array[0] + array[2]
    && array[2] < array[0] + array[1])
    {
        return true;
    }
    else
        return false;
}
int[] userArray = FillUserArray();
bool result = TriangleExistance(userArray);
Console.Write(result);
