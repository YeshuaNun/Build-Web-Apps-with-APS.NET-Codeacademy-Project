// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace StaticMembers
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Forest.PrintTreeFacts();
//     }
//   }
// }

// namespace StaticMembers
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(Math.PI);
//         Console.WriteLine(Math.Abs(-32));
//     }
//   }
// }

// namespace ApplyingClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       if (args.Length > 0)
//       {
//         string mainPhrase = String.Join(" and ", args);
//         Console.WriteLine($"My favorite fruits are {mainPhrase}!");
//       }

      
//     }
//   }
// }

using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
         Console.WriteLine(Forest.ForestsCreated);
         Forest a = new Forest("Sherwoord");
         Forest b = new Forest("Yorkshire");
         Console.WriteLine(Forest.ForestsCreated);
    }
  }
}