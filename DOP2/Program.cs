//Двумерный массив размером 3х4 заполнен числами от 100 до 9999. 
//Найдите в этом массиве и сохраните в одномерный массив все числа, 
//сумма цифр которых больше их произведения. Выведите оба массива.

void DOP2()
{
    int rows = 3;
    int colunms = 4;
    int st = rows * colunms;
    Console.WriteLine();
    Console.WriteLine($"Массив размера {rows}x{colunms}");


    int[,] numbers1 = new int[rows, colunms];
    int[] numbers2 = new int[st];

    FillArray(numbers1, st);
    PrintArray(numbers1);
    Summa(numbers1, numbers2, rows, colunms, st);
}

void FillArray(int[,] numbers1, int st)
{
    Random random = new Random();
    int rows = numbers1.GetLength(0);
    int colunms = numbers1.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            numbers1[i, j] = random.Next(100, 9999);
        }
    }
}
void Summa(int[,] numbers1, int[] numbers2, int rows, int colunms, int st)
{   
    for(int k = 0; k < rows; k++)
    {
        for(int h = 0; h < colunms; h++)
        {
            int numbers = numbers1[k, h];
            int sum_numbers1 = 0;
            int sum_numbers2 = numbers1[k, h];
            int sum = sum_numbers2 % 10;
            for (int i = 1; i <= colunms; i++)
            {
                sum_numbers1 = sum_numbers1 + numbers % 10;
                numbers = numbers / 10;
                if((sum_numbers2 /= 10) > 0) 
                {
                    int sum_x = sum_numbers2 % 10;
                    sum = sum * sum_x;
                }
            } 
            for(int t = 0; t < st; t++)
            {
                if(sum < sum_numbers1 && numbers2[t] == 0)
                {
                    numbers2[t] = numbers1[k, h];
                    break;
                }
            }
        }
    }
    string arr = string.Join(", ", numbers2);
    Console.WriteLine("Числа из первого массива, сумма цифр которых больше их произведения: [" + arr + "]");
    Console.WriteLine();
}
void PrintArray(int[,] numbers1)
{
    int rows = numbers1.GetLength(0);
    int colunms = numbers1.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colunms; j++)
        {
            Console.Write(numbers1[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

DOP2();