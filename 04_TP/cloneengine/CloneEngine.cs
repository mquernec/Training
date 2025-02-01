using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

public class CloneEngine
{
    public static Animal Clone(Animal obj)
    {
       Animal clone = new Animal(obj.Name, obj.Age, obj.Species);
         return clone;
    }

      

      public static ICloneable Clone2(ICloneable obj)
    {
         return obj.Clone() as ICloneable;
    }
    
    public static T Clone<T>(T obj)
    {
        string json = JsonSerializer.Serialize(obj);
        return JsonSerializer.Deserialize<T>(json);
     
    }
}