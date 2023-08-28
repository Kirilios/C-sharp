/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
*/

Console.Write("Number: ");
int N =Convert.ToInt32(Console.ReadLine());

int ProductOFNumber (int number)
{
    int result = 1; 
    while (number != 0) // for (int = 1; 1 <= N; i++)
    {
        result *= number;
        number--;
    }
    return result;
}
Console.WriteLine(ProductOFNumber(N));