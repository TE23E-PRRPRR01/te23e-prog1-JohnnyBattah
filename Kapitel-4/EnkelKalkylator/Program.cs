// Ta bort Nullable från csproj filen för att slippa få problem som inte finns
// Program för att göra en enkel kalkyl
Console.Clear();
Console.WriteLine("Program för att räkna ut matte");

// skapa allt i en while loop
while (true)
{
    Console.Write("""
    1. Addera två tal
    2. Subtrahera två tal
    3. Multiplicera två tal
    4. Dividera två tal
    5. Avsluta programmet
    Välj en av valen (1-5): 
    """);
    // Läsa in användarens svar
    int val = int.Parse(Console.ReadLine());

    // Hantera användarens svar
    if (val == 5) // Om han väljer att avsluta programmet så görs koden break
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else if (val == 1) // Om användaren väljer att addera två tal
    {
        // Läsa in användarens två tal samt addera dem
        Console.Write("Ange det första talet: ");
        double tal1 = double.Parse(Console.ReadLine());
        Console.Write("Ange den andra talet: ");
        double tal2 = double.Parse(Console.ReadLine());

        // Skriva ut svaret till användaren
        Console.WriteLine($"{tal1} adderat med {tal2} blir {tal1+tal2}");

    }
    else if (val == 2) // Om användaren väljer att Subbtrahera två tal
    {
        // Läsa in användarens två tal samt subbtrahera dem
        Console.Write("Ange det första talet: ");
        double tal1 = double.Parse(Console.ReadLine());
        Console.Write("Ange den andra talet: ");
        double tal2 = double.Parse(Console.ReadLine());
        // Skriva ut svaret till användaren
        Console.WriteLine($"{tal1} subtraherat med med {tal2} blir {tal1-tal2}");
    }
    else if (val == 3) // Om användaren väljer att Multiplicera två tal
    {
        // Läsa in användarens två tal samt multiplicera dem
        Console.Write("Ange det första talet: ");
        double tal1 = double.Parse(Console.ReadLine());
        Console.Write("Ange den andra talet: ");
        double tal2 = double.Parse(Console.ReadLine());
        // Skriva ut svaret till användaren
        Console.WriteLine($"{tal1} multiplicerat med med {tal2} blir {tal1*tal2}");
    }
    else if (val == 4) // Om användaren väljer att Dividera två tal
    {
        // Läsa in användarens två tal samt Dividera dem
        Console.Write("Ange det första talet: ");
        double tal1 = double.Parse(Console.ReadLine());
        Console.Write("Ange den andra talet: ");
        double tal2 = double.Parse(Console.ReadLine());
        // Skriva ut svaret till användaren
        Console.WriteLine($"{tal1} dividerat med med {tal2} blir {tal1/tal2}");
    }
    else //Ifall användaren inte skriver 1-5 på första frågan
    {
        Console.WriteLine("Förstod inte vad du menar, försök igen genom att ange en siffra mellan 1-5");
    }
}