// Задайте две квадратные матрицы одного размера. 
// Напишите программу, которая будет находить произведение двух матриц.

void FillMatrix(int[,] matrix, int min, int max)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
            Console.Write($"\t{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int CalculationMultiplicationMatrix(int[,] matrix1, int[,] matrix2, int sizeMatrix, int row, int column)
{
    int sum = 0;
    for(int i = 0; i < sizeMatrix; i++)
    {
        sum += matrix1[row, i] * matrix2[i, column];
    }
    return sum;
}

Console.WriteLine("Задайте размеры двумерных массивов: ");
int sizeMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте минимальное и максимальное значение для генерации чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[sizeMatrix, sizeMatrix];
int[,] matrixB = new int[sizeMatrix, sizeMatrix];

Console.WriteLine("\tДана матрица А:");
FillMatrix(matrixA, min, max);
Console.WriteLine();
Console.WriteLine("\tДана матрица B:");
FillMatrix(matrixB, min, max);
Console.WriteLine();

int[,] matrixC = new int[sizeMatrix, sizeMatrix];

Console.WriteLine("\tРезультирующая матрица будет:");

for(int row = 0; row < sizeMatrix; row++)
{
    for(int column = 0; column < sizeMatrix; column++)
    {
        matrixC[row, column] = CalculationMultiplicationMatrix(matrixA, matrixB, sizeMatrix, row, column);
        Console.Write($"\t{matrixC[row, column]} ");
    }
    Console.WriteLine();
}


