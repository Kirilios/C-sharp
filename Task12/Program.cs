/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число некратно первому, то программа выводит 
остаток от деления
*/

Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;

if (result == 0)
{
    Console.WriteLine("2 число кратно первому");
}
else
{
    Console.WriteLine($" остаток от деления: {result}");
}
