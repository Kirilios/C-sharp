/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] UserArray = GetRandomArray(5, -10, 10);

double[] GetRandomArray(int arrayLength1, double minValue, double maxValue)
{
    double[] array = new double[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

void PrintArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1) Console.WriteLine(", ");
    }
    Console.WriteLine("]");
}

void PrintDiffMaxMin (double[] arrayForDiff)
{
    for (int i = 0; i < arrayForDiff.Length; i++)
    {
        for (int j = 0; j < arrayForDiff.Length; j++)
        {
            if (arrayForDiff[i] < arrayForDiff[j+1])
            {
                double temp = arrayForDiff[j];
                arrayForDiff[j] = arrayForDiff[j+1];
                arrayForDiff[j+1] = temp;
            }
        }
    }
Console.WriteLine(Math. Round(arrayForDiff[0] - arrayForDiff[arrayForDiff.Length - 1], 2));

double max = arrayForDiff[0];
double min = arrayForDiff[0];

for (int i = 0; i < arrayForDiff.Length; i++)
{
    if (max < arrayForDiff[i]) max = arrayForDiff[i];
    else if (min < arrayForDiff[i]) min = arrayForDiff[i];

    Console.WriteLine(Math.Round(max - min,2));
}
}

PrintArray(UserArray);
PrintDiffMaxMin(UserArray);



