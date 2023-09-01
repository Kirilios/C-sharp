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

/*int [] array = {3, 4, 5, 6, 9};

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
SelectionSort(array); */

//двумерные массивы, рекурсия
/*string[,] table = new string[2,5];
// String.Empty
// table [0,0] table[0,1] table[0,2] ... table[0,4]
// table [1,0] table[1,1] table[1,2] ... table[1,4]

table[1,2] = "слово";

for (int rows  = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/

/*int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); //[1;10]
        }
    }
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

*/

//вычисление факториала
/*int double Factorial(int n)
{
    //1!=1
    //0!=1
    if (n == 1) return 1;
    else return n* Factorial(n-1);
}
for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/
//Console.WriteLine(Factorial(5)); //1*2*3 =6 

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}