/*07. # Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Enter your number ");
int n =Convert.ToInt32(Console.ReadLine());
if (n  > 99 && n <1000)
{
    Console.WriteLine(n%10);
}
else
{
    Console.WriteLine("There aren't 3 numbers in the number");
}