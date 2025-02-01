using System.Threading.Tasks;
using System.Threading;
public class Enclosure
{
       
    public Guid Id {  get; private set; } 
   public  string Name {  get;  private set; }
    private List<Animal> Animals { get; set; } = new();

    public Enclosure(string name)
    {
        Name = name;
    }

/// <summary>
/// Add an animal to the enclosure
/// </summary>
/// <param name="animal">Animal to Add </param>
    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        Animals.Remove(animal);
    }

    public int AnimalCount()
    {
        return Animals.Count;
    }

    public string Cry()
    {
        return string.Join(",", Animals.Select(a => a.Cry()));
    }

    public async Task<string> EatAsync()
    {

        var eatings  =await Task.WhenAll(Animals.Select(a => EatAsync(a)));
        return string.Join(",", eatings);
    }
private async Task<string> EatAsync(Animal animal)
{

 return await Task.Run(() =>
    {
    return  animal.Eat();
    });
}
}