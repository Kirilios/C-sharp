/*Задайте значение N.
 Напишите программу, которая выведет все
  натуральные числа в промежутке от 1 до N.*/

void NaturarNum(int n, int start = 1)
{
    if (start <= n)
    {
        Console.Write(start + ",");
        NaturarNum(n, start + 1);
    }

}
NaturarNum(5);