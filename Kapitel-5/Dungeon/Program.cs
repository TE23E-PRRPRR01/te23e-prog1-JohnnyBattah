// Ett Dungeon-spel med massa rum, saker, fiender, skatter ...
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Ett Dungeon-spel ");

// Progremvariabler (state variables)
string rum = "hallen";
List<string> inventory = [];
int liv = 3;

// Spel loop
while (true)
{
    // Är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar runt i rummet och ser några gamla tavlor.");
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine(" .. du går in i nästa rum .. ");
        }
    }
    else if (rum == "rum 1")
    {
        Console.WriteLine("Du är i rum 1");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till hallen");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en nyckel på golvet.");
            Console.Write("Vill du plocka upp nyckel (j/n): ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventory.Add("nyckel");
                Console.WriteLine("Du plockade upp nyckeln");
            }
            else
            {
                Console.WriteLine("Du lämnar nyckeln på golvet!");
            }
        }
        else if (val == "2")
        {
            rum = "hallen";
            Console.WriteLine(" .. du går tillbaka till hallen.. ");
        }
        else if (val == "3")
        {
            rum = "rum 2";
            Console.WriteLine(" .. du går in i nästa rum .. ");
        }
    }
    else if (rum == "rum 2")
    {
        Console.WriteLine("Du är i rum 2");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till rum 1");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en pizza på bordet");
            Console.Write("Vill du äta den? (j/n): ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                Console.WriteLine("Du åt pizzan och blev förgiftad!");
                Console.WriteLine("Game over!");
                break;
            }
            else
            {
                Console.WriteLine("Du lämnar pizzan på bordet.");
                Console.Write("Vill du plocka upp pizzan? (j/n)");
                val = Console.ReadLine().ToLower();
                if (val == "j")
                {
                    inventory.Add("Pizza");
                    Console.WriteLine("Du plockade upp pizzan!");
                }
                else
                {
                    Console.WriteLine("Du lämnar pizzan på bordet!");
                }
            }
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine(" .. du går tillbaka till rum 1.. ");
        }
        else if (val == "3")
        {
            rum = "rum 3";
            Console.WriteLine(" .. du går in i nästa rum .. ");
        }
    }
    else if (rum == "rum 3")
    {
        Console.WriteLine("Du är i rum 3");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till rum 2");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser ett monster som sover");
            Console.Write("Vill du väcka den? (j/n): ");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                Console.WriteLine("Du väckte monstret!");
                Console.WriteLine("Nu måste du kriga mot monstret!");
                Console.Write("Vill du använda dina händer eller dina ben (1/2)");
                val = Console.ReadLine();
                if (val == "1")
                {
                    Console.WriteLine("Han äter upp dina armar!");
                    Console.WriteLine("Du dör!");
                    break;
                }
                else if (val == "2")
                {
                    Console.WriteLine("Du förlorar din vänstra ben men dödar monstret med din högra ben!");
                    Console.WriteLine("Du vann!");
                    break;
                }
                else
                {
                    Console.WriteLine("Du måste välja 1 eller 2");
                }
            }
        }
        else if (val == "2")
        {
            rum = "rum 2";
            Console.WriteLine("Dörren är låst!");
        }
        else if (val == "3")
        {
            rum = "rum 4";
            Console.WriteLine(" .. du går in i nästa rum .. ");
        }
    }
    else if (rum == "rum 4")
    {
        Console.WriteLine("Du är i rum 4");

        // Slumpa en händelse
        int händelse = Random.Shared.Next(1, 5);
        if (händelse == 1)
        {
            Console.Write("Du ser ett svärd på marken. Vill du plocka upp det? (j/n) ");
            string val = Console.ReadLine().ToLower();
            if (!inventory.Contains("svärd") && val == "j")
            {
                inventory.Add("svärd");
                Console.WriteLine("Du har nu ett svärd");
            }
        }
        else if (händelse == 2)
        {
            Console.WriteLine("Ett spöke dyker upp");
            // ..
        }
        else if (händelse == 3)
        {
            Console.WriteLine("Du trampar på en mina och du förlorar ett liv");
            liv--;
            // Är liven slut?
            if (liv <= 0)
            {
                break;
            }
        }
        else if (händelse == 4)
        {

        }
    }
}