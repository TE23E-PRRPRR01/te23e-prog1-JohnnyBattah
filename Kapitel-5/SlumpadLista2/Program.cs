// Skapa lista med slumpade tal

/* ********************************************************************
**                             Main                                  **
********************************************************************** */

// Validera användarens inmatning
Console.Clear();
Console.WriteLine("Skapa lista med slumpade tal");

// Deklarera variabler
// Skapa en tom lista för att sparadet slumpade talet
List<int> listaSlumptal = [];

// Fråga igen tills användaren matar in ett giltigt svar
int antal = LäsInHeltal();
Console.WriteLine($"Du vill ha {antal} slumptal!");

// Användaren mata in min-värde
int min = LäsInHeltal();
Console.WriteLine($"Lägsta slumptal blir {min}!");

// Användaren mata in max-värde
int max = LäsInHeltal();
Console.WriteLine($"Högsta slumptal blir {max}!");

// Slumpa fram ett annat tal
for (var i = 0; i < antal; i++)
{
    int slumpTal = Random.Shared.Next(min, max + 1);
    Console.WriteLine($"Ditt nya slumptal är {slumpTal}");
}

/* ********************************************************************
**                      Mina egna metoder                            **
********************************************************************** */

static int LäsInHeltal()
{
    int heltal = 0;
    while (true)
    {
        // Fråga användaren hur många slumptal som skall skapas
        Console.Write("Ange heltal: ");

        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades)
        {
            break;
        }
        else
        {
            Console.WriteLine("Du måste skriva ett heltal!");
        }
    }
    return heltal;
}