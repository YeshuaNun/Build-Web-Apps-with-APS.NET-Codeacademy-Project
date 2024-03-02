// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
      
//       citiesList.Add("New York City");
      
//       citiesList.Remove("Delhi");
      
//       citiesList.AddRange(new string[] {"Cairo", "Johannesburg"});
      
//       bool hasNewDelhi = citiesList.Contains("New Delhi");
      
//       foreach (string city in citiesList)
//       {
//         Console.WriteLine(city);
//       }
//     }
//   }
// }

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     {
//         List<double> marathons = new List<double>();
//         marathons.Add(144.07);
//         marathons.Add(142.12);
//         Console.WriteLine(marathons[1]); 
//     }
//   }
// }

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<double> marathons = new List<double>
//       {
//         144.07, 143.12, 146.73, 146.33
//       };
      
//       // Do not delete the code below
//       double time = marathons[1];
      
//       Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

//     }
//   }
// }

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<double> marathons = new List<double>
//       {
//         144.07,
//         143.12,
//         146.73,
//         146.33
//       };
      
//       Console.WriteLine(marathons.Count);
//       marathons.Add(143.23);
//       Console.WriteLine(marathons.Contains(143.23));
//       Console.WriteLine(marathons.Count);
//     }
//   }
// }

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<double> marathons = new List<double>
//       {
//         144.07,
//         143.12,
//         146.73,
//         146.33
//       };
      
//       Console.WriteLine(marathons[1]);
//       bool removed = marathons.Remove(143.12);
//       Console.WriteLine(marathons[1]);
//       Console.WriteLine(removed);
//     }
//   }
// }

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<double> marathons = new List<double>
//       {
//         148.22,
//         156.10,
//         153.88,
//         155.34,
//         160.89
//       };
      
//       // Clear the list here
//       marathons.Clear();
      
      
//       Console.WriteLine($"Count: {marathons.Count}");
//     }
//   }
// }

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<double> marathons = new List<double>
//       {
//         144.07,
//         143.12,
//         146.73,
//         146.33
//       };
      
//       double futureWinner = marathons[1];
//       marathons[3] = 143.23;
      
//       Console.WriteLine("If you reached this point, there are no errors!");
//     }
//   }
// }

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     {
//       List<double> marathons = new List<double>
//       {
//         144.07,
//         143.12,
//         146.73,
//         146.33
//       };

//       List<double> topMarathons = marathons.GetRange(0, 3);
//       foreach (double value in topMarathons) {
//         Console.WriteLine(value);
//       }
//     }
//   }
// }

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     { 
//       List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
//       Random rand = new Random();
      
//       Console.WriteLine("In reverse chronological order, the gold medalists are...");
      
//       // First loop
//       for (int i = 0; i < runners.Count; i++)
//       {
//         Console.WriteLine($"{i+1}: {runners[i]}");
//       }
      
//       Console.WriteLine("\nPrinting runner bibs...");
      
//       // Second loop
//     //   for (int i = 0; i < runners.Count; i++)
//     //   {
//     //     string name = runners[i].ToUpper();
//     //     int id = rand.Next(100, 1000);
//     //     Console.WriteLine($"{id} - {name}");
//     //   }

//       foreach (string runner in runners) {
//         string name = runner.ToUpper();
//         int id = rand.Next(100, 1000);
//         Console.WriteLine($"{id} - {name}");
//       }

//     }
//   }
// }

// namespace LearnLists
// {
//   class Program
//   {
//     static void Main()
//     {
//         List<bool> a = new List<bool>();
//         List<Random> b = new List<Random>();
//         List<IServiceProvider> c = new List<IServiceProvider>(); 
//     }
//   }
// }

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };
      citiesList.Add("Grantham");
      foreach (string city in citiesList) {
        Console.WriteLine(city);
      }    
      
    }
  }
}