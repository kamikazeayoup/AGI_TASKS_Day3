// See https://aka.ms/new-console-template for more information
using System.Diagnostics.SymbolStore;
using ValidationTask;

string? input;

bool NotNumber = true;
while (NotNumber)
{
    Console.WriteLine("Please Write a number");
    try
    {
        input = Console.ReadLine();
        Validation.IsInt(input);
        NotNumber = false;
      
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        NotNumber = true;

    }
}