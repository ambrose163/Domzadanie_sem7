// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System;

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

double[,] numbers = new double[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}


void Fill2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = 10 * new Random().NextDouble();
        }
    }
}


void Print2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j]:f2}  ");
        }
        Console.WriteLine();
    }
}