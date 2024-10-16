// Ett litet namnregister 


Console.Clear();
Console.WriteLine("Ett litet namnregister");

List<string> namnlista = [];

// Programloopen 
while (true)
{
    // Visa en meny
    Console.Write("""
1. Registra namn
2. Skriva ut alla namn
3. Avsluta programmet
Ange ditt val: 
""");
    string val = Console.ReadLine();

    if (val == "1")
    {
        Console.Write("Ange ett namn: ");
        string namn = Console.ReadLine();
        namnlista.Add(namn);
    }
    else if (val == "2")
    {
        foreach (var namnet in namnlista)
        {
            Console.Write($"{namnet}, ");
        }
        Console.WriteLine();
    }
    else if (val == "3")
    {
        break;
    }
}