using Demo_Structure;

Email email_prof;
//Sans new : pas de valeur initialisée dans les variables membres de la structure (obligation de les initialiser)
email_prof.body = "samuel.legrain";
email_prof.domain = "bstorm";
email_prof.extension = "be";

Console.WriteLine($"L'adresse e-mail du prof est : {email_prof.body}@{email_prof.domain}.{email_prof.extension}");

Email email_ref = new Email();
//Avec new : valeur par défaut dans les variables membres de la structure (string => null)
Console.WriteLine($"L'adresse e-mail du reférant est : {email_ref.body}@{email_ref.domain}.{email_ref.extension}");

//Avec les valeurs, c'est mieux...
email_ref.body = "thierry.morre";
email_ref.domain = "bstorm";
email_ref.extension = "be";

Console.WriteLine($"L'adresse e-mail du reférant est : {email_ref.body}@{email_ref.domain}.{email_ref.extension}");

Email email_adj = email_prof;
email_adj.body = "steve.lorent";

Console.WriteLine($"L'adresse e-mail de l'adjoint est : {email_adj.body}@{email_adj.domain}.{email_adj.extension}");
Console.WriteLine($"L'adresse e-mail du prof est : {email_prof.body}@{email_prof.domain}.{email_prof.extension}");
