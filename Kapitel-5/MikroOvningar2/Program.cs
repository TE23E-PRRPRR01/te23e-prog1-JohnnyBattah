// Lista övning - 2
Console.Clear();
Console.WriteLine("Lista övning");

// Skapa en lista med 5 namn
List<string> listaNamn = ["MELKER", "Iverbring", "Elias", "Forest", "Eduarts"];
Console.WriteLine($"Mina kompisar är: {string.Join(", ", listaNamn)}");

// Skapa en lista med 5 orter
List<string> listaOrter = ["Byn", "Tensta", "Husby", "Strängnäs", "Täby"];
Console.WriteLine($"Fem orter ({string.Join(", ", listaOrter)}) ligger i Sverige");

// Skapa en lista med 5 årtal
List<int> listaÅrTal = [2019, 2015, 2011, 2010, 2012];
Console.WriteLine($"Fem viktiga årtal är: '{string.Join("', '", listaÅrTal)}'");

// Visa första och sista objektet i en lista
List<string> listaSporter = ["Fotboll", "Basketboll", "Badminton", "Tennis", "Paddel"];
Console.WriteLine("Jag har en namnlista med 5 sporter:");
Console.WriteLine($"Första sportet: {listaSporter[0]}");
Console.WriteLine($"Sista sportet: {listaSporter[4]}");

// Skapa en lista med 5 favoritdrycker
List<string> listaDrycker = ["Cola", "Fanta", "Sprite", "Montain dew", "Vimto"];
// Console.Write($"Mina favoritdrycker: {string.Join(", ", listaDrycker)}");
Console.WriteLine("Mina favorit drycker: ");
Console.WriteLine($"1: {listaDrycker[0]}");
Console.WriteLine($"2: {listaDrycker[1]}");
Console.WriteLine($"3: {listaDrycker[2]}");
Console.WriteLine($"4: {listaDrycker[3]}");
Console.WriteLine($"5: {listaDrycker[4]}");

// Skapa en lista med födelseår
List<int> listaFödelseår = [2000, 1990, 1980, 1970, 1960];
Console.WriteLine("Födelseår: ");
Console.WriteLine($"2: {listaFödelseår[4]}");
Console.WriteLine($"3: {listaFödelseår[3]}");
Console.WriteLine($"4: {listaFödelseår[2]}");
Console.WriteLine($"5: {listaFödelseår[1]}");
Console.WriteLine($"1: {listaFödelseår[0]}");

// Lägg till ett namn baserat på en variabel
List<string> listaNamnNy = ["Johnny", "Elias"];
Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaNamnNy)}");
Console.Write("Ange ett namn att lägga till: ");
string namn = Console.ReadLine();
listaNamnNy.Add(namn);
Console.WriteLine($"Uppdaterad lista: {string.Join(", ", listaNamnNy)}");

// Lägg till ett årtal baserat på en variabel
List<int> listaÅrtalNy = [2011, 2012];
Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaÅrtalNy)}");
Console.Write("Ange ett årtal att lägga till: ");
string årtalText = Console.ReadLine();
int årtal = 0;
bool success = int.TryParse(årtalText, out årtal);
listaÅrtalNy.Add(årtal);
Console.WriteLine($"Uppdaterad lista: {string.Join(", ", listaÅrtalNy)}");

// Kontrollera om ett namn redan finns
List<string> listaKontroll = ["Anna", "Björn", "Cecilia"];
Console.WriteLine($"Namn i listan: {string.Join(", ", listaKontroll)}");
Console.Write("Ange ett namn: ");
string nyNamn = Console.ReadLine();
if (condition)
{
    
}