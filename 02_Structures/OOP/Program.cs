// See https://aka.ms/new-console-template for more information
Animal fido = new Animal()
{
    Nom = "Fido",
    Espece = Especes.Chat
};

Animal felix = new Chat()
{
    Nom = "Felix"
};

felix.FaireDuBruit();

Chat grosminet = new Chat()
{
    Nom = "Grosminet"
};

grosminet.FaireDuBruit();

felix.FairePlusDeBruit();

grosminet.FairePlusDeBruit();


Animal rex = new Chien()
{
    Nom = "Rex"
};

List<Animal> animaux = new List<Animal>
{
    felix,
    grosminet,
    rex
};

Console.WriteLine($"rex est un animal ? {rex is Animal}");
Console.WriteLine($"rex est un chat ? {rex is Chat}");
Console.WriteLine($"rex est un chien ? {rex is Chien}");
Console.WriteLine($"rex est un Nageur ? {rex is INageur}");
Console.WriteLine($"rex est un Carnivore ? {rex is ICarnivore}");


foreach (var animal in animaux)
{
    animal.SeDeplacer();
}

foreach (var animal in animaux.OfType<ICarnivore>())
{
    animal.MangerViande();
}

foreach (var animal in animaux)
{
    if(animal is INageur nageur)
    {
        
        nageur.Nager();
    }
}

try{
    fido.Dormir();
}
catch(NotImplementedException e)
{
    Console.WriteLine($"J'ai un soucis : {e.Message}");
}

Nurserie maNuerserie = new Nurserie();
maNuerserie.NourrirAnimal(rex as ICarnivore);
var newOne = maNuerserie.GenererAnimal();
Console.WriteLine($"Un nouvel animal est né : {newOne.Espece}");

var newChat = maNuerserie.GenererAnimal<Chat>();

Console.WriteLine($"Un nouvel animal est né : {newChat.Espece}");

maNuerserie.Inspecter(rex);