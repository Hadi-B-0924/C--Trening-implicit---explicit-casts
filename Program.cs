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



        //Implicit casting;
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
        var addingCharToInt = myChar + myWholeNumber;
        Console.WriteLine(addingCharToInt.GetType());
        //i loggen blir char automatisk til en int. En god huskeregel er at den lette datatypen gjøres om til den mer komplekse datatypen.
        //en char kan gjøres om til en int uten å miste informasjon, men en int kan ikke gjøre om til en char uten å miste informasjon. 
        var addingCharToString = myChar + myString;
        Console.WriteLine(addingCharToString.GetType());
        //igjen ser vi at vi får en string ut når vi slår sammen en char og en string.
        //den mindre kompliserte typen er gjort om til den mer kompliserte typen for at variablene kan operere sammen. 

        //Alle Var eksemplene vi har gjennomgått så langt er eksempler på det vi kaller for Implicit casting. 
        //Hvis datamaskinen må gjøre operasjoner på to forskjellige datatyper, 
        //gjør den som en tommelfinger regel, den mindre kompliserte typen om til den mest kompliserte. 
        //Slik at den kan gjøre operasjoner på begge uten å miste data. 


    }
}
