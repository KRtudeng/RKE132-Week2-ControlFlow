// See https://aka.ms/new-console-template for more information

//Rakendus palub kasutajal valida oma sugu (m/f)
//Rakendus palub kasutajal sisestada tema perekonnanimi
//Lähtuses kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [ kasutaja perekonnanimi]" / "Welcome, Ms [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse (Console.ReadLine());  //Loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, enter your name:");
string userLastŃame = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastŃame}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastŃame}!");
}
else
{
    Console.WriteLine($"Welcome {userLastŃame}!");
}
