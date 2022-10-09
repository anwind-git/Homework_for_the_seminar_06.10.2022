//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом 
//столбце.

void Zadaha52()
{
    int rows = 3;
    int colunms = 4;

    Console.WriteLine($"Массив размера {rows}x{colunms}");

    int[,] numbers = new int[rows, colunms];

    FillArray(numbers);
    PrintArray(numbers);
    
    double sum1 = 0;
    double sum2 = 0;
    double sum3 = 0;
    double sum4 = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            if(j == 0)
            {
                sum1 += numbers[i, j];
            }
            if(j == 1)
            {
                sum2 += numbers[i, j];
            }
            if(j == 2)
            {
                sum3 += numbers[i, j];
            }
            if(j == 3)
            {
                sum4 += numbers[i, j];
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Среднее арифметическое первого столбца: {sum1 = Math.Round(sum1 / rows, 1)}");
    Console.WriteLine($"Среднее арифметическое второго столбца: {sum2 = Math.Round(sum2 / rows, 1)}");
    Console.WriteLine($"Среднее арифметическое третьего столбца: {sum3 = Math.Round(sum3 / rows, 1)}");
    Console.WriteLine($"Среднее арифметическое четвертого столбца: {sum4 = Math.Round(sum4 / rows, 1)}");
    Console.WriteLine();
}


void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int colunms = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}
void PrintArray(int[,] numbers)
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

Zadaha52();