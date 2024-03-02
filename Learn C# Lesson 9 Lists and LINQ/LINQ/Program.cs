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

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
  
      var shortHeroes = from h in heroes
                        where h.Length < 8
                        select h;

      // Printing...
      Console.WriteLine("Your short heroes are...");
      
      foreach (string hero in shortHeroes)
      {
        Console.WriteLine(hero);
      }
    }
  }
}