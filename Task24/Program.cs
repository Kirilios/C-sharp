/*Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
*/
Console.WriteLine("number: ");
int UserNumber =Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= UserNumber; i++)
{
    sum += i;
}

Console.WriteLine(sum);


int SumOfNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= UserNumber; i++)
    {
    sum += i;
    }
    return sum;
}

Console.WriteLine($"сумма цифр в числе {UserNumber} равна {SumOfNumber(UserNumber)}");