//Даны две матрицы, количество строк и столбцов которых может быть 
//3 или 4, заполнены числами от -9 до 9. Выполните умножение матриц.


void DOP1()
{
    int rows = 3;
    int colunms = 3;

    int[,] numbers1 = new int[rows, colunms];
    int[,] numbers2 = new int[rows, colunms];
    int[,] numbers3 = new int[rows, colunms];

    FillArray(numbers1, numbers2, numbers3);
    PrintArray(numbers1, numbers2, numbers3);
}

void FillArray(int[,] numbers1, int[,] numbers2, int[,] numbers3)
{
    Random random = new Random();
    int rows = numbers1.GetLength(0);
    int colunms = numbers1.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            numbers1[i, j] = random.Next(-9, 9);
            numbers2[i, j] = random.Next(-9, 9);
        }
    }

    for(int k = 0; k < rows; k++)
    {
        for(int l = 0; l < colunms; l++)
        {
            if(k == 0)
            {
                numbers3[0, l] = numbers1[0, l] * numbers2[l, k];
            }
            if(k == 1)
            {
                numbers3[1, l] = numbers1[1, l] * numbers2[l, k];
            }
            if(k == 2)
            {
                numbers3[2, l] = numbers1[2, l] * numbers2[l, k];
            }
        }
    }
}

void PrintArray(int[,] numbers1, int[,] numbers2, int[,] numbers3)
{
    int rows = numbers1.GetLength(0);
    int colunms = numbers1.GetLength(1);
    Console.WriteLine();
    Console.WriteLine("Матрица 1:");
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            Console.Write(numbers1[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Матрица 2:");
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            Console.Write(numbers2[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Результат умнажения матриц 1 и 2:");
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            Console.Write(numbers3[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

DOP1();