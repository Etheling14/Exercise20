double e = 0;

int quantityPresicionTerms;

double Factorial(double n)
{
    if (n == 0)
    {
        n = 1;
        for (double x = n - 1; x > 0; x--)
        {
            n = n * x;
        }
    }
    else
    {
        for (double x = n - 1; x > 0; x--)
        {
            n = n * x;
        }
    }
    return n;
}

void calculateNumberE(int quantityPresicionTerms)
{
    for (int x = 0; x <= quantityPresicionTerms; x++)
    {
        e += 1 / Factorial(x);
    }
    Console.Write("e = " + e);
}

Console.Write("How many precision terms you want: ");
quantityPresicionTerms = int.Parse(Console.ReadLine());

calculateNumberE(quantityPresicionTerms);
Console.ReadKey();  