// Сформируйте двухмерный массив из неповторяющихся двузначных чисел 
// (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.

bool IsVerify(int number, int rows, int columns, int[,] matrix)
{
    bool result = false;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if(number == matrix[i, j])
            {
                return result;
            }
        }
    }
    result = true;
    return result;
}

int EnteringRows()
{
    Console.Write("Введите количество строк в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int EnteringColumns()
{
    Console.Write("Введите количество столбцов в массиве: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    return columns;
}

int rows = EnteringRows();
int columns = EnteringColumns();

bool checkInputData1 = false;
bool checkInputData2 = false;
while(checkInputData1 != true || checkInputData2 != true)
{
    if(rows * columns > 50)
    {
        Console.WriteLine("Количество элементов массива больше заданных по условию (больше 50)");
        rows = EnteringRows();
        columns = EnteringColumns();
    }
    else
    {
        checkInputData1 = true;
    }
    if(rows <= 0 || columns <= 0)
    {
        Console.WriteLine("Количество строк или столбцов в матрице не может быть равно 0");
        rows = EnteringRows();
        columns = EnteringColumns();
    }
    else
    {
        checkInputData2 = true;
    }
}


int[,] matrix = new int[rows, columns];

for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        int number = 0;
        bool value = false;
        while(value != true)
        {
            number = new Random().Next(10, 100);
            value = IsVerify(number, rows, columns, matrix);
        }
        matrix[i, j] = number;
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}



