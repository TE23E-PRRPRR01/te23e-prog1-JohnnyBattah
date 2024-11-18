// Skapa en loop som körs 10 gånger.
// Varje gång loopen körs ska den skriva ut ditt namn
Console.Clear();
Console.WriteLine("Ett program för att loopa namn");

// variabel för namn
string namn = "Johnny";

// Skapar en while loop
while (true)
{
    // Läs in ett tal från användaren som anger hur många gånger loopen ska köras.
    Console.Write("Ange hur många gånger loopen ska köras (1-10): ");
    string antalText = Console.ReadLine();
    int antal = 0;
    bool success = int.TryParse(antalText, out antal);

    while (true)
    {
        // Kontrollera om antalet är mellan 1-10
        if (antal <= 10 && antal >= 1)
        {
            for (var i = 0; i < antal; i++)
            {
                Console.WriteLine($"{i}. {namn}");
            }

            // be användaren mata in ytterligare ett tal.
            Console.Write("Ange ytterligare ett tal: ");
            string talText = Console.ReadLine();
            int tal = 0;
            success = int.TryParse(talText, out tal);

            // Skriv ut resultaten av följande beräkningar på talet:
            // Multiplicera det med 2.
            Console.WriteLine($"Multiplicerat med 2: {tal * 2}");
            // Dividera det med 2.
            Console.WriteLine($"Dividerat med 2: {(tal * 2) / 2}");
            // Addera 2.
            Console.WriteLine($"Adderat med 2: {((tal * 2) / 2) + 2}");
            // Subtrahera 2.
            Console.WriteLine($"Subtraherat med 2: {(tal * 2) / 2}");
        }
    }
}