void Binary(int number)
{
    string Des = "";
    while (number > 0)
    {
        Des = number % 2 + Des;
        number /= 2;
    }
    Console.WriteLine(Des);
}

Binary(2);
