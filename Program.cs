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
        //consol logger en double, fordi double overvinner en int ettersom double består av dobbelt så mange datapakker som en int
        //med andre ord kan en double holde verdien til en int, men en int kan ikke holde på verdien til en double
        var charResult = myChar + myChar;
        Console.WriteLine(charResult);
        //vi får 194 i loggen da en char er en måte å holde informasjon om et tall på. 
        //en char får tildelt 16 datapakker og bruker alle 16 for å holde informasjonen om dette tallet. 


    }
}
