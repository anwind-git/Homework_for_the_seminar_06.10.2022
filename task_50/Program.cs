// Напишите программу, которая на вход 
// принимает индексы элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.

void Zadaha50()
{
    Console.Write("Введите индекс элемента: ");
    double index = Convert.ToDouble(Console.ReadLine());

    int rows = 5;
    int colunms = 5;
    int num = 0;

    Console.WriteLine($"Массив размера {rows}x{colunms}");

    int[,] numbers = new int[rows, colunms];

    FillArray(numbers);
    PrintArray(numbers);
    int left = (int)index;
    int rich = (int)((index - left) * 10 + 0.1);

    for(int i = 0; i < colunms; i++)
    {
        if(i == rich)
        {
            num = numbers[left, i];
        }
    }
  
if(left < rows && rich < colunms)
{
    Console.WriteLine($"Элемент массива с индексом: {index} равен " + num);
}
else
{
    Console.WriteLine($"Элемента с индексом: {index} в массиве не существует");
}
  
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
            numbers[i, j] = random.Next(-9, 10);
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

Zadaha50();