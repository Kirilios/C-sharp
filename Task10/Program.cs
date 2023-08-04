/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Enter your three digit number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 < 100 || number2 >= 1000)
{
    Console.WriteLine("This is not a three digit number");
}
else
{
    int result = number2 /10 % 10;
    Console.WriteLine("Second number is " + result);
}

