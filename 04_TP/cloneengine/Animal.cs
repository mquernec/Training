public class Animal: ICloneable
{
    private readonly Guid _id = Guid.NewGuid();
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }
    public string Cry()
    {
        return $"Cry {_id}";
    }

    public string Eat()
    {
        Console.WriteLine("start eating ");
        Thread.Sleep(1000);
        Console.WriteLine("end eating ");
        return $"Eat {_id}";
    }
    public override string ToString()
    {
        return $"{Name} is a {Age} year old {Species}";
    }

    public  object Clone()
    {
        return MemberwiseClone() as Animal;
    }
}