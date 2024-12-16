Console.Clear();
Console.WriteLine("använda listor för att lagra, lägga till, ta bort och visa data.");

// 1. Skapa en lista med action-spel
Console.WriteLine();
List<string> listaSpel = [];
listaSpel.Add("Batman");
listaSpel.Add("Marvel");
Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaSpel)}");


// 2. Skapa en lista med äventyrsspel
Console.WriteLine();
List<string> listaÄventyr = [];
listaÄventyr.Add("Ali Baba");
listaÄventyr.Add("Aladin");
Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaÄventyr)}");


// 3. Användaren fyller på lista med action-spel
Console.WriteLine("Nu ska du fylla i två äventyr-spel i listan:");
for (int i = 0; i < 2; i++)
{
    Console.Write("Ange ett action-spel: ");
    listaÄventyr.Add(Console.ReadLine());
}


// 4. Användaren fyller på lista med äventyrsspel med for-loop
// Samma som 3


// 5. Användaren fyller på lista med action-spel med for-loop
Console.WriteLine();
Console.WriteLine("Nu ska du fylla i två action-spel:");
for (int i = 0; i < 2; i++)
{
    Console.Write("Ange ett action-spel: ");
    listaSpel.Add(Console.ReadLine());
}

// 6. Skriv ut de två första action-spelen mha index
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"- Spel {i + 1}: {listaSpel[i]}");
}


// 7. Skriv ut äventyrsspel med index
Console.WriteLine();
for (int i = 2; i < 4; i++)
{
    Console.WriteLine($"- Spel {i + 1}: {listaÄventyr[i]}");
}

// 8. Skriv ut alla action-spel
Console.WriteLine();
Console.WriteLine("Här är alla action-spel i listan:");
foreach (var action in listaSpel)
{
    Console.WriteLine($"- {action}");
}
Console.WriteLine();
Console.WriteLine("Här är alla äventyrsspel i listan:");
foreach (var äventyr in listaÄventyr)
{
    Console.WriteLine($"- {äventyr}");
}


// 9. Skriv ut de tre första spelen i listan mha for-loop
Console.WriteLine();
Console.WriteLine("Här är de tre första action-spelen i listan:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"- Spel {i + 1}: {listaSpel[i]}");
}


// 10. Använd en for-loop för att registrera fler spel
Console.WriteLine();
Console.WriteLine("Registrera fler action-spel:");
for (int i = 0; i < 2; i++)
{
    Console.Write("Ange ett action-spel: ");
    listaSpel.Add(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Registrera fler äventyrspel:");
for (int i = 0; i < 2; i++)
{
    Console.Write("Ange ett äventyrsspel: ");
    listaÄventyr.Add(Console.ReadLine());
}


// 11. Skriv ut listorna igen
Console.WriteLine();
Console.WriteLine("Lista på alla action-spel:");
foreach (var action in listaSpel)
{
    Console.WriteLine($"- {action}");
}
Console.WriteLine();
Console.WriteLine("Lista på alla äventyrsspel:");
foreach (var äventyr in listaÄventyr)
{
    Console.WriteLine($"- {äventyr}");
}


// 12/13/14. Skapa en meny
Console.WriteLine();
while (true)
{
    Console.WriteLine();
    Console.Write("""
    a. Visa alla action-spel
    b. Registrera ett action-spel
    c. Visa alla äventyrsspel
    d. Registrera tre äventyrsspel
    e. Avsluta
    Välj ett alternativ: 
    """);
    string val = Console.ReadLine();

    if (val == "a")
    {
        Console.WriteLine();
        foreach (var action in listaSpel)
        {
            Console.WriteLine($"- {action}");
        }
    }
    else if (val == "b")
    {
        Console.WriteLine();
        Console.Write("Ange ett spel att lägga till: ");
        listaSpel.Add(Console.ReadLine());
    }
    else if (val == "c")
    {
        Console.WriteLine();
        foreach (var äventyr in listaÄventyr)
        {
            Console.WriteLine($"- {äventyr}");
        }
    }
    else if (val == "d")
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Ange ett äventyrsspel att lägga till: ");
            listaÄventyr.Add(Console.ReadLine());
        }
    }
    else if (val == "e")
    {
        Console.WriteLine();
        Console.WriteLine("Tack för idag.");
        break;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Nu förstod jag inte. Skriv en bokstav (a-e)");
    }
}


