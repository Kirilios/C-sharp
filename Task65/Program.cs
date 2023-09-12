/*Задайте значения M и N. Напишите программу, которая выведет все
 натуральные числа в промежутке от M до N.
*/
void NaturarNum(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + ",");
        NaturarNum(m + 1, n);
    }

}
NaturarNum(1,3);