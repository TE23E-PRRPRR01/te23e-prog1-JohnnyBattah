// Menyprogram
Console.Clear();
Console.WriteLine("Litet program med meny");

string val = "";

while (val != "3")
{
    Console.WriteLine("""

    1. Subtrahera två tal
    2. Dividera två tal
    3. Avsluta programmet
    """);
    Console.Write("Välj ett av följande alternativ: ");
    val = Console.ReadLine();

    switch (val)
    {
        case "1":
            Console.Write("Skriv in 2 tal på varsin rad: ");
            double Tal1 = double.Parse(Console.ReadLine());
            double Tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Tal1} - {Tal2} = {Tal1-Tal2}");
            break;

        case "2":
            Console.Write("Skriv in 2 tal på varsin rad: ");
            double Dividera1 = double.Parse(Console.ReadLine());
            double Dividera2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Dividera1} / {Dividera2} = {Dividera1/Dividera2}");
            break;

        case "3":
            Console.WriteLine("Tack för idag.");
            break;

        default:
            Console.WriteLine("Du valde inte ett giltigt alternativ.");
            break;
    }

}