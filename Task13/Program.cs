/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Enter your number ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 0;
int temp = number;
while (number > 1)
{
    number = number / 10;
    counter++;
}
for (int i = 0; i < counter - 3; i++)
{
    temp = temp / 10;
}
int ThirdNumber = temp % 10;
if (temp < 100)
{
    Console.WriteLine("third number doesn't exist");
}
else
{
    Console.WriteLine($"Third number is {ThirdNumber}");
}



/*
if (number > 100)
{
    int ThirdNumber = number % 10;
    Console.WriteLine($"Third number is {ThirdNumber}");
}
*/
/*
if (number < 100)
{
    Console.WriteLine("third number doesn't exist");
}
*/
