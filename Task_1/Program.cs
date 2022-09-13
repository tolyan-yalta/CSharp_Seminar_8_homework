// Задайте двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

Console.WriteLine("Задайте двумерный массив, введите количество строк и столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте минимальное и максимальное значение для генерации чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

int [] sumRows = new int [rows];            // Массив для суммы элементов строки

for(int i = 0; i < rows; i++)
{
    int sum = 0;
    for(int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(min, max);
        sum += matrix[i, j];
        Console.Write($"\t{matrix[i, j]} ");
    }
    sumRows[i] = sum;
    Console.Write($"\t\t{sumRows[i]} ");    // Вывод суммы элементов строки
    sum = 0;
    Console.WriteLine();
}

int minSumRows = sumRows[0];
int result = 0;
for(int i = 1; i < rows; i++)               // Нахождение минимальной суммы
{
    if(sumRows[i] < minSumRows)
    {
        minSumRows = sumRows[i];
        result = i;
    }
}

Console.WriteLine($"\n\tНомер строки с наименьшей суммой элементов: {result + 1} строка");
