﻿/*программа, которая принимает на вход число N и выдает таблицу кубов числе от 1 до N
*/

Console.WriteLine("enter your number");
int numberN = Convert.ToInt32(Console.ReadLine()); 
double result = 0;
if (numberN < 0)
{
    numberN = numberN * (-1);
}
for (int i = 1; i < numberN; i++)
{
    result = Math.Pow(i,3); //i * i
    Console.WriteLine(result);
}