using System.Text.Json;
using System.IO;

List<Animal> animals = new();
List<Enclosure> enclosures = new();
List<EnclosureAnimal> enclosAnimals = new();
string inputAnimalfile = "animals10.json";
string inputEnclosfile = "enclosure10.json";
string inputAnimalEnclosurefile = "enclosureAnimal10.json";

if (File.Exists(inputAnimalfile))
{
    var json = File.ReadAllText(inputAnimalfile);
    animals = JsonSerializer.Deserialize<List<Animal>>(json);
}
if (File.Exists(inputEnclosfile))
{
    var json = File.ReadAllText(inputEnclosfile);
    enclosures = JsonSerializer.Deserialize<List<Enclosure>>(json);
}
if (File.Exists(inputAnimalEnclosurefile))
{
    var json = File.ReadAllText(inputAnimalEnclosurefile);
    enclosAnimals = JsonSerializer.Deserialize<List<EnclosureAnimal>>(json);
}
var plusGrand = animals.Max(a => a.Size);
var plusPetit = animals.Min(a => a.Size);
var plusLourd = animals.Max(a => int.Parse(a.Weight));
var plusLeger = animals.Min(a => int.Parse(a.Weight));


Console.WriteLine($"Le plus grand animal mesure {plusGrand} cm");
Console.WriteLine($"Le plus petit animal mesure {plusPetit} cm");
Console.WriteLine($"Le plus lourd animal pese {plusLourd} kg");
Console.WriteLine($"Le plus leger animal pese {plusLeger} kg");