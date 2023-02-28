// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x 
// и возвращает целую часть квадратного корня от введенного числа.

void Main()
{
Console.Clear();
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine()!);
int sqRoot = SquareRoot(number);
Console.WriteLine($"Квадратный корень числа {number} равен {sqRoot}");
}

int SquareRoot(int x)
{
    int product = 0;
    int i = 1;
    while (product < x)
    {
        product = i * i;
        i++;
    }
    if (product == x)
        return i - 1;
    else
        return i - 2;
}

Main();
