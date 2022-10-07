// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами, 
// округлёнными до одного знака.

void Zadaha47()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colunms = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{colunms}");

    double[,] numbers = new double[rows, colunms];

    FillArray(numbers);
    PrintArray(numbers);
}

void FillArray(double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int colunms = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            numbers[i, j] = Math.Round(random.NextDouble() * 20 - 10, 1);
        }
    }
}
void PrintArray(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colunms = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadaha47();