Console.WriteLine("Kas liitmine või lahutamine (+/-)?");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Sisesta a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Sisesta b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Liitmine(firstNum, secondNum);
        break;
    case '-':
        Lahutamine(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}

static void Liitmine(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a+b}");
}

static void Lahutamine(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}