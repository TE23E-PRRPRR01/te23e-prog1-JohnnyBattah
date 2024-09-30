// Program för att räkna ut hur många datorer användaren har. 
Console.Clear();
Console.WriteLine("Program för att räkna ut hur många datorer du har");

Console.Write("Hur många datorer äger du? ");
int svar = int.Parse(Console.ReadLine());
if (svar == 1)
{
    Console.WriteLine("Du har 1 dator");
}
else
{
    Console.WriteLine($"Du har {svar} datorer");
}

Console.WriteLine("Ha en trevlig dag!"); //k
