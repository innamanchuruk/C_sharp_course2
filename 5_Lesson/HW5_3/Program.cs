﻿void Print(double[] arr)
{
    int size = arr.Length;
     
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{arr[i]} ");
    } 
    Console.WriteLine();
}

double[] MassNams(int size)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) -10, 2);
    }
    return arr;
}

void DiffMaxMin(double[] arr)
{
    double n_max = arr[0];
    double n_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (n_max < arr[i])
        {
            n_max = arr[i];
        }
        else if (n_min > arr[i])
        {
             n_min = arr[i];
        }
    }
    Console.WriteLine($"Max: {n_max}, min: {n_min}. ");
    Console.WriteLine($"Differense: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");
}

