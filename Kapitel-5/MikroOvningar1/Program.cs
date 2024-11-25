// Mikro övning 1 - listor
Console.Clear();
Console.WriteLine("Samlingar");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Skapa en tom lista av strängar
List<string> listaNamn = ["Anna", "Björn", "Cecilia"];

// Skriv ut alla namn
Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaNamn)}");

// Lägg till ett namn
Console.Write("Ange ett namn att lägga till: ");
string namn = Console.ReadLine();

// Lägga till namnet i listan
listaNamn.Add(namn);
Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaNamn)}");

// Ta bort ett namn
Console.Write("Ange ett namn att ta bort: ");
string namnAttTaBort = Console.ReadLine();
if (listaNamn.Contains(namnAttTaBort))
{
    listaNamn.Remove(namnAttTaBort);
    Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaNamn)}");
}
else
{
    Console.WriteLine($"Fel: {namnAttTaBort} finns inte i listan.");
}

// Sök efter ett namn
Console.Write("Ange ett namn att söka efter: ");
string namnAttSökaEfter = Console.ReadLine();
if (listaNamn.Contains(namnAttSökaEfter))
{
    Console.WriteLine($"{namnAttSökaEfter} finns i listan");
}
else
{
    Console.WriteLine($"{namnAttSökaEfter} finns inte i listan");
}

// Sortera och visa listan
Console.Write("Vill du sortera listan? (j/n): ");
string svar = Console.ReadLine().Trim();
if (svar == "j")
{
    listaNamn.Sort();
    Console.WriteLine($"Listan är i alfabetisk ordning {string.Join(", ", listaNamn)}");
}