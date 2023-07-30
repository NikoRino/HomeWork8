// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



void Print2Dmassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue);
        }

    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк первой матрицы: ");
int n = GetInput("Введите количество столбцов первой матрицы: ");
int[,] massive = Create2DMassive(m, n, 1, 10);

int o = GetInput("Введите количество строк второй матрицы: ");
int p = GetInput("Введите количество столбцов второй матрицы: ");
int[,] massive2 = Create2DMassive(o, p, 1, 10);
Console.WriteLine("Первая матрица");
Print2Dmassive(massive);
Console.WriteLine("Вторая матрица");
Print2Dmassive(massive2);