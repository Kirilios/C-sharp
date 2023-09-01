/*задайте одномерный массив из 123 случайных чисел.
Найдите кол-во элементов массива, знаачения которыe лежат в отрезке 10-99*/

/*int[] GetRandomArray(int arrayLength1, int start, int end)
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

int QuantityOfNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] >=10 && array [i] <= 99)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите число:");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] UserArray = GetRandomArray(arrayL, min, max);
PrintArray(UserArray);
int quant = QuantityOfNumbers(UserArray);
Console.WriteLine("" + quant);*/

/*34.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();
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

int EvenNumbers(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] %2 == 0)
        quantity++;
    }
    return quantity;
}
Console.WriteLine("Введите число:");
int arrayL = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandomArray(arrayL, start: 100, end: 999);
PrintArray(userArray);

Console.WriteLine(EvenNumbers(userArray));