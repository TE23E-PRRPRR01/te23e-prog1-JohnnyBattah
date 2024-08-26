Console.Clear();

Console.WriteLine("Hej världen!");
Console.WriteLine("Nu mitt första C# program");;

Console.Write("Vad heter du?");
string namn = Console.ReadLine();
Console.WriteLine("Hej" + namn);

Console.Write("vad gör du på fritiden?");
string fritid = Console.ReadLine();
Console.WriteLine("VAA!!!!???? Jag älkar också att " + fritid + "!!!!!");

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.Write("Såg du på OS i sommar? Vilken sport gillar du mest?");