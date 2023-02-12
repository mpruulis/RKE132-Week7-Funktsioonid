Console.WriteLine("Sisesta midagi:");
string userInput = Console.ReadLine();

PrintAnyWord(userInput);    //userInput - argument mida me anname funktsioonile kaasa

static void PrintAnyWord(string anyString) //anyString - parameeter mida saame funktsiooni kutsumisel kaasa
{
    anyString= anyString.ToUpper();
    for(int i=0; i<5; i++)
    {
        Console.WriteLine(anyString);
    }
}