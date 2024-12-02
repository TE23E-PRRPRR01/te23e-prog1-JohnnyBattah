// Mikroövningar 3
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
// Skriv ut alla djur
List<string> listaFärger = ["Röd", "Blå", "Grön"];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{i+1}: {listaFärger[i]}");
}
