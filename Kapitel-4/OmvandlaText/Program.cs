// Litet program med meny
Console.Clear();
Console.WriteLine("Litet program med meny");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Variabel för valet
string val = "";

// Programloop som snurrar tills användaren säger stopp
while (true)
{
    // Visar en meny och läser användarens val
    Console.Write("""
    1. Omvandla en text till versalen
    2. Omvandla en text till gemener
    3. Avsluta 
    Välj ett av alternativen ovan: 
    """);
    val = Console.ReadLine();
    
    // Hantera användarens val

    if (val == "1")
    {
        Console.Write("Skriv in en text: ");
        string texten = Console.ReadLine().ToUpper();
        Console.WriteLine($"Texten i versaler blir: {texten}");
    }
    else if (val == "2")
    {
        Console.Write("Skriv in en text: ");
        string texten = Console.ReadLine().ToLower();
        Console.WriteLine($"Texten i gemener blir: {texten}");
        
    }
     else if (val == "3")
    {
        Console.WriteLine("Avslutar...");
        break;
    }
    else
    {
        Console.WriteLine("Du valde ogiltit alternativ, försök igen");
    }
}
