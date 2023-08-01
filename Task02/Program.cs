/*
 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/

Console.WriteLine("Enter your numbers ");
int n1 =Convert.ToInt32(Console.ReadLine());
int n2 =Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine($"большее число {n1}, меньшее число {n2}");
}
else if (n1 == n2)
{
    Console.WriteLine($"числа {n2} и {n1} равны");
}
else if (n1 < n2)
{
    Console.WriteLine($"большее число {n2}, меньшее число {n1}");
}