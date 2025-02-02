## Créer un projet lib

### Structure "Animal"

Créer une structure `Animal` pour stocker les informations suivantes :
- Nom
- Espèce
- Taille (cm)
- Âge (années)
- Poids (grammes)

Chaque animal doit avoir un identifiant unique. Créez un animal et affichez ses informations sur la console.

### Contraintes

- Le nom doit comporter un maximum de 25 caractères.
- L'espèce ne peut pas être modifiée après la création.
- L'espèce doit appartenir à la liste suivante : "Oiseau", "Chat", "Chien", "Poisson", "Ornithorynque".
- Définir une plage autorisée pour le poids et la taille par espèce.

### Ajouts

- Ajouter le dauphin à la liste des espèces.
- Un nom par défaut doit être construit comme suit : `espece-numero_sequentiel`.
- Le constructeur peut accepter une méthode permettant de générer le numéro séquentiel.

### Génération d'exemples

- Ajouter un générateur d'exemples avec Faker.
- Installer Faker.net : [Faker.net](https://github.com/oriches/faker-cs).

### Références

- [System.ComponentModel](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel)
- [System.ComponentModel.DataAnnotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations)
- [FluentValidation](https://docs.fluentvalidation.net/en/latest/)

```csharp
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }

    [Required]
    [StringLength(10)]
    public string Name { get; set; }
}
```