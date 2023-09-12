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

/*int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}*/

/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
//дз
Console.Clear();

int[] array = MyArray();
PrintArray(array);
Console.Write(" -> " + PositiveCount(array));

int[] MyArray()
{
    Console.Write("Укажите длинну массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Элемент {i} из {length - 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

int PositiveCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result++;
    }
    return result;
}
/*
* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();


Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

/*
Упростим (решим) уравнение, для получения координат:
y = k1 * x + b1, y = k2 * x + b2
k1 * x + b1 = k2 * x + b2 (переносим влево значения с Х и выносим Х за скобки)
(k1 - k2) * x = b2 - b1 (делим обе части на (k1 - k2))
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1
*/

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения прямых находится в координатах: x={x}; y={y}]");

//
