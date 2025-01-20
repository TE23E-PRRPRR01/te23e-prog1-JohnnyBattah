/* *************************************************
 * Namn: Konsolgrafik
 * Beskrivning: Ett program för att rita konsolgrafik
 * Datum: 2024-09-01
 *********************************************** */

VisaIntro();

while (true)
{
    SkrivMeny();
    string val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        int tal = LäsInHeltal();
        SkrivUtFyrkant(tal);
    }
    else if (val == "2")
    {
        int tal = LäsInHeltal();
        SkrivUtTriangel(tal);
    }
    else if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, vg försök igen.");
    }
}

/* **********************************************
 *  Metoder 
 ********************************************** */

/// <summary>
/// Visa presentation 
/// </summary>
static void VisaIntro()
{
    Console.Clear();
    Console.WriteLine("""
    Program för att rita konsolgrafik
    ===================================
    """);
}

/// <summary>
/// Visa programmets meny
/// </summary>
static void SkrivMeny()
{
    // Skriva ut menyn
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Avsluta
    """);
    Console.Write("Välj ett alternativ: ");
}

static void SkrivUtFyrkant(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j < tal; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void SkrivUtTriangel(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Generell metod för att läsa in heltal
/// </summary>
/// <returns></returns>
static int LäsInHeltal()
{
    Console.Write("Ange ett heltal: ");
    string talString = Console.ReadLine();
    int tal;
    while (!int.TryParse(talString, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        talString = Console.ReadLine();
    }
    return tal;
}