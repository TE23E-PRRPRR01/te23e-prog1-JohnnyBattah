// Ett program för att göra for-loopar för att iterera över siffror, göra beräkningar och skapa mönster. 
Console.Clear();
Console.WriteLine("Ett program för att göra for-loopar för att iterera över siffror, göra beräkningar och skapa mönster.");

// // Användaren anger start och slut
// Console.Write("Ange startvärde: ");
// string minText = Console.ReadLine();
// int min = 0;
// bool success = int.TryParse(minText, out min);

// Console.Write("Ange slutvärde: ");
// string maxText = Console.ReadLine();
// int max = 0;
// success = int.TryParse(maxText, out max);

// int summan = 0;

// // En for-loop
// for (var i = min; i < max+1; i++)
// {
//     Console.WriteLine(i);
//     summan += i;
// }
// Console.WriteLine($"Summan av siffrorna {min} till {max} är {summan}");

Console.Write("Jämna siffror: ");
for (var i = 1; i < 11; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
}