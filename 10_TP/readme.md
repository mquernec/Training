## Détecteur d'Animaux

### Fonctionnalités

1. **Recherche par ID**
    - En précisant un ID, trouvez votre animal.
    - Affichez son nom et le début de son nom.
    - Si l'animal n'est pas trouvé, affichez les animaux avec les noms les plus proches.
    - Utilisez [Fastenshtein](https://github.com/DanHarltey/Fastenshtein) pour calculer la distance entre les noms.

2. **Recherche par Caractéristiques**
    - En précisant des caractéristiques (taille, poids, âge, etc.), trouvez les animaux correspondant à la description.
    - Utilisez `System.Numerics.Tensors` pour calculer la similarité.
    - Méthode recommandée : `public static float CosineSimilarity (ReadOnlySpan<float> x, ReadOnlySpan<float> y);`
    - Affichez les animaux correspondant le plus possible à la description si aucun ne correspond parfaitement.

### Ressources

- [IReadOnlyCollection<T> Documentation](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ireadonlycollection-1?view=net-8.0)