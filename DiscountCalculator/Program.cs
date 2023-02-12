// total <10 - 1%
// total >= 10 && total <20 - 5%
// total >= 20 - 10%

Console.WriteLine("Sisesta oma ostude summa: ");
int userInput = Int32.Parse(Console.ReadLine());

double allahindlus = CalculateDiscount(userInput);

Console.WriteLine($" Sinu allahindlus on: {allahindlus}%");

double newTotal = CalculateNewTotal(userInput, allahindlus);

Console.WriteLine($"Sinu uus ostude summa koos allahindlusega {allahindlus}% on {newTotal}");

static double CalculateDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}