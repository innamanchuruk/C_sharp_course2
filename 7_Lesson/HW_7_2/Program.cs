﻿void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

string FindElement(int[,] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (f > row || f <= 0 || s > column || s <= 0)
        return $"{f} {s} -> not in the array";
    return $"arr[{f}, {s}] = {arr[f - 1, s - 1]} -> is int the array";
}

Console.Write("Enter the line position:");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the column position:");
int second = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(3, 4, 1, 11);
Print(arr_1);

Console.WriteLine(FindElement(arr_1, first, second));


