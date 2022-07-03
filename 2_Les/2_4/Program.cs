void OneOfNum(int num_1)
{
    if (num_1 % 7 == 0 && num_1 % 23 == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

OneOfNum(16);
OneOfNum(161);