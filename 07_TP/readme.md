[Documentation LINQ en C#](https://learn.microsoft.com/fr-fr/dotnet/csharp/linq/)

## Créer un nouveau projet console

### Définir la notion d'étudiants 
```csharp
public record Etudiant(string Nom, string Prenom, Guid ID, int[] Notes);
```

Générer une liste d'étudiants avec leurs notes.

### Requêtes LINQ

- Récupérer les étudiants dont la première note est > 90.
- Creer la requetes sans.ToList() et afficher les resultats
- Apres l'affichage, ajouter un etudiant avec une premiere note a 100 et afficher les resultats

- Récupérer les étudiants dont la première note est > 90 et la quatrième est < 80.
- Regrouper les étudiants par la première lettre de leur nom.
- Calculer la moyenne de chaque étudiant.
- Calculer la moyenne par groupe d'initiale.
- Trouver les étudiants dont leur première note est supérieure à leur moyenne.

 

### Méthodes


Proposer une méthode avec cette signature:
```csharp
public IEnumerable<Etudiant> FiltrerEtudiants(string? Nom, string? Prenom, Guid? ID);
```
et qui renvoie les étudiants répondant à ces critères s'ils ont été valorisés.

Transformer la methode pour qu'elle renvoie  simplement filtre a ajouter comme predicat dans une requete linq
