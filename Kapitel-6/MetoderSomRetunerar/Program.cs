/* *********************************************************
* *********************** M A I N ***********************
************************************************************ */
// Använd metoder här!
int svar = Addera(3, 5);
Console.WriteLine($"Svaret är {svar}");
Console.WriteLine(Addera(3, 5));
Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

string ord = "Måndag";
Console.WriteLine($"{ord} omvänt blir: {VändText(ord)}");


Console.WriteLine($"3 * 5 = {Multiplicera(3, 5)}");
Console.WriteLine($"3 / 5 = {Dividera(3, 5)}");

Console.WriteLine($"Längst av Hej och Hejsan är {Längst("Hej", "Hejsan")}");

Console.Write("Ange ett tal: ");
int nyTal1 = LäsInHeltal();

Console.Write("Ange ett tal: ");
int nyTal2 = LäsInHeltal();

/* *********************************************************
* ******************** M E T O D E R ***********************
************************************************************ */
// Skapa metoder här!

/// <summary>
/// sUMMERA 2 TAL
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static int Addera(int tal1, int tal2) // Hela raden kallas för signatur
{
    int summa = tal1 + tal2;
    return summa;
}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>
/// <returns></returns>
static string VändText(string text)
{
    string omvändText = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}

/// <summary>
/// Metod för att multiplicera tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Multiplicera(double tal1, double tal2)
{
    double produkt = tal1*tal2;
    return produkt;
}

/// <summary>
/// Metod för att dividera tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Dividera(double tal1, double tal2)
{
    double kvot = tal1/tal2;
    return kvot;
}


static string Längst(string text1, string text2)
{
    if (text1.Length >= text2.Length)
    {
        return text1;
    }
    else
    {
        return text2;
    }
}

/// <summary>
/// Säkert sätt att läsa in ett tal (utan att det krashar)
/// </summary>
static int LäsInHeltal()
{
    int tal = 0;

    while (true)
    {
        // Läs in från användaren
        string textSomBlirTal = Console.ReadLine();

        // Kolla om texten är ett tal
        bool lyckades = int.TryParse(textSomBlirTal, out tal);

        if (lyckades == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Fel! Vg ange ett heltal!");
        }
    }
    return tal;
}
