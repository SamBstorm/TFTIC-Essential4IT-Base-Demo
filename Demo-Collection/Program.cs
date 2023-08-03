#region Démonstration List<T>
/*
List<string> shoplist = new List<string>();
#region Exemple sans boucle
//shoplist.Add("Papier toilette");
//shoplist.Add("Savon");

//string[] necessaireBucal = new string[] { "Brosse à dent", "Dentifrice", "Bain bucale", "Fil detaire" };
//shoplist.AddRange(necessaireBucal); 
#endregion

#region Exemple avec boucle
Console.WriteLine("Veuillez indiquer les produits nécessaires :");
string input = Console.ReadLine();

while (input.ToUpper() != "FIN")
{
shoplist.Add(input);
Console.WriteLine("Veuillez indiquer les produits nécessaires :");
input = Console.ReadLine();
}

#endregion

shoplist.Sort();

foreach (string product in shoplist)
{
Console.WriteLine(product);
}

Console.WriteLine("Donner le nom d'un élément de la liste à supprimer :");
string toRemove = Console.ReadLine();

if (shoplist.Contains(toRemove))
{
shoplist.Remove(toRemove);
Console.WriteLine($"L'élément \"{toRemove}\" est supprimé.");
}
else
{
Console.WriteLine($"L'élément \"{toRemove}\" ne figure pas dans la liste.");
}

foreach (string product in shoplist)
{
Console.WriteLine(product);
}
*/
#endregion

#region Démonstration Dictionary<TKey,TValue>

Dictionary<string,int> shoplist = new Dictionary<string,int>();

Console.WriteLine("Veuillez indiquer le produit à acheter:");
string product_name = Console.ReadLine().ToUpper().Trim();

while (product_name.ToLower() != "fin")
{
    if (shoplist.ContainsKey(product_name))
    {
        Console.WriteLine($"Actuellement la quantité de {product_name} est de {shoplist[product_name]}, combien en voulez-vous ?");
        string quantity_input = Console.ReadLine();
        int quantity;
        while (!int.TryParse(quantity_input, out quantity))
        {
            Console.WriteLine("Veuillez introduire une quantité...");
            quantity_input = Console.ReadLine();
        }
        shoplist[product_name] = quantity;
    }
    else
    {
        Console.WriteLine($"Combien de {product_name} vous faut-il?");
        string quantity_input = Console.ReadLine();
        int quantity;
        while (!int.TryParse(quantity_input, out quantity))
        {
            Console.WriteLine("Veuillez introduire une quantité...");
            quantity_input = Console.ReadLine();
        }
        shoplist.Add(product_name, quantity);
    }
    if (shoplist[product_name] == 0) shoplist.Remove(product_name);
    Console.WriteLine("Veuillez indiquer le produit à acheter:");
    product_name = Console.ReadLine().ToUpper().Trim();
}

foreach (KeyValuePair<string,int> kvp in shoplist)
{
    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
}

#endregion