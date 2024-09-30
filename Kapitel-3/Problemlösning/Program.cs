// Program för problemlösning
Console.Clear();
Console.WriteLine("Välkommen till programmet för probremlösning");

Console.Write("Fungerar fanskapet? (j/n): ");
string svar = Console.ReadLine().ToLower();

if (svar == "j")
{
    Console.WriteLine("""
    Håll i fingrarna borta!
    Problemet löst!
    """);
}
else
{
    Console.Write("Har du micklat med det? (j/n): ");
    svar = Console.ReadLine().ToLower();
    if (svar == "j")
    {
        Console.WriteLine("Jävla spånhuvud!");
        Console.Write("Vet någon om det? (j/n): ");
        svar = Console.ReadLine().ToLower();
        if (svar == "n")
        {
            Console.WriteLine("""
            Knip käft!
            Problemet löst!
            """);
        }
        else
        {
            Console.WriteLine("Stackars jävel!");
            Console.Write("Kan du skylla på någon (j/n): ");
            svar = Console.ReadLine().ToLower();
            if (svar == "n")
            {
                Console.WriteLine("Stackars jävel!");
            }
            else
            {
                Console.WriteLine("Problemet Löst!");
            }
        }
    }
    else
    {
        Console.Write("Får du fan för det? (j/n): ");
        svar = Console.ReadLine().ToLower();
        if (svar == "n")
        {
            Console.WriteLine("""
            Släng det i soporna!
            Problemet löst!
            """);
        }
        else
        {
            Console.WriteLine("Stackars jävel!");
            Console.Write("Kan du skylla på någon (j/n): ");
            svar = Console.ReadLine().ToLower();
            if (svar == "n")
            {
                Console.WriteLine("Stackars jävel!");
            }
            else
            {
                Console.WriteLine("Problemet Löst!");
            }
        }
        
    }
}

