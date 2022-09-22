// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

int row = EnterInt("Enter index i: ");
int column = EnterInt("Enter index j: ");

int[,] numbers = new int[4, 4];
Fill2DArray(numbers);
Print2DArray(numbers);
Console.WriteLine("-----");
LookForElementWithPozition(numbers, row, column);


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}


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


void LookForElementWithPozition(int[,] numbers, int row, int column)
{
    if (row < numbers.GetLength(0) 
        && column < numbers.GetLength(0))
    {
        Console.WriteLine($"{numbers[row, column], 2}"); 
    }
    else 
        Console.WriteLine("Такого числа в массиве нет");   
}