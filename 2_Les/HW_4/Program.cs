void Weekend(int num)
{
    string text = "no";

    if (num == 7 || num == 6) text = "yes";
    Console.WriteLine($"{num} -> {text}"); 
}

Weekend(6);
Weekend(7);
Weekend(1);