// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void SumMassive(int[,] massive)
{
    int sum = 0;
    int strSum = 0;
    int count = 0;

    for (int i = 0; i < massive.GetLength(1); i++)
    {
        for (int j = 0; j < massive.GetLength(0); j++)
        {
            sum += massive[i, j];
        }
        if (strSum > sum)
        {
            strSum = sum;
        }
        sum = 0;
        count = i;
    }
    Console.Write($"Номер строки с наибольшей суммой: {count}");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

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

int m = GetInput("Введите количество строк и столбцов массива: ");
int n = m;
int[,] massive = Create2DMassive(m, n, 1, 10);
Print2Dmassive(massive);
SumMassive(massive);