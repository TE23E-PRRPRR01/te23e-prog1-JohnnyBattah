// Program där användaren kan spela "Sten, sax, påse, ödla, Spock" mot datorn.
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Clear();
Console.WriteLine("Välkommen till Sten, sax, påse, ödla, Spock!");
Console.WriteLine("""
Spelets regler:
Sten krossar sax
Sten krossar ödla
Sax klipper papper
Sax halshugger ödla
Påse täcker sten
Påse fångar Spock
Ödla äter papper
Ödla förgiftar Spock
Spock krossar sax
Spock smälter sten
""");

// Skapa variabel för poäng för datorn och för användaren
int poängDator = 0;
int poängAnvändare = 0;


// Skapa en lista
List<string> val = ["sten", "sax", "påse", "ödla", "spock"];


// Programloop
while (true)
{
    
    // Slumpa fram datorns val (index 0-4)
    int index = Random.Shared.Next(0, val.Count);
    string valDator = val[index];

    // Fråga användaren om val
    Console.Write("Välj: sten, sax, påse, ödla eller Spock: ");
    string valAnvändare = Console.ReadLine().ToLower().Trim();

    // Jämför användarens och datorns val
    Console.WriteLine($"Du valde {valAnvändare} och datorn valde {valDator}");

    // Vem vinner?
    if (valAnvändare == valDator)
    {
        Console.WriteLine("Det är oavgjort");
    }
    // Hjälp från AI
    else if ((valAnvändare == "sten" && (valDator == "sax" || valDator == "ödla")) ||
             (valAnvändare == "sax" && (valDator == "påse" || valDator == "ödla")) ||
             (valAnvändare == "påse" && (valDator == "sten" || valDator == "spock")) ||
             (valAnvändare == "ödla" && (valDator == "spock" || valDator == "påse")) ||
             (valAnvändare == "spock" && (valDator == "sax" || valDator == "sten")))
    {
        Console.WriteLine("Du vann!");
        poängAnvändare++;
    }
    else
    {
        Console.WriteLine("Datorn vann!");
        poängDator++;
    }


    // Vill användaren spela igen?
    Console.Write("Vill du spela igen? (j/n): ");
    string spelaIgen = Console.ReadLine().ToLower().Trim();
    if (spelaIgen != "j")
    {
        break;
    }
    Console.Clear();

}

// Avsluta programmet och berätta om antal poäng
Console.WriteLine($"Tack för att du har spelat. du har fått {poängAnvändare} poäng och datorn fick {poängDator} poäng");


