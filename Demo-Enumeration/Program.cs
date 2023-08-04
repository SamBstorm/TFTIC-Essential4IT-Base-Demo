using Demo_Enumeration;

Cardinal direction;

//Soit affectation par l'énumération
direction = Cardinal.North;
//Soit affectation par l'identifiant numérique de l'énumération
direction = (Cardinal)1;

Console.WriteLine(direction);


direction = Cardinal.South | Cardinal.East;

Console.WriteLine((int)direction);
Console.Write("La direction du vent est");
if (direction.HasFlag(Cardinal.North)) Console.Write(" Nord");
if (direction.HasFlag(Cardinal.South)) Console.Write(" Sud");
if (direction.HasFlag(Cardinal.East)) Console.Write(" Est");
if (direction.HasFlag(Cardinal.West)) Console.Write(" Ouest");
Console.WriteLine();


//Pour récupérer un tableau de nom des énumérations :

//Ancienne méthode
string[] cardinals = Enum.GetNames(typeof(Cardinal));

//Nouvelle méthode
cardinals = Enum.GetNames<Cardinal>();

Console.WriteLine("De quel côté souffle le vent ?");
foreach (string cardinal in cardinals)
{
    Console.WriteLine(cardinal);
}

//Récupération d'un texte vers enum :

string wind_direction = Console.ReadLine();
//Ancienne Méthode
Cardinal wind = (Cardinal)Enum.Parse(typeof(Cardinal), wind_direction);

//Nouvelle Méthode
wind = Enum.Parse<Cardinal>(wind_direction);