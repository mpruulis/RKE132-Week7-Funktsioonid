
Console.WriteLine("Kas sa tuled või lähed?  (in/out)");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else if(userChoice == "out")
{
    PrintGoodBye();
}
else
{
    Error();
}

//PrintHello();   // PrintHello funktsiooni välja kutsumine

//PrintGoodBye();


static void PrintHello()        // funktsioon/methot mida saab välja kutsuda
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()        // funktsioon/methot mida saab välja kutsuda
{
    Console.WriteLine("See you later!");
}

static void Error()
{
    Console.WriteLine("Error!");
}