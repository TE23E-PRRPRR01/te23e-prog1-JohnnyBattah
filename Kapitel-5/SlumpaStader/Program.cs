// Slumpa 2 av 10 städer
Console.Clear();
Console.WriteLine("Slumpa 2 städer!");

// Skapa en lista städer
List<string> städer = ["Stockholm", "Hawaii", "Baghdad", "Gaza", "Sarajevo", "Berlin", "Dortmund", "Amsterdam", "Alanya", "Antalya"];


int antal = 2;
while (antal > 0)
{
    // Slumpa index 0-9
    int index = Random.Shared.Next(0, städer.Count);
    // Console.WriteLine($"Det slumpade indexet = {index}");

    // Plocka ut det sjunde kortet, index = random
    string stad = städer[index];


    // Skriv ut det slumpade staden
    Console.WriteLine($"Det slumpade staden är {stad}");

    
    // Ta bort staden från städerma
    städer.RemoveAt(index);

    // Räkna ned
    antal--;
}