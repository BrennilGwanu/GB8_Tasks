// Напишите программу, которая заполнит спирально массив 4 на 4 

void Main()
{
Console.Clear();
int row = 4;
int col = 4;

int[,] matrix = GetArraySpirally(row, col);
PrintArray(matrix);
}

int[,] GetArraySpirally(int m, int n)
{
    int[,] intArray = new int[m, n];
    int col = intArray.GetLength(0);
    int row = intArray.GetLength(1);
    for (int count = 0, num = 1; num != col * row + 1; count += 1)
    {
        int i = count;
        int j = count;
        while (j != col - count - 1)
        {
            if (num > col * row) 
            {
                break;
            }
            else
            {
                intArray[i, j++] = num;
                num++;   
            }
        }
        
        while (i < row - count - 1)
        {
            if (num > col * row) 
            {
                break;
            }
            else
            {
                intArray[i++, j] = num;
                num++;   
            }
        }
        while (j != count)
        {
            if (num > col * row) 
            {
                break;
            }
            else
            {
                intArray[i, j--] = num;
                num++;   
            }
        }
        while (i > count)
        {
            if (num > col * row) 
            {
                break;
            }
            else
            {
                intArray[i--, j] = num;
                num++;   
            }
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

Main();
