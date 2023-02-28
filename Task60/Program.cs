// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Main()
{
Console.Clear();
Console.Write("Введите первое число: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int x3 = int.Parse(Console.ReadLine()!);

int[,,] matrix = GetArray(x1, x2, x3, 10, 99);
PrintArray(matrix);
}

int[,,] GetArray(int a, int b, int c, int minValue, int maxValue)
{
    int[,,] intArray = new int[a, b, c];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int g = 0; g < c; g++)
            {
                while (intArray[i, j, g] == 0)
                {
                    int number = RandomNumber(intArray, minValue, maxValue);
                    intArray[i, j, g] = number;
                }
                
            }
        }
    }
    return intArray;
}

int RandomNumber(int[,,] test, int min, int max)
{
    int num = new Random().Next(min, max + 1);
    foreach (int el in test)
    {
        if (el == num)
            num = RandomNumber(test, min, max);
    }
    return num;
} 

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int g = 0; g < array.GetLength(2); g++)
            {
                Console.Write($"{array[i, j, g]}({i}, {j}, {g})\t ");
            }
        }
        Console.WriteLine();
    }
}

Main();