/*void Method(string msg, int count, bool isStatic);
{
    int i = 0;
    while (count > i)
    {
       Console.WriteLine (msg); 
       i++;
    }
}
*/
/*int Method()
{
    return DateTime.Now.Year;
}
int year = Method();
Console.WriteLine(year);
*/
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++ )
    {
        Console.WriteLine($" {i} X {j} = {i*j}");
    }
    Console.WriteLine("");
}
*/

int [] array = {3, 4, 5, 6, 9};

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("");
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minPosition]) 
        {
            minPosition = j;
        }
    }
    int temporary = array [i];
    array [i] = array [minPosition];
    array [minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);