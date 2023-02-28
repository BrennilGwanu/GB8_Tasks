// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Main()
{
Console.Clear();
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);


int[,] matrix = GetArray(row, col, 0, 10);
PrintArray(matrix);
Console.WriteLine();
MinSum(matrix);
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

void MinSum(int[,] array)
{
    int row = 1;
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int sum = Sum(array);
    for (int i = 1; i < x; i++)
    {
        int temp = 0;
        for (int j = 0; j < y; j++)
        {
            temp += array[i, j];
        }
        if (sum > temp)
        {
            sum = temp;
            row = i + 1;

        }
    }
    Console.WriteLine($"Наименьшая сумма элементов, равная {sum}, находиться в строке {row}");
}

int Sum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[0, i];
    }
    return sum;
} 

Main();