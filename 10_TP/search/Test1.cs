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
   
   
    /*
Pratique 10
j'ai maintenant un detecteur d'animaux,

en lui precisant un Id je veux trouver mon animal

son nom
le debut de son nom
si pas trouvé , les animaux avec les noms les plus proches


en lui precisant des caracteristiques (taille ,poids etc ....) le detecteur doit trouver les animaux correspondant a la descriptions

corespondant le plus possible a la description si personne ne correspond aprfaitement.*/

   [TestMethod]
    public void PlusGrosPlusLegerPlusGrandPlusPetit()
    {
            Aggregator aggregator = animals
           .Aggregate(new Aggregator(),(aggregate, val) => {
                               Aggregator newone =  new Aggregator();
                                newone.SizeMax = Math.Max(aggregate.SizeMax, val.Size);
                                newone.SizeMin = aggregate.SizeMin!=0 ?Math.Min(aggregate.SizeMin, val.Size):val.Size;
                                newone.WeightMax = Math.Max(aggregate.WeightMax, int.Parse(val.Weight));
                                newone.WeightMin = aggregate.WeightMin!=0?Math.Min(aggregate.WeightMin, int.Parse(val.Weight)): int.Parse(val.Weight);

                                return newone;
           });
        Assert.AreEqual(98, aggregator.SizeMax);
        Assert.AreEqual(7, aggregator.SizeMin);
        Assert.AreEqual(93, aggregator.WeightMax);
        Assert.AreEqual(10, aggregator.WeightMin);
    }


    
    [TestMethod]
    public void Where()
    {
        var firstone = animals.Where(a => a.Id == Guid.Parse( "945c2cc6-4989-4d91-a253-956227bc9475")).FirstOrDefault();
        Assert.IsNotNull(firstone);
        Assert.AreEqual("Hallie Brakus Sr.", firstone.Name);
    }

        [TestMethod]
    public void FindById()
    {
        var firstone = animals.Find(a => a.Id == Guid.Parse( "945c2cc6-4989-4d91-a253-956227bc9475"));
        Assert.IsNotNull(firstone);
        Assert.AreEqual("Hallie Brakus Sr.", firstone.Name);
    }


        [TestMethod]
    public void NameStartWith()
    {
        var firstone = animals.Where(a => a.Name.StartsWith("Hallie" )).FirstOrDefault();
        Assert.IsNotNull(firstone);
        Assert.AreEqual("Hallie Brakus Sr.", firstone.Name);
    }
}

