// See https://aka.ms/new-console-template for more information
Pecheur premierPecheur = new Pecheur("DUPONT", "Jean");
Console.WriteLine("Nom : " +premierPecheur.Nom);
Console.WriteLine($"Prenom : {premierPecheur.Prenom}");

Pecheur secondPecheur = new Pecheur("Durant", "Pierre");
Console.WriteLine("Nom : {0}",secondPecheur.Nom);
Console.WriteLine("Prenom : {0}",secondPecheur.Prenom);

StructPecheur troisiemePecheur = new StructPecheur("Martin", "David");

StructPecheur troisiemePecheurBis = troisiemePecheur;
troisiemePecheurBis.Nom = "Dupond";

Console.WriteLine($@"Prenom : {troisiemePecheur.Prenom}
Nom : {troisiemePecheur.Nom}");

Console.WriteLine($@"Prenom : {troisiemePecheurBis.Prenom}
Nom : {troisiemePecheurBis.Nom}");

RecordPecheur quatriemePecheur = new RecordPecheur("Defunes", "Louis");
RecordPecheur quatriemePecheurBis = quatriemePecheur with { Nom = "De Funes" };

Console.WriteLine($@"Prenom : {quatriemePecheur.Prenom}
Nom : {quatriemePecheur.Nom}");

Console.WriteLine($@"Prenom : {quatriemePecheurBis.Prenom}
Nom : {quatriemePecheurBis.Nom}");

(double, int) poisson = (4.5, 3);
Console.WriteLine($"Taille du poisson   {poisson.Item1} poids du poisson {poisson.Item2}.");
// Output:
// Tuple with elements 4.5 and 3.

(double Taille, int Poid) poissonDeux = (4.5, 3);
Console.WriteLine($"taille du poisson :  {poissonDeux.Taille} poids du poisson {poissonDeux.Poid}.");
// Output:
// Sum of 3 elements is 4.5.



(double Taille, int Poid, string Couleur) poissonTrois = (4.5, 3,"Bleu");
Console.WriteLine($"taille du poisson :  {poissonTrois.Taille} poids du poisson {poissonTrois.Poid}, couleur :{poissonTrois.Couleur}.");
