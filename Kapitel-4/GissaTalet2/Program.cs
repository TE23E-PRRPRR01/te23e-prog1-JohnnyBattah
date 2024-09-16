// Spelet - gissa ett slumptal 1-100
Console.Clear();
Console.WriteLine("Spelet - gissa ett slumptal");

// En variabel för att hålla koll på antal gissningar
int antal = 0;


// Fråga användaren om min och max värdet för talet samt läsa in värderna
Console.Write("Ange minimum värdet för slumptalet: ");
int minVärde = int.Parse(Console.ReadLine());

Console.Write("Ange maximum värde för slumptalet: ");
int maxVärde = int.Parse(Console.ReadLine());

// Slumpar ett tal med användarens intervall
int slumptal = Random.Shared.Next(minVärde, maxVärde + 1);

// Upprepning - loop
while (true)
{
     // Ställ fråga till användaren
     Console.Write($"Gissa ett tal ({minVärde} - {maxVärde}): ");
     int gissning = int.Parse(Console.ReadLine());

     // Räkna upp antal med 1
     antal++;

    // Kontroll om gissning är rätt?
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat på {antal} gånger");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt");
    }

    // Vill användaren gissa en gång till?
    Console.Write("Vill du gissa en gång till? (j/n): ");
    string svar = Console.ReadLine();
    if (svar == "n")
    {
        break;
    }

}

// Slut på spelet
Console.WriteLine("Slut!, Tack för att du spelade mitt fina spel");