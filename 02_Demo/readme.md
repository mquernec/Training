# Creation

```bash
dotnet new console -O demo02
```

## Classes and Structs
Creer les  strucures suivantes

```csharp
class VoitureClass
{
    public string Immat { get; set; }
    public string Couleur { get; set; }
}

struct VoitureStruct
{
    public string Immat { get; set; }
    public string Couleur { get; set; }
}

record VoitureRecord
{
    public string Immat { get; set; }
    public string Couleur { get; set; }
}
```

## Instructions

1. istancier chaque type 2 fois
2. teser l'egalité entre les instance.

3. Creer un troisieme objet de chaque type en lui assignant un objet existant
4. Changer le champ `Immat` de chaque nouvel objet
5. verifier le champ `Immat` sur les objets originaux.


## String Operations

1. Creer un string.
2. Afficher la premiere lettre lettre.
3. Afficher la'avant derniere lettre.
4. Extraire les caracters  de l'index 1 à 3.
5. Afficher tout les caracters sauf le  premier et le dernier.



## Calculator Class

Creer une class `Calculator`avec deux proprietes `Add` et `Sub`.

1. Creer une instance de la classe et lui associer les methode Add et Sub permettant de proceder a des addition ou soustraction (deux entiers en entrée, u nentier en sortie).
2. Changer la methode Add pour qu'elle procede a une multiplication

## Lambda Expressions

- Creer une lambda qui change la couleur d'une de nos voiture
  - Sous forme d'une `Func`
  - Sous forme d'une `Action`
  - Sur une  `struct`
  -Sur un `record`

## Additional Properties

- Ajouter la propriétée `Puissance` à la classe `Voiture`.
- Creer une methode `Taxe` qui renvoie le prix de la vignette pour une voiture
    - Utiliser un switch sur `Puissance` (égalitée de valeur).  
    - Utiliser un switch avec `<` et `>`.
    - Ajouter la propriétée  `AnneeProduction`.
    - Utiliser un switch sur `Puissance` et  `AnneeProduction`.

## Methods

- Créer une méthode qui produit une liste de nombre paire 
- Créer une méthode qui produit une liste de nombre impaire 
- dans chaque methode ajouter un Console.Writeline au moment de la generation d'un nombre
- Parcourir les 2 listes et afficher le resultat.

- Transformer la methode qui produit la liste de nombre imparire en ajoutant un `yield` dans la boucle.
- Observer le resultat
