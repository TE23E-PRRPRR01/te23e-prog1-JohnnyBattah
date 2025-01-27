/* **
M A I N                        *
**/

// Ett program för kryptering med Ceasar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Välkommen till Ceasar-kryptering");



// Programloop
while (true)
{

    VisaMeny();

    string val = Console.ReadLine();
    if (val == "1")
    {
        // Kryptera
        KrypteraMeddelande();
    }
    else if (val == "2")
    {
        // Avkryptera
        AvKrypteraMeddelande();
    }
    else if (val == "3")
    {
        Console.WriteLine("..Avslutar..");
        break;
    }
    else
    {
        Console.WriteLine("Fel. Försök igen");
    }

}


/* *****************************************************
********************** M E T O D E R ******************            
*******************************************************/

static void VisaMeny()
{
    Console.Write("""
Kryptera meddelande
Avkryptera meddelande
Avsluta
Välj: 
""");
}

static void KrypteraMeddelande()
{
    // Alfabetet, lista av bokstäver att använda
    string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

    // Ange ett meddelande
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();

    int nyckel = LäsInHeltal();
    // Loopa igenom  meddelandet bokstav för bokstav

    foreach (char bokstav in meddelande)
    {
        // Hitta bokstavens position (index)
        int index = alfabetet.IndexOf(bokstav);

        // Om bokstaven finns i alfabetet
        if (index >= 0)
        {
            int nyIndex = index + nyckel;

            // Börja om från början efter 29
            if (nyIndex >= alfabetet.Length)
            {
                nyIndex = nyIndex - alfabetet.Length;
            }

            // Plocka ut bokstaven för nyIndex
            char krypteradBokstav = alfabetet[nyIndex];
            Console.Write(krypteradBokstav);
        }
        else
        {
            Console.Write(bokstav);
        }
    }
}

static void AvKrypteraMeddelande()
{
    // Alfabetet, lista av bokstäver att använda
    string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

    // Ange ett meddelande
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();

    int nyckel = LäsInHeltal();

    foreach (char bokstav in meddelande)
    {
        int index = alfabetet.IndexOf(bokstav);

        // Om bokstaven finns i alfabetet
        if (index >= 0)
        {
            int nyIndex = index - nyckel;

            // Börja om från början efter 29
            if (nyIndex >= alfabetet.Length)
            {
                nyIndex = nyIndex - alfabetet.Length;
            }

            // Plocka ut bokstaven för nyIndex
            char krypteradBokstav = alfabetet[nyIndex];
            Console.Write(krypteradBokstav);
        }
        else
        {
            Console.Write(bokstav);
        }
    }
}

static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
        Console.Write("Ange krypteringsnyckel: ");
        string textSomBlirTal = Console.ReadLine();
        Console.WriteLine("");
        // Kolla om texten är ett tal
        bool lyckades = int.TryParse(textSomBlirTal, out tal);

        if (lyckades == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Fel. Va god ange ett heltal");
        }
    }

    return tal;
}