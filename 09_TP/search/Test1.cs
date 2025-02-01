namespace search;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using System.IO;
using System;
using System.Diagnostics;
[TestClass]
public sealed class Test1
{
   private static List<Animal> animals ;
   private static List<Enclosure> enclosures ;
   private static List<EnclosureAnimal> enclosAnimals ;
    private static string inputAnimalfile = "animals10.json";
    private static string inputEnclosfile = "enclosure10.json";
    private static string inputAnimalEnclosurefile = "enclosureAnimal10.json";
    
     [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext testContext)
    {

//lire le fichier outputfile et mettre le resultat dans la liste animals
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
    }

    [TestMethod]
    public void FileLoaded()
    {      
      //verifier que  enclosAnimals.Count est superieur a 1
      Assert.IsNotNull(animals);
        Assert.IsNotNull(enclosAnimals);
       Assert.IsNotNull(enclosures);
        Assert.IsTrue(enclosAnimals.Count() > 1); 
        Assert.IsTrue(animals.Count() > 1);
        Assert.IsTrue(enclosures.Count() > 1);
    }

    [TestMethod]
    public void MostUserEnclosure()
    {

        var enclos = enclosAnimals.GroupBy(e => e.EnclosureId).OrderByDescending(e => e.Count()).First();
        var enclosure = enclosures.Where(e => e.Id == enclos.Key).First();
       
        Assert.IsTrue(enclosure.Name=="Enclosure 21");   
    }

    /*
qui a acceuillit le plus gros poids total
pour chaque enclos trouver le plus petit animal y ayant vecu.
le plus gros
le nombre d'espece differente
le nombre d'animaux different*/

  [TestMethod]
    public void BigestTotalWeight()
    {
        var enclosAnimalsGroup = enclosAnimals.GroupBy(e => e.EnclosureId);
        var enclos = enclosAnimalsGroup.Select(e => new { EnclosureId = e.Key, TotalWeight = e.Sum(e =>int.Parse(animals.Where(a => a.Id == e.AnimalId).First().Weight)) }).OrderByDescending(e => e.TotalWeight).First();
        var enclosure = enclosures.Where(e => e.Id == enclos.EnclosureId).First();
        Assert.IsTrue(enclosure.Name=="Enclosure 1");   
    }

    [TestMethod]
    public void SmallestAnimal()
    {
        var idEnclos1 = enclosures.Where(e => e.Name == "Enclosure 1").Select(e=>e.Id).First();    
        var lightest =  enclosAnimals.Where(e => e.EnclosureId == idEnclos1).Select(e => new { AnimalId = e.AnimalId, Weight = int.Parse(animals.Where(a => a.Id == e.AnimalId).First().Weight) }).OrderBy(e => e.Weight).First();
        var animal = animals.Where(a => a.Id == lightest.AnimalId).First();
        
        Assert.IsTrue(animal.Name=="Kaylah Waelchi");   
    }
      [TestMethod]
    public void BiggestAnimal()
    {

        var idEnclos1 = enclosures.Where(e => e.Name == "Enclosure 1").Select(e=>e.Id).First();    
        var lightest =  enclosAnimals.Where(e => e.EnclosureId == idEnclos1).Select(e => new { AnimalId = e.AnimalId, Weight = int.Parse(animals.Where(a => a.Id == e.AnimalId).First().Weight) }).OrderByDescending(e => e.Weight).First();
        var animal = animals.Where(a => a.Id == lightest.AnimalId).First();
        
        Assert.IsTrue(animal.Name=="Hallie Brakus Sr.");   
    }


   [TestMethod]
    public void NumberOfSpecies()
    {
        var idEnclos1 = enclosures.Where(e => e.Name == "Enclosure 1").Select(e=>e.Id).First();    
        var species =  enclosAnimals.Where(e => e.EnclosureId == idEnclos1).Select(e => animals.Where(a => a.Id == e.AnimalId).First().Species).Distinct().Count();
        Assert.IsTrue(species==3);

    }

   [TestMethod]
    public void NumberOfAnimal()
    {
        var idEnclos1 = enclosures.Where(e => e.Name == "Enclosure 1").Select(e=>e.Id).First();    
        var animalsCnt =  enclosAnimals.Where(e => e.EnclosureId == idEnclos1).Select(e => e.AnimalId).Distinct().Count();
        Assert.IsTrue(animalsCnt==3);

    }

