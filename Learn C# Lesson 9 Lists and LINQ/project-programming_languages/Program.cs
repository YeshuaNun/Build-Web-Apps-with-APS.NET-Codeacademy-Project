// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

    //   foreach (var l in languages) {
    //     Console.WriteLine(l.Prettify());
    //   }

    //   Console.WriteLine("Start of Query Line");
    //   var queryLanguages = languages.Select(l => $"{l.Year}, {l.Name}, {l.ChiefDeveloper}");
    //   foreach (var l in queryLanguages) {
    //     Console.WriteLine(l);
    //   }

    //   var findCSharp = languages.Where(l => l.Name.Contains("C#"));

    //   foreach (var l in findCSharp) {
    //     Console.WriteLine(l.Prettify());
    //   }

    //   var findMicrosoft = languages.Where(l => l.ChiefDeveloper.Contains("Microsoft"));
    //   foreach (var l in findMicrosoft) {
    //     Console.WriteLine(l.Prettify());
    //   }

    //   var lispHistory = languages.Where(l => l.Predecessors.Contains("Lisp"));
    //   PrettyPrintAll(lispHistory);

      var scriptQuery = languages.Where(l => l.Name.Contains("Script")).Select(l => l.Name);
      PrintAll(scriptQuery);
      
    //   Console.WriteLine(languages.Count());

    //   var between1995And2005 = languages.Where(l => l.Year>=1995&&l.Year<=2005).Select(l => $"{l.Name} was invented in {l.Year}");
    //   Console.WriteLine(between1995And2005.Count());
    //   foreach (var l in between1995And2005) {
    //     Console.WriteLine(l);
    //   }
    }

    public static void PrettyPrintAll(IEnumerable<Language> langs)
    {
        foreach (var l in langs) {
            Console.WriteLine(l.Prettify());
        }
    }

    public static void PrintAll(IEnumerable<Object> obj)
    {
        foreach (var o in obj) {
            Console.WriteLine(o);
        }
    } 
  }
}