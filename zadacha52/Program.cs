// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

using System;

int[,] numbers = new int[4, 4];
Fill2DArray(numbers);
Print2DArray(numbers);
Console.WriteLine("-----");

double[] sums = SumsColumnElements(numbers);
// PrintSumsArray(sums);
// Console.WriteLine();

double[] averages = AveragesColumnElements(sums);
PrintAveragesArray(averages);


void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}


void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j], 2} ");
        }
        Console.WriteLine();
    }
}


double[] SumsColumnElements(int[,] numbers)
{
    double[] sums = new double[numbers.GetLength(1)];

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sums[j] = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sums[j] += numbers[i, j];
        }
    }
    return sums;
}


// void PrintSumsArray(double[] sums)
// {
//     foreach (double item in sums)
//         Console.Write($"{item, 3} ");
// }


double[] AveragesColumnElements(double[] sums)
{
    double[] averages = new double[sums.Length];

    for (int i = 0; i < sums.Length; i++)
    {
        averages[i] = sums[i] / sums.Length;
    }
    return averages;
}


void PrintAveragesArray(double[] averages)
{
    foreach (double item in averages)
        Console.Write($"{item:f2} ");
}