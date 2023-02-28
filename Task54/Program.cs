// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
int[,] sortMatrix = SortBubble(matrix);
PrintArray(sortMatrix);
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

int[,] SortBubble(int[,] list)
{
    int temp;
    int x = list.GetLength(0);
    int y = list.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int g = j + 1; g < y; g++)
            {
                if (list[i, j] < list[i, g])
                {
                    temp = list[i, j];
                    list[i, j] = list[i, g];
                    list[i, g] = temp;
                }
            }
        }
    }
    return list;
}

Main();
