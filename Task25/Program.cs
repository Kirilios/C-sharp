/*Цикл, который на вход принимает два числа (a,b) и возводит число A в натуральную степень B
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Enter A and B: ");
int A =Convert.ToInt32(Console.ReadLine()); 
int B =Convert.ToInt32(Console.ReadLine()); 
int DoubleResult = 1;
for (int i = 0; i < B; i++)
{
    DoubleResult *= A;
}
Console.WriteLine($"{A} в степени {B} = {DoubleResult}");