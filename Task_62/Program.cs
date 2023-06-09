﻿// Задача 62: Заполните спирально массив 4 на 4.

int[,] CreateMatrixInt()
{
    Console.Write("Введите размер стороны квадратной матрицы: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[size, size];
    return matrix;
}

void InputMatrixInt(int[,] matrix)
{
    int k = 1;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = count; j < matrix.GetLength(1) - 1 - count; j++)
        {
            matrix[i, j] = k;
            k++;
        }
        for (int j = matrix.GetLength(1) - 1 - count; i < matrix.GetLength(0) - 1 - count; i++)
        {
            matrix[i, j] = k;
            k++;
        }
        for (int j = matrix.GetLength(1) - 1 - count; j > count; j--)
        {
            matrix[i, j] = k;
            k++;
        }
        for (int j = count; i > count; i--)
        {
            matrix[i, j] = k;
            k++;
        }
        count++;
    }
    if (matrix.GetLength(0) % 2 != 0)
        matrix[matrix.GetLength(0) / 2, matrix.GetLength(1) / 2] = k;
}

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix = CreateMatrixInt();
InputMatrixInt(matrix);
PrintMatrixInt(matrix);
Console.WriteLine();