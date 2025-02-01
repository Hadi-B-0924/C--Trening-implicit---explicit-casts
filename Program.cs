using System.Runtime.CompilerServices;

namespace C__Trening_implicit___explicit_casts;

class Program
{
    static void Main(string[] args)
    {
        
        string myString = "Hello";
        int myWholeNumber = 10;
        double myDouble = 15.5; 
        char myChar = 'a';

        var result = myString + myWholeNumber;
        Console.WriteLine(result.GetType());
        var numberResult = myWholeNumber + myDouble;
        Console.WriteLine(numberResult.GetType());
        


    }
}
