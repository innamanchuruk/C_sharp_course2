int SumNums(int num)
{
    int n_sum = 0;

    while (num > 0)
    {
        n_sum += num % 10;
        num /= 10;
    }
    return n_sum;
}

Console.WriteLine(SumNums(452));
Console.WriteLine(SumNums(82));
Console.WriteLine(SumNums(9012));
