using System.Text.Json;
using System.IO;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//https://github.com/Kuree/Faker.Net
/*dotnet add package Faker.Net */
List<string> species = new List<string> { "Chien", "Chat", "Oiseau", "Poisson", "Lezard","Ornithorique","Dauphin" };
int count = 100000;
int ageMax = 20;
int sizeMax = 100;
int weightMax = 100;
int enclosureCount = 100;


var outputfile = $"animals{count}.json";
var outputEnclosfile = $"enclosure{count}.json";
var outputAnimalEnclosurefile = $"enclosureAnimal{count}.json";
List<Animal> animals = new List<Animal>();
//lire le fichier outputfile et mettre le resultat dans la liste animals
if (File.Exists(outputfile))
{
    var json = File.ReadAllText(outputfile);
    animals = JsonSerializer.Deserialize<List<Animal>>(json);
}
List<Enclosure> enclosures = new List<Enclosure>();
for(int i= 0; i < enclosureCount; i++)
{
    enclosures.Add(new Enclosure { Name = $"Enclosure {i}" });
}

List<EnclosureAnimal> enclosAnimals = new List<EnclosureAnimal>();
foreach(Animal animal in animals)
{
    int dayIn = new Random().Next(1, 5);
    int dayOff =dayIn+ new Random().Next(1, 80);
    while(dayOff<365)
    {
        var enclos = enclosures[new Random().Next(0, enclosures.Count)];
        var enclosAnimal = new EnclosureAnimal { DayIn = dayIn, DayOff = dayOff, EnclosureId = enclos.Id, AnimalId = animal.Id };
        enclosAnimals.Add(enclosAnimal);
        dayIn = dayOff + new Random().Next(0, 5);
        dayOff = dayIn + new Random().Next(1, 80);
    }

}

var jsonout = JsonSerializer.Serialize(enclosures);
File.WriteAllText(outputEnclosfile, jsonout);
jsonout = JsonSerializer.Serialize(enclosAnimals);
File.WriteAllText(outputAnimalEnclosurefile, jsonout);

class Enclosure
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
}

class EnclosureAnimal
{
    public int DayIn{ get; set; } 
    public int DayOff { get; set; }
    public Guid EnclosureId { get; set; }
    public Guid AnimalId { get; set; }
}
class Animal
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public int Size { get; set; }
    public string Weight { get; set; }
}