    [TestMethod]
    public void BestFriend()
    {
       var guids = animals.Select(a => a.Id).ToList();
        Dictionary<Guid, List<EnclosureAnimal>> WhoIsWhere = new();
        Dictionary<Guid, Dictionary<Guid, int>> animalsTimes = guids.ToDictionary(guid => guid, guid => guids.ToDictionary(g => g, g => 0));

        var presences = enclosAnimals.OrderBy(e => e.DayIn).ThenBy(e => e.DayOff).ToList();
        int startDay = 0;
        int endDay = 0;

        foreach (var item in presences)
        {
            bool HasChanged = true;

            if (!WhoIsWhere.ContainsKey(item.EnclosureId))
                WhoIsWhere.Add(item.EnclosureId, new());

            if (WhoIsWhere[item.EnclosureId].Any(x => x.AnimalId == item.AnimalId))
                HasChanged = false;

            WhoIsWhere[item.EnclosureId].Add(item);
            var wheres = WhoIsWhere[item.EnclosureId].ToList();

            foreach (var where in wheres)
            {
                if (where.DayOff < item.DayIn)
                {
                    WhoIsWhere[item.EnclosureId].Remove(where);
                }
            } 

            if (HasChanged)
                {
                
                    if (WhoIsWhere[item.EnclosureId].Any(x => x.AnimalId == item.AnimalId))
                    {   
                        foreach (var crtFriend in WhoIsWhere[item.EnclosureId].Where(x => x.AnimalId != item.AnimalId))
                        {
                            animalsTimes[item.AnimalId][crtFriend.AnimalId]++;
                            animalsTimes[crtFriend.AnimalId][item.AnimalId]++;
                        }
                
                    }
                }
        }


        var bestFriend = animalsTimes.SelectMany(e => e.Value.Select(f => new { AnimalId = e.Key, FriendId = f.Key, Count = f.Value })).OrderByDescending(e => e.Count).First();
        var animal = animals.Where(a => a.Id == bestFriend.AnimalId).First();
        var friend = animals.Where(a => a.Id == bestFriend.FriendId).First();
        Assert.IsTrue(animal.Name=="Hallie Brakus Sr.");
        Assert.IsTrue(friend.Name=="Ruthe Swaniawski");

    }

    [TestMethod]
    public void MostTimeTogether   ()
        {

            
var guids = animals.Select(a => a.Id).ToList();
Dictionary<Guid, List<EnclosureAnimal>> WhoIsWhere = new();
Dictionary<Guid, Dictionary<Guid, int>> animalsTimes = guids.ToDictionary(guid => guid, guid => guids.ToDictionary(g => g, g => 0));
foreach (var enclo in enclosures)
{
    List<EnclosureAnimal> currentPresences =new();
    Dictionary<Guid, Dictionary<Guid, int>> currentAnimalsTimes = guids.ToDictionary(guid => guid, guid => guids.ToDictionary(g => g, g => 0));
    var presences = enclosAnimals.Where(ea => ea.EnclosureId==enclo.Id).OrderBy(e => e.DayIn).ThenBy(e => e.DayOff).ToList();
   if(presences.Count==0)
    {
        continue;
    }
    int startDay = presences.First().DayIn;
    int endDay = presences.First().DayOff;
    foreach (var item in presences)
    {
        foreach (var currentPresence in currentPresences.ToList())  
        {
            if (currentPresence.DayOff < item.DayIn)
            {
                currentPresences.Remove(currentPresence);
                // pour totu ceux que je regarde si les temps sont meilleurs que daons animalsTimes je les ajoute
             
            }
            else
            {
                currentAnimalsTimes[item.AnimalId][currentPresence.AnimalId] +=Math.Min(item.DayOff, currentPresence.DayOff) - Math.Max(item.DayIn, currentPresence.DayIn);
                currentAnimalsTimes[currentPresence.AnimalId][item.AnimalId] += Math.Min(item.DayOff, currentPresence.DayOff) - Math.Max(item.DayIn, currentPresence.DayIn);

               if( animalsTimes[item.AnimalId][currentPresence.AnimalId] < currentAnimalsTimes[item.AnimalId][currentPresence.AnimalId] )
                {
                     animalsTimes[item.AnimalId][currentPresence.AnimalId] = currentAnimalsTimes[item.AnimalId][currentPresence.AnimalId];
                     animalsTimes[currentPresence.AnimalId][item.AnimalId] = currentAnimalsTimes[item.AnimalId][currentPresence.AnimalId];
                }
            }
       

 
         }
        currentPresences.Add(item);
    }
    foreach (var currentAnimalTime in currentAnimalsTimes.Keys)
    {
        foreach (var currentTime in currentAnimalsTimes[currentAnimalTime].Keys)
        {
            if (animalsTimes[currentAnimalTime][currentTime] < currentAnimalsTimes[currentAnimalTime][currentTime])
            {
                animalsTimes[currentAnimalTime][currentTime] = currentAnimalsTimes[currentAnimalTime][currentTime];
                animalsTimes[currentTime][currentAnimalTime] = currentAnimalsTimes[currentAnimalTime][currentTime];
            }
        }
       
    }

}

var bestFriend = animalsTimes.SelectMany(e => e.Value.Select(f => new { AnimalId = e.Key, FriendId = f.Key, Count = f.Value })).OrderByDescending(e => e.Count).First();

var animal = animals.Where(a => a.Id == bestFriend.AnimalId).First();
var friend = animals.Where(a => a.Id == bestFriend.FriendId).First();
Console.WriteLine($"Best friend of {animal.Name} is {friend.Name} with {bestFriend.Count} days together");

        Assert.IsTrue(animal.Name=="Ms. Santino Casper DDS");
        Assert.IsTrue(friend.Name=="Devonte Santa Roob IV");
        Assert.IsTrue(bestFriend.Count==59);
        }

}

