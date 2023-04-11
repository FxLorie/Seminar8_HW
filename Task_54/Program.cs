// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива

int[,] InputMatrixInt() // матрица целых чисел Int
{
    Console.Write("Введите размеры матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    Console.Write($"Введите минимальное и максимальное значение элементов: ");
    int[] minMax = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(minMax[0], minMax[1]);
    }
    return matrix;
}

void PrintMatrixInt(int[,] matrix) // вывод целочисленной матрицы Int
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

void SortElements(int[] array) // пузырьковая сортировка массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j <= array.Length - 2 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

int[,] MatrixRowSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] row = new int[matrix.GetLength(1)];
        int k = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            row[k++] = matrix[i, j];
        SortElements(row);
        k = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = row[k++];
    }
    return matrix;
}

Console.Clear();
int[,] matrix = InputMatrixInt();
PrintMatrixInt(matrix);
MatrixRowSort(matrix);
Console.WriteLine();
PrintMatrixInt(matrix);