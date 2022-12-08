// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int j = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[i, j];

void FillArray()
{
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}
FillArray();

void PrintArray()
{
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"\t {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

PrintArray();

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

for (i = 0; i < matrix.GetLength(0); i++)
{
    for (j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == num)
        {
            Console.WriteLine($"Это число есть в массиве строка: {i}, столбец: {j}");
        }
    }
    Console.WriteLine("Такого числа в массиве нет");
}