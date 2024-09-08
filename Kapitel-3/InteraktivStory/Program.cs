// Program för en rolig berättelse
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Välkommen till denna äventyr");

// En ASCii art (haunted house)
Console.WriteLine($"""
                           .-----.
                         .'       `.
                        :      ^v^  :
                        :           :
                        '           '
         |~        www   `.       .'
        /.\       /#^^\_   `-/\--'
       /#  \     /#%    \   /# \
      /#%   \   /#%______\ /#%__\
     /#%     \   |= I I ||  |- |
     ~~|~~~|~~   |_=_-__|'  |[]|
       |[] |_______\__|/_ _ |= |`.
^V^    |-  /= __   __    /-\|= | :;
       |= /- /\/  /\/   /=- \.-' :;
       | /_.=========._/_.-._\  .:'
       |= |-.'.- .'.- |  /|\ |.:'
       \  |=|:|= |:| =| |~|~||'|
        |~|-|:| -|:|  |-|~|~||=|      ^V^
        |=|=|:|- |:|- | |~|~|| |
        | |-_~__=_~__=|_^^^^^|/___
        |-(=-=-=-=-=-(|=====/=_-=/\
        | |=_-= _=- _=| -_=/=_-_/__\ 
        | |- _ =_-  _-|=_- |]#| I II
        |=|_/ \_-_= - |- = |]#| I II
        | /  _/ \. -_=| =__|]!!!I_II!!
       _|/-'/  ` \_/ \|/' _ ^^^^`.==_^.
     _/  _/`-./`-; `-.\_ / \_'\`. `. ===`.
    / .-'  __/_   `.   _/.' .-' `-. ; ====;\
   /.   `./    \ `. \ / -  /  .-'.' ====='  >
  /  \  /  .-' `--.  / .' /  `-.' ======.' /
""");

Console.WriteLine("Du är just nu i en läskig skog. Du kan gå vänster till en läskig hus eller höger där du inte vet vad som finns.");
Console.Write("Var vill du svänga? (höger eller vänster) ");
string riktning = Console.ReadLine();

// Kolla om personen ska svänga vänster eller höger
if (riktning == "vänster")
{
    Console.WriteLine("Du är nu inne i den läskiga huset, plötsligt hörs en röst från toan.");
    Console.Write("Vill du gå in i toan? (skriv ja eller nej): ");
    string toa = Console.ReadLine();
    
    // Kolla om man vill gå in i toan eller inte
    if (toa == "ja")
    {
        Console.WriteLine("OJ. Det var en häxa där inne och hon höll på att göra nummer 2 du dog tyvärr av lukten");
    }
    else 
    {
        Console.WriteLine("Din fegis, ditt äventyr slutar här.");
    }
}
else if (riktning == "höger") // Om man valde höger
{
    Console.WriteLine("Höger? Jätte basic.. iallafall så hittar du en stor och mörk grotta.");
    Console.Write("Vill du gå in i grottan? (skriv absolut eller aldrig)");
    string grotta = Console.ReadLine();

    if (grotta == "absolut")
    {
        Console.WriteLine("Du hittade GUUULD, GRATTIS");
    }

        else
        {
            Console.WriteLine("Din fegis, ditt äventyr slutar här.");
        }
    }
else
{
    Console.WriteLine("Nu förstår jag inte, börja om.");
}