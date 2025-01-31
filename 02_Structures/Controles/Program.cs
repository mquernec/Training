
Pecheur[] pecheurs = [
    new Pecheur("DUPONT", "Jean"),
    new Pecheur("Durant", "Pierre"),
    new Pecheur("Martin", "David"),
    new Pecheur("Defunes", "Louis")
];

for(int i=0; i<pecheurs.Length; i++)
{
    Console.WriteLine($"{i} Nom : {pecheurs[i].Nom} Prenom : {pecheurs[i].Prenom}");
}

foreach (var item in pecheurs)
{
    Console.WriteLine($"Nom : {item.Nom} Prenom : {item.Prenom}");    
}

int cpt = 0;
do
{
   Console.WriteLine($"{cpt} Nom : {pecheurs[cpt].Nom} Prenom : {pecheurs[cpt].Prenom}");    
   cpt++; 
} while (cpt<pecheurs.Length);

 cpt = 0;
while (cpt<pecheurs.Length)
{
     Console.WriteLine($"{cpt} Nom : {pecheurs[cpt].Nom} Prenom : {pecheurs[cpt].Prenom}");    
     cpt++;
}

string nom = "DUPONT";
if(nom == "DUPONT")
{
    Console.WriteLine("Nom DUPONT");
}
else if(nom == "DURANT")
{
    Console.WriteLine("Nom DURANT");
}
else
{
    Console.WriteLine("Nom inconnu");
}

switch (nom)
{
    case "DUPONT":
        Console.WriteLine("Nom DUPONT");
        break;
    case "DURANT":
        Console.WriteLine("Nom DURANT");
        break;
    default:
        Console.WriteLine("Nom inconnu");
        break;
}

double taille = 5;

switch(taille)
 { case < 0.0:
            Console.WriteLine($"Measured value is {taille}; too low.");
            break;

        case > 15.0:
            Console.WriteLine($"Measured value is {taille}; too high.");
            break;

        case double.NaN:
            Console.WriteLine("Failed measurement.");
            break;

        default:
            Console.WriteLine($"Measured value is {taille}.");
            break;
 }

 float poids = 5.5f;


 switch ((taille, poids))
    {
        case (> 0, > 0) when taille == poids:
            Console.WriteLine($"Both measurements are valid and equal to {poids}.");
            break;

        case (> 0, > 0):
            Console.WriteLine($"First measurement is {taille}, second measurement is {poids}.");
            break;

        default:
            Console.WriteLine("One or both measurements are not valid.");
            break;
    }

var numbers = ProduceEvenNumbers(5);
Console.WriteLine("Parcourons les nombres paires.");
foreach (int i in numbers)
{
    Console.WriteLine($"nombre paire actuel : {i}");
}

 numbers = ProduceOddNumbers(5);
Console.WriteLine("Parcourons les nombres impaires");
foreach (int i in numbers)
{
    Console.WriteLine($"nombre impaire actuel : {i}");
}

IEnumerable<int> ProduceEvenNumbers(int upto)
{

    for (int i = 0; i <= upto; i += 2)
    {
        Console.WriteLine($"je me prepare a generer le nombre paire {i}");
        yield return i;

    }
    Console.WriteLine("j'ai fini de generer les nombre paires");
}


IEnumerable<int> ProduceOddNumbers(int upto)
{
    Console.WriteLine("IteratorOdd : start.");
    List<int> list = new List<int>();
    for (int i = 1; i <= upto; i += 2)
    {
        Console.WriteLine($"je me prepare a generer le nombre impaire {i}");
         list.Add( i);
   
    }
    Console.WriteLine("j'ai fini de generer les nombre simpaires");
    return list;
}