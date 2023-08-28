/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
*/
Console.Write("Number: ");
int UserNumber =Convert.ToInt32(Console.ReadLine());

int Quantity(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number/=10;
    }
    return count;
}
Console.WriteLine(Quantity(UserNumber));