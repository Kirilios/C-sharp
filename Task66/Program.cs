﻿/*Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов 
 в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int NaturalSum(int m, int n)
{
    if (m == n) return n;
    return m + NaturalSum(m + 1, n);
}
Console.Write(NaturalSum(1,15));
