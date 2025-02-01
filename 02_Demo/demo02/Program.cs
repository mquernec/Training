// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

VoitureClass voitureClass = new VoitureClass();
voitureClass.Immat = "1234";
voitureClass.Couleur = "Rouge";

VoitureClass voitureClass2 = new VoitureClass();
voitureClass2.Immat = "1234";
voitureClass2.Couleur = "Rouge";


VoitureStruct voitureStruct = new VoitureStruct();
voitureStruct.Immat = "1234";
voitureStruct.Couleur = "Rouge";

VoitureStruct voitureStruct2 = new VoitureStruct();
voitureStruct2.Immat = "1234";
voitureStruct2.Couleur = "Rouge";

VoitureRecord voitureRecord = new VoitureRecord();
voitureRecord.Immat = "1234";
voitureRecord.Couleur = "Rouge";

VoitureRecord voitureRecord2 = new VoitureRecord();
voitureRecord2.Immat = "1234";
voitureRecord2.Couleur = "Rouge";



Console.WriteLine(voitureClass == voitureClass2);
Console.WriteLine(voitureRecord == voitureRecord2);

VoitureClass voitureClass3 = voitureClass;
voitureClass3.Immat = "5678";

Console.WriteLine(voitureClass.Immat);

VoitureStruct voitureStruct3 = voitureStruct;
voitureStruct3.Immat = "5678";
Console.WriteLine(voitureStruct.Immat);

VoitureRecord voitureRecord3 = voitureRecord;
voitureRecord3 = voitureRecord3 with {Immat = "5678"};
Console.WriteLine(voitureRecord.Immat);

string tab = "abcdef";
Console.WriteLine(tab[0]);
Console.WriteLine(tab[^1]);
Console.WriteLine(tab[1..3]);
Console.WriteLine(tab[1..^1]);

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(1, 2));


var myCalculator = new Calculator();
myCalculator.Add = (a, b) => a + b;
myCalculator.Sub = (a, b) => a - b;
Console.WriteLine(myCalculator.Add(1, 2));
Console.WriteLine(myCalculator.Sub(1, 2));
myCalculator.Add = (a, b) => a * b;
Console.WriteLine(myCalculator.Add(1, 2));

Func<VoitureClass, VoitureClass> changeColor = (voiture) => { voiture.Couleur = "Bleu";
return voiture;};
Func<VoitureRecord, VoitureRecord> changeColorRecord = (voiture) => voiture with {Couleur = "Bleu"};
Console.WriteLine(changeColor(voitureClass).Couleur);
Action<VoitureClass> changeColor2 = (voiture) => { voiture.Couleur = "Vert";};
changeColor2(voitureClass);
Console.WriteLine(voitureClass.Couleur);
class Calculator
{
   public Func<int, int, int> Add {get;set;}
   public Func<int, int, int> Sub {get;set;}
}
class VoitureClass
{
    public string Immat{get;set;}
    public string Couleur{get;set;}
}

struct
VoitureStruct
{
    public string Immat{get;set;}
    public string Couleur{get;set;}
}

record
VoitureRecord
{
    public string Immat{get;set;}
    public string Couleur{get;set;}
}
