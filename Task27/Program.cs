/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int numberSum = 0;
while (number > 0)
{
    int digit = number % 10;
    numberSum += digit;
    number /= 10;
}
Console.WriteLine($"Сумма цифр в числе {num}: {numberSum}");