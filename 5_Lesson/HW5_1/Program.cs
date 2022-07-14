void Print(int[] arr)
{
    int size = arr.Length;
     
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{arr[i]} ");
    } 
    Console.WriteLine();
}

int[] MassNams(int size, int from, int to)
{
    int[] arr = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int EvenNum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] arr_1 = MassNams(15, 100, 251);
Print(arr_1);
Console.WriteLine(EvenNum(arr_1));

int[] arr_2 = MassNams(6, 100, 251);
Print(arr_2);
Console.WriteLine(EvenNum(arr_2));
