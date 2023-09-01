/* Задайте массивю Напиши прогрмамму, которая определяет, присутствует ли заданное число в массиве*/

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int [] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (start, end);
    }
     return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]},");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите число:");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int number = Convert.ToInt32(Console.ReadLine());

int[] UserArray = GetRandomArray(arrayL, min, max);
PrintArray(UserArray);
bool FindUserNumber(int[] array, int number)
{
    bool number1 = false;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array [i] == number)
        Console.WriteLine(true);
    }
    return number1;
}

FindUserNumber(UserArray, number);
bool number1 = FindUserNumber(UserArray, number);
Console.WriteLine();
Console.WriteLine($"число {(number1)} присутствует");