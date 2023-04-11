// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] RowSum(int[,] matrix) // сумма строки
{
    int[] arraySum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            arraySum[i] += matrix[i, j];
    }
    return arraySum;
}

int FindMinIndex(int[] array) // найти индекс минимального элемента
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

Console.Clear();
int[,] matrix = InputMatrixInt();
PrintMatrixInt(matrix);
Console.WriteLine();
Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {FindMinIndex(RowSum(matrix))}");