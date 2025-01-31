// See https://aka.ms/new-console-template for more information
List<Pecheur> pecheurs = new List<Pecheur>
{
    new Pecheur("DUPONT", "Jean"),
    new Pecheur("Durant", "Pierre"),
    new Pecheur("Martin", "David"),
    new Pecheur("Defunes", "Louis")
};

var martins = 
    from pecheur in pecheurs
    where pecheur.Nom == "Martin"	
    select pecheur;

Console.WriteLine(" Pecheurs nommés Martin :");
foreach (var pecheur in martins)
{
    Console.WriteLine($"Nom : {pecheur.Nom} Prenom : {pecheur.Prenom}");
}

var duponts =  pecheurs.Where(pecheur => pecheur.Nom == "DUPONT").ToList();

var autreDuponts    = pecheurs.Where(pecheur => pecheur.Nom == "DUPONT")   ;
Console.WriteLine(" Pecheurs nommés Dupont :");
foreach (var pecheur in duponts)
{
    Console.WriteLine($"Nom : {pecheur.Nom} Prenom : {pecheur.Prenom}");
}
Console.WriteLine(" Pecheurs nommés Dupont (autre) :");
foreach (var pecheur in autreDuponts)
{
    Console.WriteLine($"Nom : {pecheur.Nom} Prenom : {pecheur.Prenom}");
}
pecheurs.Add(new Pecheur("DUPONT", "Paul"));

Console.WriteLine(" Pecheurs nommés Dupont :");
foreach (var pecheur in duponts)
{
    Console.WriteLine($"Nom : {pecheur.Nom} Prenom : {pecheur.Prenom}");
}


Console.WriteLine(" Pecheurs nommés Dupont (autre) :");
foreach (var pecheur in autreDuponts)
{
    Console.WriteLine($"Nom : {pecheur.Nom} Prenom : {pecheur.Prenom}");
}

var durants =  pecheurs.Where(pecheur => IsDurant(pecheur)).ToList();
Console.WriteLine(" nb pecheurs nommés Durant :" +durants.Count);
Func<Pecheur, bool> predicat = IsDurant;
var durantsBis =  pecheurs.Where(predicat).ToList();
Console.WriteLine(" nb pecheurs nommés Durant (bis) :" +durantsBis.Count);
predicat =IsMartin;
var martinsTer =  pecheurs.Where(predicat).ToList();

Console.WriteLine(" nb pecheurs nommés Martin :" +martinsTer.Count);

 bool IsDurant( Pecheur pecheur)
{
    return pecheur.Nom == "Durant";
}

 bool IsMartin( Pecheur pecheur)
{
    return pecheur.Nom == "Martin";
}

