﻿// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void SortArrayRowsDescend(int[,] massive)
{
    for (int row = 0; row < massive.GetLength(0); row++)
    {
        for (int col = 0; col < massive.GetLength(1) - 1; col++)
        {
            int colMax = col;
            for (int j = col + 1; j < massive.GetLength(1); j++)
            {
                if (massive[row, j] > massive[row, colMax])
                {
                    colMax = j;
                }
            }
            int temp = massive[row, col];
            massive[row, col] = massive[row, colMax];
            massive[row, colMax] = temp;
        }
    }
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

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int[,] massive = Create2DMassive(m, n, 1, 10);
Print2Dmassive(massive);
Console.WriteLine("Отсортированный массив");
SortArrayRowsDescend(massive);
Print2Dmassive(massive);