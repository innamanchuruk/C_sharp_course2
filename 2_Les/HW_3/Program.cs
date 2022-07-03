void ThirdNum(int num)
{
    Console.WriteLine($"{num} -> ");
    if (num < 99)
    {
         Console.WriteLine("there is no third digit");
         return;
    }

    while (num > 999) num = num / 10;
     Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()));
