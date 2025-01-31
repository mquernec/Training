// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
    
    IEnumerable<string>  sonnetReader;
     IEnumerable<string>  peopleReader;
    
        sonnetReader =  File.ReadLines("files/Sonnet.txt");
        peopleReader = File.ReadLines("files/people.txt");


//alimenter le reader
     Regex rx = new Regex(@"[- .:,]+",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        List<String> allWords = sonnetReader
                .Select(x=>x.ToLower())
                .SelectMany(x=> rx.Split(x))
                .ToList();

/**
 * Compter le nombre total de mots et le nombre de mots distincts en minuscules en un seul passage. 
 Cet exercice utilise une classe d'assistance TotalAndDistinct
 * Votre tâche consiste à remplir Aggregate() 
 * <p>
 * Le flux est exécuté en parallèle, vous devez donc écrire une méthode combine()
 * qui fonctionne correctement.
 */

 string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

// Determine whether any string in the array is longer than "banana".
string longestName =
    fruits.Aggregate("banana",
                    (longest, next) =>
                    next.Length > longest.Length ? next : longest,
                    // Return the final result as an upper case string.
                    fruit => fruit.ToUpper());

Console.WriteLine(
    "The fruit with the longest name is {0}.",
    longestName);



         TotalAndDistinct totalAndDistinct = 
           allWords.Aggregate(new TotalAndDistinct(),(aggregate, val) => {
                               TotalAndDistinct newone =  new TotalAndDistinct();
                                newone.Accumulate(val);
                                newone.Combine(aggregate);
                                return newone;
           });
        Console.WriteLine(totalAndDistinct.GetDistinctCount());//, Is.EqualTo(81)); 
        Console.WriteLine(totalAndDistinct.GetTotalCount());//, Is.EqualTo(107)); 

  

