// Ett program som frågar användaren efter en månad och skriver ut antalet dagar i den månaden.
Console.Clear();
Console.WriteLine("Ett program för att få reda på hur många dagar finns i en månad");

// Fråga användaren om att ange en månad och läsa av svaret
Console.Write("Ange en månad som du vill veta antal dagar på: ");
string månad = Console.ReadLine().ToLower();

// om månaden är Januari, mars, maj, Juli, Augusti, Oktober eller December så har månaden 31 dagar
if (månad == "januari" || månad == "mars" || månad == "maj" || månad == "juli" || månad == "augusti" || månad == "oktober" || månad == "december")
{
    Console.WriteLine($"{månad} har 31 dagar");
}

// om månaden är April, June, September eller November så har månaden 30 dagar
else if (månad == "april" || månad == "juni" || månad == "september" || månad == "november")
{
    Console.WriteLine($"{månad} har 30 dagar");
}

// om månaden är februari så har den antingen 28 eller 29 dagar
else if (månad == "februari")
{
    Console.WriteLine("Februari har antingen 28 eller 29 dagar beroende på året");
}

// om användaren anger något annat eller skriver månaden fel
else
{
    Console.WriteLine("Jag förstod inte, testa igen.");
}
