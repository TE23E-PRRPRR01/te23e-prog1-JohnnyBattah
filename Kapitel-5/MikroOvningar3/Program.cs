// Mikroövningar 3
using System.Diagnostics;

Console.Clear();
Console.WriteLine("Mikroövningar 3");

// Skriv ut lista med foreach
List<string> listaMaträtter = ["Shawarma", "Kebab", "Gyros"];
foreach (string maträtt in listaMaträtter)
{
    Console.WriteLine($"- {maträtt}");
}

// Skriv ut alla årtalen i en lista
List<int> listaÅrtal = [2009, 2010, 2011, 2012, 2015];
Console.WriteLine("Alla årtal i listan: ");
foreach (int år in listaÅrtal)
{
    Console.WriteLine($"* {år}");
}

// Skriv ut på en rad
foreach (int år in listaÅrtal)
{
    Console.Write($"{år}, ");
}
Console.WriteLine();

// Användaren fyller på en lista
List<string> listaFylla = [];
while (true)
{
    Console.Write("Ange ett namn att lägga till (eller 'exit' för att avsluta): ");
    string namn = Console.ReadLine();
    if (namn == "exit")
    {
        break;
    }
    listaFylla.Add(namn);
}
// Skriv ut alla djur
Console.WriteLine(string.Join(", ", listaFylla));

// Användaren fyller på en lista med årtal
List<int> listaTomÅrtal = [];
while (true)
{
    Console.Write("Ange ett årtal att lägga till (eller 'exit' för att avsluta): ");
    string årtalText = Console.ReadLine();
    if (årtalText == "exit")
    {
        break;
    }
    int årtal = 0;
    bool success = int.TryParse(årtalText, out årtal);

    listaTomÅrtal.Add(årtal);
}

// Numrerad lista
List<string> listaFärger = ["Röd", "Blå", "Grön"];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{i + 1}: {listaFärger[i]}");
}

Console.WriteLine();

// Loopa o fråga
List<string> listaStäder = ["Göteborg", "Malmö", "Stockholm", "Uppsala", "Örebro"];
for (int i = 0; i < listaStäder.Count; i++)
{
    Console.WriteLine($"{i}. {listaStäder[i]}");
}

while (true)
{
    Console.Write("Vilken stad vill du besöka? (0-4): ");
    string stadText = Console.ReadLine();
    int stad = 0;
    bool success = int.TryParse(stadText, out stad);

    if (stad >= 0 && stad <= 4)
    {
        Console.WriteLine($"Du valde att besöka {listaStäder[stad]}");
    }
    else if (stad == 999)
    {
        break;
    }
    else
    {
        Console.WriteLine("Fel: Ange ett index mellan 0 och 4.");
    }
}

Console.WriteLine();

// Hitta namn i en lista
List<string> listaNyNamn = ["Johnny", "Robin", "Ledzema"];
Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaNyNamn)}");

Console.WriteLine("Ange 2 namn: ");
Console.Write("Namn 1: ");
string namn1 = Console.ReadLine();
listaNyNamn.Add(namn1);

Console.Write("Namn 2: ");
string namn2 = Console.ReadLine();
listaNyNamn.Add(namn2);

Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaNyNamn)}");

Console.Write("Ange ett namn att söka efter: ");
string namnAttSöka = Console.ReadLine();
if (listaNyNamn.Contains(namnAttSöka))
{
    Console.WriteLine($"{namnAttSöka} finns i listan");
}
else
{
    Console.WriteLine($"{namnAttSöka} finns ej i listan");
}

Console.WriteLine();

// Hitta namn som börjar på en viss bokstav
List<string> listaNamn = ["Mings", "Palmer", "Salah", "Ronaldo", "Messi"];
Console.Write("Ange en bokstav: ");
string bokstav = Console.ReadLine().ToUpper().Trim();
foreach (string bokstavs in listaNamn)
{
    if (bokstavs.StartsWith(bokstav))
    {
        Console.WriteLine($"Namn som börjar på {bokstav}: {bokstavs}");
    }
}

// Lägg till namn tills listan har 5 namn
List<string> listaTom = [];
Console.WriteLine("Nuvarande lista: ");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ange ett namn: ");
    string namn = Console.ReadLine();
    listaTom.Add(namn);
    Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaTom)}");
}

Console.WriteLine();

// Ta bort ett namn om det finns
List<string> listaNamnNy = ["Mings", "Palmer", "Salah", "Ronaldo", "Messi"];
Console.WriteLine("Ange ett namn att ta bort: ");
string namnAttTaBort = Console.ReadLine();

Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaNamnNy)}");
if (listaNamnNy.Contains(namnAttTaBort))
{
    listaNamnNy.Remove(namnAttTaBort);
    Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaNamnNy)}");
}
else
{
    Console.WriteLine($"Fel: {namnAttTaBort} finns inte i listan");
}

Console.WriteLine();

// Upprepa en meny med alternativ
List<string> lista12 = [];
int val = 0;
Console.WriteLine($"Nuvarande lista: {string.Join(", ", lista12)}");
while (true)
{
    Console.WriteLine();
    Console.Write("""
    1. Lägg till namn
    2. Ta bort namn
    3. Visa lista
    4. Avsluta
    Välj ett alternativ: 
    """);
    string valText = Console.ReadLine();
    int valet = 0;
    bool success = int.TryParse(valText, out valet);
    if (valet == 1)
    {
        Console.Write("Ange ett namn att lägga till: ");
        string namn = Console.ReadLine();
        lista12.Add(namn);
    }
    else if (valet == 2 && lista12.Count > 0)
    {
        Console.WriteLine("Ange ett namn att ta bort: ");
        string namn = Console.ReadLine();
        lista12.Remove(namn);
    }
    else if (valet == 3)
    {
        Console.WriteLine($"Nuvarande lista: {string.Join(", ", lista12)}");
    }
    else
    {
        break;
    }
}

Console.WriteLine();

// Summera alla tal i en lista
List<int> lista13 = [1, 2, 3, 4, 5];
int summa = 0;
foreach (int tal in lista13)
{
    summa += tal;
}
Console.WriteLine($"Summan av talen är: {summa}");