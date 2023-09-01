/*Напишите программу, которая будет создавать копию заданного одномерного массива 
с помощью поэлементного копирования.*/

int[] array = {1,2,3,4,5};

int[] CopyArray(int[] array)
{
    int[] arrayL = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayL[i] = array[i];
    }
    return arrayL;
}
void PrintArray(int[] arrayForPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1) System.Console.Write(", ");
    }
    Console.WriteLine("]");
}
int[] NewArray = CopyArray(array);
PrintArray(NewArray);
