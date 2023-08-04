/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter your number ");
int number =Convert.ToInt32(Console.ReadLine());
if (number > 7)
{
    Console.WriteLine("invalid number");
}
if (number <= 5 && number >= 1 )
{
    Console.WriteLine("Weekday");
}
if (number > 5)
{
    Console.WriteLine("it's a weekend");
}