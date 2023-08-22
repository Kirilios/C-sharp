/*5значное число, является ли оно палидроном
14212 - нет, 24342 - да */

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Введенное число не является пятизначным.");
}
int temp = number;
if (temp % 10 != temp / 10000 && temp % 100 != temp % 1000)
{
    Console.WriteLine("не палиндром");
}
else
{
    Console.WriteLine("это палидром");
}