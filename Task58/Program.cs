//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Main()
{
Console.Clear();
Console.Write("Введите количество строк первой матрицы: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int col1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второй матрицы: ");
int col2 = int.Parse(Console.ReadLine()!);

int[,] matrixA = GetArray(row1, col1, 0, 10);
int[,] matrixB = GetArray(row2, col2, 0, 10);
Console.WriteLine("Матрица А: ");
PrintArray(matrixA);
Console.WriteLine("Матрица В: ");
PrintArray(matrixB);

MatrixProduct(matrixA, matrixB);
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] intArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return intArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void MatrixProduct(int[,] a, int[,] b)
{
    int[,] pro = new int[a.GetLength(0), b.GetLength(1)];
    if (a.GetLength(1) != b.GetLength(0))
    {
        Console.WriteLine("Эти матрицы нельзя перемножить");
        return;
    }
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int g = 0; g < b.GetLength(0); g++)
            {
                pro[i,j] += a[i, g] * b[g, j];
            }
        }
    }
    Console.WriteLine("Произведение матриц А и В: ");
    PrintArray(pro);
    return;
}

Main();