void Triangle (int numA,int numB, int numC)
{
    if(numA + numB > numC && numA + numC > numB && numB + numC > numA)
    Console.WriteLine("yes!");
    else Console.WriteLine("No!");
}

Triangle(1, 2, 3);
