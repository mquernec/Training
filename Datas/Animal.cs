public class Animal
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public int Size { get; set; }
    public string Weight { get; set; }
}