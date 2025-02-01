using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class Test{
    
    [TestMethod]
    public void TestClone() 
    {
        Animal a = new Animal("toto", 12, "cat");
        Animal b = CloneEngine.Clone(a);
        Assert.AreEqual(a.Name, b.Name);
        Assert.AreEqual(a.Age, b.Age);
        Assert.AreEqual(a.Species, b.Species);
    }

    [TestMethod]
    public void TestClone2() 
    {
        Animal a = new Animal("toto", 12, "cat");
        Animal b = CloneEngine.Clone2(a) as Animal;
        Assert.AreEqual(a.Name, b.Name);
        Assert.AreEqual(a.Age, b.Age);
        Assert.AreEqual(a.Species, b.Species);
    }

    [TestMethod]
    public void TestClone3() 
    {
        Animal a = new Animal("toto", 12, "cat");
        Animal b = CloneEngine.Clone<Animal>(a);
        Assert.AreEqual(a.Name, b.Name);
        Assert.AreEqual(a.Age, b.Age);
        Assert.AreEqual(a.Species, b.Species);
    }

    [TestMethod]
    [DataRow( "cat")]
    [DataRow( "chien")]
    [DataRow( "poulet")]
    public void TestCry(string species) 
    {
        List<string> cris = new List<string>();
        for (int i = 0; i < 1000; i++)
        {
            Animal a = new Animal(Faker.Name.First(), 12, species);
            cris.Add(a.Cry());
        }
        Assert.AreEqual(cris.Distinct().Count(), cris.Count);
       
    }

    [TestMethod]
    public void EnclosureAdd() 
    {
        Enclosure e = new Enclosure("enclosure");
        Animal a = new Animal("toto", 12, "cat");
        e.AddAnimal(a);
        Assert.AreEqual(e.AnimalCount(), 1);
    }

    [TestMethod]
    public void EnclosureRemove() 
    {
        Enclosure e = new Enclosure("enclosure");
        Animal a = new Animal("toto", 12, "cat");
        e.AddAnimal(a);
        e.RemoveAnimal(a);
        Assert.AreEqual(e.AnimalCount(), 0);
    }

    [TestMethod]
    public async Task EnclosureCount() 
    {
        Enclosure e = new Enclosure("enclosure");
        for (int i = 0; i < 100; i++)
        {
            Animal a = new Animal("toto", 12, "cat");
            e.AddAnimal(a);
        }   
      
       var eating=await e.EatAsync();
       //verifier que eating contient 100 fois ","
       Assert.AreEqual(100, eating.Split(",").Count()); 
        
    }


}