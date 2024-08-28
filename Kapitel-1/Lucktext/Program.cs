// program för lucktext
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("En rolig lucktext!");

Console.Write("Vad heter du?: ");
string namn = Console.ReadLine();
if (namn == "")
{
    Console.WriteLine("Error! Du glömde skriva vad du heter");
}
else
{
    Console.Write("Vad är din favorit maträtt?: ");
string mat = Console.ReadLine();

Console.Write("Vad är din favorit semester destination?: ");
string semester = Console.ReadLine();

Console.Write("Vem är din favorit idrottare?: ");
string idrottare = Console.ReadLine();

Console.WriteLine($"Hej! Jag heter {namn} och min dröm är att äta {mat} i {semester} med {idrottare}");
}

