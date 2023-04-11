// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

int[,] InputMatrixInt()
{
    Console.Write("Введите размеры матрицы через пробел: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    Console.Write($"Введите минимальное и максимальное значение элементов через пробел: ");
    int[] minMax = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(minMax[0], minMax[1]);
    }
    return matrix;
}

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
{
    int[,] resMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int rowSum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int z = 0; z < matrix2.GetLength(1); z++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
                rowSum += matrix1[i, j] * matrix2[j, z];
            resMatrix[i, z] = rowSum;
            rowSum = 0;
        }
    }
    return resMatrix;
}

Console.Clear();
int[,] firstMatrix = InputMatrixInt();
PrintMatrixInt(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = InputMatrixInt();
PrintMatrixInt(secondMatrix);
Console.WriteLine();
if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
PrintMatrixInt(MatrixMult(firstMatrix, secondMatrix));
else Console.WriteLine("Невозможно найти произведение данных матриц");