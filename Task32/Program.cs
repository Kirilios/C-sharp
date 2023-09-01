/*прогрпмма замена элементов массиваЖ 
положительные элементы замените на соответствующие отрицательные и наооборот*/

/*int min = new Random(). Next(1,10);
int[] array = FillArray (new Rando().Next(1,10), min, min + new Random().Next(1,20));
Console.WriteLine("[" + string.Join(", ", array)) + "]";

int FillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
*/

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

int[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);

int[] ChangeSignArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

PrintArray(ChangeSignArray(userArray));