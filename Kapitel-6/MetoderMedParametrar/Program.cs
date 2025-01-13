/* *********************************************************
* *********************** M A I N ***********************
************************************************************ */
Console.Clear();

// Skriv ett meddelande vertikalt
string meddelande = "Måndag!";
// SkrivVertikalt(meddelande);

// Skriv ett meddelande vertikalt nr 2
string meddelande1 = "Tisdag är bättre!";
// SkrivVertikalt(meddelande1);

// Skriv ett meddelande vertikalt nr 2
string meddelande2 = "Tisdag är bättre!";
// SkrivVertikalt(meddelande2);

// Rita ut en fyrkant med sidlängd 3
// RitaKvadrat(3);

// Testar metoden UpprepaText
// UpprepaText("Hej", 3);
// UpprepaText("Hejsan", 5);

// OmvandlaCTillF(20);


KastaTärning(10);

/* *********************************************************
* ******************** M E T O D E R ***********************
************************************************************ */
/// <summary>
/// Skriv ett meddelande vertikalt
/// </summary>
/// <param name="meddelande"></param>
static void SkrivVertikalt(string meddelande) // Hela raden kallas för en signatur, metoden heter SkrivVertikalt. String parameter
{
    for (int i = 0; i < meddelande.Length; i++) // 0 -> 6
    {
        Console.WriteLine(meddelande[i]);
    }
}

static void RitaKvadrat(int sidlängd)
{
    for (int i = 0; i < sidlängd; i++)
    {
        for (int j = 0; j < sidlängd; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


static void UpprepaText(string text, int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}


static void OmvandlaCTillF(int graderC)
{
    Console.WriteLine($"{graderC} grader Celcius motsvarar {graderC * 9/5 + 32} grader Fahrenheit");
}


static void KastaTärning(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        Console.WriteLine($"Tärningen visar {Random.Shared.Next(1, 7)}");
    }
}