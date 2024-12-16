Console.Clear();
Console.WriteLine("Filmregister");

// Lista för att lagra filmerna
List<string> listaFilmer = [];

List<int> listaBetyg = [];


// Be användaren ange ett antal
Console.Write("Ange antal filmer per sida (3-5): ");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
    bool success = int.TryParse(antalText, out antal);
    if (success)
    {
        break;
    }
    else
    {
        Console.WriteLine("Fel! Mata in ett heltal.");
    }
}

// Program loop
while (true)
{
    Console.WriteLine();
    // Visa en meny
    Console.Write("""
1. Lägg till filmer
2. Lista alla filmer
3. Sök en film
4. Avsluta
5. Lista filmers betyg
6. Ändra betyg
Välj ett alternativ: 
""");
    string val = Console.ReadLine();

    // Hanterar med valet
    if (val == "1")
    {
        Console.WriteLine();
        // Lägg till filmer i listan
        for (var i = 0; i < antal; i++)
        {
            Console.Write("Ange en film att lägga till: ");
            listaFilmer.Add(Console.ReadLine());
            Console.Write($"Sätt betyg (1-5) för {listaFilmer[i]}: ");
            int betyg = int.Parse(Console.ReadLine());
            listaBetyg.Add(betyg);
        }
    }
    else if (val == "2")
    {
        Console.WriteLine();
        // skriv ut alla filmer
        foreach (var filmnamn in listaFilmer)
        {
            Console.WriteLine($"- {filmnamn}");
        }
    }
    else if (val == "3")
    {
        Console.WriteLine();
        // Sök efter en film
        Console.Write("Ange en film att söka efter (första bokstaven): ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listaFilmer)
        {
            // Kolla om varje film börjar på bokstaven
            if (filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine($"- {filmnamn}");
            }
        }
    }
    else if (val == "4")
    {
        Console.WriteLine();
        Console.WriteLine("Tack för idag!");
        break;
    }
    else if (val == "5")
    {
        for (int i = 0; i < listaBetyg.Count; i++)
        {
            Console.WriteLine($"{listaFilmer[i]}: {listaBetyg[i]}");
        }
    }
    else if (val == "6")
    {
        for (int i = 0; i < listaBetyg.Count; i++)
        {
            Console.WriteLine($"{listaFilmer[i]}: {listaBetyg[i]}");
            Console.Write("Vill du ändra filmens betyg? (j/n): ");
            string ändra = Console.ReadLine();
            if (ändra == "j")
            {
                Console.Write("Vilket betyg vill du ändra filmen till (1-5): ");
                string betygText = Console.ReadLine();
                int betyg = 0;
                bool success = int.TryParse(betygText, out betyg);
                listaBetyg[i] = betyg;
            }
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Fel val. Försök igen!");
    }
}
