using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Diagnostics;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Animal animal = new Animal("Totoo", "Chien", 5);
var results = new List<ValidationResult>();
var vc = new ValidationContext(animal) ;
var isValid = Validator.TryValidateObject (animal, vc, results, true);
Console.WriteLine(isValid);
Console.WriteLine(animal);
#if DEBUG
    TraceMessage("dfsf");
     #endif


    void TraceMessage(string message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0)
{
    Console.WriteLine("message: " + message);
    Console.WriteLine("member name: " + memberName);
    Console.WriteLine("source file path: " + sourceFilePath);
    Console.WriteLine("source line number: " + sourceLineNumber);
}