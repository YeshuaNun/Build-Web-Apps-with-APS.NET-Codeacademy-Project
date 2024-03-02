// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;

// namespace LearnLinq
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      
//       // Approach 1: without LINQ
//       List<string> longLoudHeroes = new List<string>();
      
//       foreach (string hero in heroes)
//       {
//         if (hero.Length > 6)
//         {
//           string formatted = hero.ToUpper();
//           longLoudHeroes.Add(formatted);
//         }
//       }
      
//       // Approach 2: with LINQ
//       var longLoudHeroes2 = from h in heroes
//             where h.Length > 6
//             select h.ToUpper();
      
//       // Printing...
//       Console.WriteLine("Your long loud heroes are...");
      
//         Console.WriteLine("without LINQ");
//       foreach (string hero in longLoudHeroes)
//       {
//         Console.WriteLine(hero);
//       }

//         Console.WriteLine("with LINQ");
//       foreach (string hero in longLoudHeroes2)
//       {
//         Console.WriteLine(hero);
//       }
//     }
//   }
// }

// namespace LearnLinq
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
  
//       var shortHeroes = from h in heroes
//                         where h.Length < 8
//                         select h;

//       // Printing...
//       Console.WriteLine("Your short heroes are...");
      
//       foreach (string hero in shortHeroes)
//       {
//         Console.WriteLine(hero);
//       }
//     }
//   }
// }

// namespace LearnLinq
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      
//       var shortHeroes = from h in heroes
//       where h.Length < 8
//       select h;

//       foreach (var h in shortHeroes) {
//         Console.WriteLine(h);
//       }

//       var longHeroes = heroes.Where(nameof => nameof.Length > 8);

//       Console.WriteLine(longHeroes.Count());
//     }
//   }
// }

// namespace LearnLinq
// {
//   class Program
//   {
//     static void Main()
//     {
//       string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

//       // Query syntax
//       var queryResult = from x in heroes
//                         where x.Contains("a")
//                         select $"{x} contains an 'a'";
      
//       // Method syntax
//       var methodResult = heroes
//         .Where(x => x.Contains("a"))
//         .Select(x => $"{x} contains an 'a'");
     
//       // Printing...
//       Console.WriteLine("queryResult:");
//       foreach (string s in queryResult)
//       {
//         Console.WriteLine(s);
//       }
      
//       Console.WriteLine("\nmethodResult:");
//       foreach (string s in methodResult)
//       {
//         Console.WriteLine(s);
//       }
//     }
//   }
// }

// namespace LearnLinq
// {
//   class Program
//   {
//     static void Main()
//     {
//       string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

//       var heroesWithI = from h in heroes
//       where h.Contains("i")
//       select h;

//       var underscored = from h in heroes
//       select $"{h}_";
//     }
//   }
// }

// namespace LearnLinq
// {
//   class Program
//   {
//     static void Main()
//     {
//       string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

//       var heroesWithI = heroes.Where(h => h.Contains("i"));
      
//       foreach (var h in heroesWithI) {
//         Console.WriteLine(h);
//       }
//     }
//   }
// }

// namespace LearnLinq
// {
//   class Program
//   {
//     static void Main()
//     {
//       string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

//       var heoresWithC = heroes.Where(h => h.Contains("c"));
//       var lowerHeroesWithC = heoresWithC.Select(h => h.ToLower());

//       var sameResult = heroes.Where(h => h.Contains("c")).Select(h => h.ToLower());

//       foreach (var h in sameResult) {
//         Console.WriteLine(h);
//       }
//     }
//   }
// }

// namespace LearnLinq
// {
//   class Program
//   {
//     static void Main()
//     {
//       string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

//       var introMethodHeroes = heroes.Select(h => $"Introducing...{h}!");

//       var indexQueryHeroes = from h in heroes
//       where h.Contains(" ")
//       select h.IndexOf(" ");

//       foreach (var h in introMethodHeroes) {
//         Console.WriteLine(h);
//       }

//       foreach (var h in indexQueryHeroes) {
//         Console.WriteLine(h);
//       }
//     }
//   }
// }

// namespace LearnLinq
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

//       var heroesQuery = heroesList.Where(h => h.Contains(".")||h.Contains("7"));
//       foreach (var h in heroesQuery) {
//         Console.WriteLine(h);
//       }
//     }
//   }
// }

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      
      // Query syntax
      var queryResult = from h in heroesList
        where h.Contains("a")
        select $"{h} contains an 'a'";
     
      // Printing...
      Console.WriteLine($"queryResult has {queryResult.Count()} elements");
      
      foreach (string s in queryResult)
      {
        Console.WriteLine(s);
      }

      
    }
  }
}