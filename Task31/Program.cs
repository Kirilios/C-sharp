/*задайте массив из 12 элементов, заполненный случайными числами из промежутка -9,9. Найдите сумму отрицательных и положительных 
 элементов массива
*/
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

void GetSum(int[] array)
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            sumP += array [i];
        }
        else
        {
            sumN += array [i];
        }
    }
   Console.WriteLine($"Cумма положительных = {sumP}, сумма отрицательных = {sumN}");
}

Console.WriteLine("Введите число:");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);
Console.WriteLine();
//PrintArray(GetRandomArray(arrayL, min, max));
GetSum(userArray);