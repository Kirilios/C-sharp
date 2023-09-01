/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int [] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (start, end); //result[i] = new Random().NextDouble() * 100;
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

int SumOddNumbers(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++) //+2
    {
        if (i%2 == 0)
        sumOdd = sumOdd + array [i];
    }
    return sumOdd;
}

Console.WriteLine("Введите число:");
int arrayL = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandomArray(arrayL, start:0, end:999);
PrintArray(userArray);

Console.WriteLine(SumOddNumbers(userArray));