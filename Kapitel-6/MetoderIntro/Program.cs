/* *********************************************************
* ******************   M A I N   ***************************
************************************************************ */

Console.Clear();
Console.WriteLine("Hej metoder!");

// Anropa/Använd metoden
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();

// Anropa med metoden meny
VisaMeny();

// Anropa metoden SägGrattis
SägGrattis();


/* *********************************************************
* ******************** M E T O D E R ***********************
************************************************************ */

/// <summary>
/// Metod som skriver ut en hälsning 
/// </summary>
static void SägHej()
{
    Console.WriteLine("Hej på dig!");
}

/// <summary>
/// Metod för att visa en meny
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Skriv ut alla uppgifter
    4. Avsluta
    """);
}

/// <summary>
/// Metod som gratulerar på födelsedagen
/// </summary>
static void SägGrattis()
{
    Console.WriteLine("Grattis på födelsedagen!");
}
