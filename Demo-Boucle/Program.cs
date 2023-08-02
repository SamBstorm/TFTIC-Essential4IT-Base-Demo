#region Exemple boucle while
/*

Console.WriteLine("Veuillez introduire un nombre");
string user_response = Console.ReadLine();

int response;
int counter = 1;


while (!int.TryParse(user_response, out response) && counter < 3)
{
    Console.WriteLine($"Erreur, \"{user_response}\" n'est pas un nombre...\n\tVeuillez introduire un nombre :");
    user_response = Console.ReadLine();
    counter++;
}

if (int.TryParse(user_response, out _))
    Console.WriteLine($"Le chiffre introduit est {response}.\nVous avez fait {counter} tentative{((counter > 1) ? "s" : "")}.");
else
    Console.WriteLine($"Vous avez dépassé les 3 tentatives..."); 
*/
#endregion

#region Exemple boucle do...while
/*
string message = "Veuillez introduire un nombre";
string user_response;

int response;
int counter = 0;


do
{
    Console.WriteLine(message);
    user_response = Console.ReadLine();
    message = $"Erreur, \"{user_response}\" n'est pas un nombre...\n\tVeuillez introduire un nombre :";
    counter++;
} while (!int.TryParse(user_response, out response) && counter < 3);

if (int.TryParse(user_response, out _))
    Console.WriteLine($"Le chiffre introduit est {response}.\nVous avez fait {counter} tentative{((counter > 1) ? "s" : "")}.");
else
    Console.WriteLine($"Vous avez dépassé les 3 tentatives...");
*/
#endregion

#region Exemple boucle foreach

string[] names = {
    "Gaëlle",
    "Cassandra",
    "Sébastien",
    "An-lac",
    "Loïc",
    "Kévin",
    "Maxime",
    "Valérian",
    "Jordan"
};

foreach (string name in names)
{
    Console.WriteLine(name);
}

// Equivalent de la boucle foreach au dessus
for (int i = 0; i < names.Length; i++)
{
    string name = names[i];
    Console.WriteLine(name);
}
//BONUS
int indice = Array.IndexOf(names, "Loïc");
if(indice ==-1) Console.WriteLine("Loïc n'est pas là!");
else Console.WriteLine($"Loïc est en indice {indice}.");

#endregion