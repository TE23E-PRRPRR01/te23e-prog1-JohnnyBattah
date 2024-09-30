// Hur man skapar och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpa kort ur ett kortlek!");

// Ett annat exempel. lista på 3 årtal
// List<int> årtal = [1957, 1969, 1989];

// Skapa en lista kort
// List<string> kortlek = ["Ess", "Tvåa", "Trea", "Fyra", "Femma", "Sexa", "Sjua", "Åtta", "Nia", "Tia", "Kneckt", "Dam", "Kung"];
// List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮	"];
List<string> kortlek = ["😃", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮	"];


int antal = 5;
while (antal > 0)
{
    // Slumpa index 0-12
    int index = Random.Shared.Next(0, kortlek.Count);
    // Console.WriteLine($"Det slumpade indexet = {index}");


    // Plocka ut det sjunde kortet, index = random
    string kort = kortlek[index];


     // Ta bort staden från städerma
    kortlek.RemoveAt(index);

    // Skriv ut det slumpade kortet
    Console.WriteLine($"Det slumpade kortet är {kort}");

    // Räkna ned
    antal--;
}