// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

void FillArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}
FillArray();

void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"\t {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

PrintArray();

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        average = (average + matrix[i, j]);
    }
    average = average / m;
    Console.WriteLine("Среднеарифметическое в столбце: " + average + "; ");
}
Console.WriteLine();