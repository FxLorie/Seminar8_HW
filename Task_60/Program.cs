// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,,] Create3DMatrixInt()
{
    Console.Write("Введите размеры матрицы через пробел: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,,] matrix = new int[size[0], size[1], size[2]];
    return matrix;
}

void Input3DMatrixInt(int[,,] matrix)
{
    int k = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = k;
                k++;
            }
        }
    }
}

void Print3DMatrixInt(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
                Console.Write($"{matrix[i, j, z]}({i}, {j}, {z}) \t");
            Console.WriteLine();
        }
    }
}

Console.Clear();
int[,,] matrix = Create3DMatrixInt();
if (matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2) < 90)
{
    Input3DMatrixInt(matrix);
    Print3DMatrixInt(matrix);
}
else Console.WriteLine("Создать подобную матрицу с неповторяющимися значениями невозможно");