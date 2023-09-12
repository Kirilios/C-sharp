/*Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] FillMatrixRnd(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(1, 5);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] matrix1 = FillMatrixRnd(2,3);
int[,] matrix2 = FillMatrixRnd(3,4);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int rows = firstMatrix.GetLength(0);
    int columns = secondMatrix.GetLength(1);
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        throw new Exception("Несовместимое количество столбцов и строк матриц");
    }
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return result;
}

int[,] newMatrix = MatrixMultiplication(matrix1, matrix2);
PrintMatrix(newMatrix);