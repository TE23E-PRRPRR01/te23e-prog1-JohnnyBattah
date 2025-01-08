/* *********************************************************
* *********************** M A I N ***********************
************************************************************ */

Console.Clear();
Console.WriteLine("Hej Metoder!");

SägHejNamn("Valentin");
SägHejNamn("Johnny");
SägHejNamn("Benjamin");
SägHejNamn("");


/* *********************************************************
* ******************** M E T O D E R ***********************
************************************************************ */

/// <summary>
/// Skrivut hälsning
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}!");
}